[![Build status](https://ci.appveyor.com/api/projects/status/rn7y6bm4gn9o6yqa?svg=true)](https://ci.appveyor.com/project/IInvocation/datevsharp)
![Nuget version](https://img.shields.io/nuget/v/FluiTec.DatevSharp.svg)

# DatevSharp #

### What is this repository for? ###

* This repository provides access to the DATEV-interface

### What can you expect ###
The only thing this repository provides - is a clean library for validating and exporting DATEV-conform data in typical type-safe C#-Code.

### Sample ###
This project, contains a small sample of how to export sample data for: addresses, termsofpayment, bookings.

### v1.1 Changes ###
Versions starting with v1.1.0 use a different approach of generating
datev-compatible output. As of now - everything aside from validation is
based on the original format-files of the datev-documentation. Headers
are generatec completely from those files. Data-rows are generated using
the attributes DatevRow and DatevField (to associate classes with the formats)
as well as ClassMaps that define how associated properties are formatted on output.

This also enables you to pick a different version. By default - by assigning a DataCategory
to a DatevFile - you're assigning the default datev-version as defined in format_map.json
(currently: 700) - however - you can easily use another version by assigning
a DataVersion upon creating a DatevFile.

### In case you're missing something ###

#### New export-types ####
Exports types need several changes:
* entries in DataCategories.cs
* new xml files in Formats/yourfolder/
* changes in format_map.json
* new type of rows
* new type of classmap
* new validator
* new unittests

#### new fields in existing types ####
* new property in the desired type of row
* [DatevField]-Attribute for the newly created property
* new Map-Call in the respective ClassMap

### Nuget ###
https://www.nuget.org/packages/FluiTec.DatevSharp/
PM> Install-Package FluiTec.DatevSharp

### Frameworks ###
* NET 4.5.2
* NET 4.6.1
* NETSTANDARD 2.0
* NET 6.0