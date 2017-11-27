# Lykke.OneSky #
C# client for OneSky API.

[<img src="https://img.shields.io/nuget/v/Lykke.OneSky.svg">](https://www.nuget.org/packages/Lykke.OneSky/)

## Information ##

### Installation ###
Install NuGet package:

1. Run `Install-Package Lykke.OneSky` in the _Package Manager Console_
2. Or find package in _NuGet Package Manager_

Or just _Pull & Compile_

### Dependencies ###
* **Newtonsoft.Json** [For JSON interaction]

### Quick Start ###
```csharp
// Creating OneSky Client
var oneskyClient = Lykke.OneSky.Json.OneSkyClient.CreateClient(
    "Your public API key",
    "Your secret API key");

// Creating 'Project Group' and 'Project'
var projectGroup = oneskyClient.Platform.ProjectGroup
    .Create("QuickStart group", "by" /*your locale*/).Data;
var project = oneskyClient.Platform.Project
    .Create(projectGroup.Id, "QuickStart project").Data;

// Uploading 2 files - for base locale and for 'en' locale
oneskyClient.Platform.File
    .Upload(project.Id, "Path/To/Your/File.ext", "INI" /*or your file format*/);
oneskyClient.Platform.File
    .Upload(project.Id, "Path/To/Your/File.InEn.ext", "INI", "en");

// Downloading tranlsation for specific locale ('en') and saving it to file
var translation = oneskyClient.Platform.Translation
    .Export(project.Id, "en", "File.ext").Data;
System.IO.File.WriteAllBytes(
    "Path/To/Save/Translation.ext",
    Encoding.UTF8.GetBytes(translation));
```
To find your API keys please go to [OneSky Support](https://support.oneskyapp.com/hc/en-us/articles/206887797-How-to-find-your-API-keys-) page.

For more information go to [Wiki](https://github.com/QuadRatNewBy/OneSky-DotNet/wiki/Home) *(Soon)*

### Documentation ###
* Official [Platform](https://github.com/onesky/api-documentation-platform) and [Plugin](https://github.com/onesky/api-documentation-plugin) API Documentations

### Credits ###
* [OneSkyApp](http://www.oneskyapp.com/) Team - Thanks for translation platform itself  
 
## Repository ##

### Repository Structure ###

* **Lykke.OneSky**: Main library project.
* **Lykke.OneSky.Example**: Example for use.

### Contribution ###
* Pull requests are very welcome! Don't forget to use separate branch for each separate pull request.
* If you have an idea, found bug or have a question - feel free to create new [Issue](https://github.com/QuadRatNewBy/Lykke.OneSky/issues) 

## License ##
[MIT](LICENSE.md)
