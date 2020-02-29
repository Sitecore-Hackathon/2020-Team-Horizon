# Documentation

Team Horizon took the challenge of building a refreshed Sitecore Hackathon Website using Sitecore XP 9.3

## Summary

**Category:** 3. Sitecore Hackathon Website 

To see how quickly we can produce a refreshed Sitecore Hackathon Website.

## Pre-requisites

Does your module rely on other Sitecore modules or frameworks?

- [Sitecore Experience Accelerator 9.3.0](https://dev.sitecore.net/Downloads/Sitecore_Experience_Accelerator/9x/Sitecore_Experience_Accelerator_930.aspx)
- [Helixbase](https://github.com/muso31/Helixbase)

## Installation

Provide detailed instructions on how to install the module, and include screenshots where necessary.

*Please Install Visual Studio 2017 Version 15.7 or higher as this project uses PackageReference

1. Install Sitecore Experience Platform 9.3 Initial Release
2. Clone project to 'C:\2020-Team-Horizon'<br>
 <em>If you use another path, update the z.Project.Common.DevSettings.config</em>
3. Update the 'publishUrl' property in Local.pubxml to the target IIS folder
4. Build the project from inside Visual Studio (which triggers HPP auto publish), or use the 'Local' publish profile in the Hackathon.TeamHorizon.Website project
5. Run Unicorn and sync all configurations

## Configuration

How do you configure your module once it is installed? Are there items that need to be updated with settings, or maybe config files need to have keys updated?

Remember you are using Markdown, you can provide code samples too:

```xml
<?xml version="1.0"?>
<!--
  Purpose: Configuration settings for my hackathon module
-->
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <settings>
      <setting name="MyModule.Setting" value="Hackathon" />
    </settings>
  </sitecore>
</configuration>
```

## Usage

This is a standalone refreshed website. Use the standard Sitecore tooling including Content Editor, Experience Editor to update and publish content


## Video

Please provide a video highlighing your Hackathon module submission and provide a link to the video. Either a [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
