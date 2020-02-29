using AutoFixture;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Hackathon.TeamHorizon.Foundation.ORM.Models;
using Sitecore.Data;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Hackathon.TeamHorizon.Foundation.Testing.Extensions
{
    public static class DbExtensions
    {
        /// <summary>
        /// Creates items and fields in fake db using AutoFixture to create values and the Type to get field names
        /// </summary>
        /// <remarks>
        /// Currently doesn't handle image field
        /// </remarks>
        public static void Add(this Db db, string name, ID id, Type type, IFixture fixture, ID parentId = null)
        {
            var properties = type.GetPublicProperties();
            var sitecoreType = type.GetCustomAttribute<SitecoreTypeAttribute>();
            DbItem dbItem = null;
            if (ID.TryParse(sitecoreType?.TemplateId, out var templateId))
            {
                dbItem = new DbItem(name, id, templateId);
            }
            else
            {
                dbItem = new DbItem(name, id);
            }

            if (parentId != (ID)null)
            {
                dbItem.ParentID = parentId;
            }
            Type childType = null;
            foreach (var property in properties)
            {
                var fieldName = property.Name;
                var fieldId = GetFieldId(property);
                if (property.PropertyType == typeof(string))
                {
                    dbItem.Add(BuildField(fieldName, fieldId, fixture.Create<string>()));
                }
                else if (property.PropertyType == typeof(int))
                {
                    dbItem.Add(BuildField(fieldName, fieldId, fixture.Create<int>().ToString()));
                }
                else if (property.PropertyType == typeof(bool))
                {
                    dbItem.Add(BuildField(fieldName, fieldId, fixture.Create<bool>() ? "1" : "0"));
                }
                else if (property.PropertyType == typeof(Link))
                {
                    dbItem.Add(BuildLinkField(fieldName, fieldId, fixture.Create<Uri>().ToString()));
                }
                else if (property.PropertyType.IsAssignableToGenericType(typeof(IEnumerable<>)))
                {
                    var propertyType = property.PropertyType.GetGenericArguments()[0];
                    if (property.GetCustomAttribute<SitecoreChildrenAttribute>() == null)
                    {
                        var referenceItemsIds = new List<string>();
                        for (var i = 0; i < 3; i++)
                        {
                            var referenceItemId = ID.NewID;
                            Add(db, "name-" + referenceItemId, referenceItemId, propertyType, fixture);
                            referenceItemsIds.Add(referenceItemId.ToString());
                        }
                        dbItem.Add(BuildField(fieldName, fieldId, string.Join("|", referenceItemsIds)));
                    }
                    else
                    {
                        childType = propertyType;
                    }
                }
                else if (typeof(ISitecoreId).IsAssignableFrom(property.PropertyType))
                {
                    var referenceItemId = ID.NewID;
                    Add(db, "name-" + referenceItemId, referenceItemId, property.PropertyType, fixture);
                    dbItem.Add(BuildField(fieldName, fieldId, referenceItemId.ToString()));
                }
            }
            db.Add(dbItem);
            if (childType != null)
            {
                for (var i = 0; i < 3; i++)
                {
                    var referenceItemId = ID.NewID;
                    Add(db, "name-" + referenceItemId, referenceItemId, childType, fixture, dbItem.ID);
                }
            }
        }

        private static ID GetFieldId(PropertyInfo property)
        {
            var sitecoreFieldAttribute = property.GetCustomAttribute<SitecoreFieldAttribute>(false);
            var fieldId = sitecoreFieldAttribute != null ? sitecoreFieldAttribute.FieldId : null;
            if (fieldId != null)
            {
                return ID.Parse(fieldId);
            }
            return ID.Null;
        }

        private static DbField BuildField(string name, ID id, string value)
        {
            if (id == ID.Null)
            {
                return new DbField(name) { Value = value };
            }
            else
            {
                return new DbField(name, id) { Value = value };
            }
        }

        private static DbField BuildLinkField(string name, ID id, string value)
        {
            if (id == ID.Null)
            {
                return new DbLinkField(name) { Value = value };
            }
            else
            {
                return new DbLinkField(name, id) { LinkType = "external", Url = value };
            }
        }
    }
}