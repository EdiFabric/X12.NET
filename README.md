# EdiFabric Examples for X12 4010 and HIPAA 5010

## 1. Overview
EdiFabric is a software development kit for .NET Framework and .NET Core, which makes it straightforward to parse, generate, validate, acknowledge, split, customize, or in other words, to programmatically manipulate EDI files. It is written in C# and is distributed as a set of NuGet packages and C# files.  

It currently supports all message types for the X12 and EDIFACT EDI standards, the German automotive standard VDA, as well as custom formatted flat files (delimited, positional, or a mixture of both).  

> NOTE: EdiFabric does not provide any communication components (AS2 or SFTP, for example), has no dashboard or UI, and is not a full end-to-end EDI solution.
The best option to get the gist of what EdiFabric is, and can do, is to play around with the trial and examples.  

The examples are organized into different projects in two logical categories: by product feature and by message type.    

```C#
var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Hipaa\ClaimPayment.txt");

List<IEdiItem> ediItems;
using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.Hipaa"))
    ediItems = ediReader.ReadToEnd().ToList();

var transactions = ediItems.OfType<TS837P>();
```

## 2. Requirements
- Visual Studio, compatible with the supported .NET versions.  
- Minimum .NET Framework 4.5 or .NET Core 3.1. All projects target .NET Framework 4.5, however, the Target Framework from each project's properties can be changed to .NET Core 3.1.  
- EdiFabric trial NuGet packages and serial key.  

## 3. Setup
Rebuild the solution to install EdiFabric Trial from nuget.org. If there are any build errors, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.  

> NOTE: it is possible to also reference DLLs instead of NuGet packages. Change the .nupkg extension of the packages to .zip, unzip them, and extract the DLL files. 
Then uninstall the NuGet packages from each project and replace them with DLL references.  

## 4. Serial Key
[Download the serial key](https://sowl.co/oApEt). The serial key is included in the file serial.key in folder edifabric-trial. Ensure it is there and that the file is not empty. The serial key is loaded in the file SerialKey.cs in project EdiFabric.Examples.X12.Common. Open the file and ensure that the serialKeyPath is correct. 
If the serial number is invalid or the file is missing, contact us at https://support.edifabric.com/hc/en-us/requests/new for assistance.  

## 5. Getting started
To get started, set project EdiFabric.Examples.X12.Demo as the startup project, open Program.cs and follow the instructions there. This project allows you to quickly translate your own EDI files.  

## 6. Examples by feature
Explore the different features of EdiFabric, such as translating from EDI file (ReadEDI), generating EDI file (WriteEDI), validating EDI transactions (ValidateEDI), 
import/export from/to JSON , XML, CSV, create/save/query database (DB), generate CONTRL acknowledgments (AcknowledgeEDI) and how to map to/from an EDI template using Automapper and XSLT (MapEDI).  

## 7. Examples by message type
Explore how to translate from and generate several of the most popular X12 and HIPAA transactions. The following examples are included; please let us know if you need a different one:  

X12 4010 210  
X12 4010 214  
X12 4010 404  
X12 4010 810  
X12 4010 824  
X12 4010 832  
X12 4010 850  
X12 4010 855  
X12 4010 856  
X12 4010 857  
X12 4010 861  
X12 4010 945  

HIPAA 5010 270  
HIPAA 5010 271  
HIPAA 5010 276  
HIPAA 5010 277  
HIPAA 5010 278  
HIPAA 5010 820  
HIPAA 5010 820 HIX  
HIPAA 5010 834  
HIPAA 5010 835  
HIPAA 5010 837D  
HIPAA 5010 837I  
HIPAA 5010 837P  

## 8. EDI Validation
All templates in EdiFabric.Templates.X12 and EdiFabric.Templates.Hipaa can be used for validation.  

## 9. EDI Templates
EdiFabric supports all X12/HIPAA versions and message types. We have an extensive library of EDI templates, however, if you can't find a particular transaction, please let us know.   
The following templates are available out-of-the-box:  

[X12](https://support.edifabric.com/hc/en-us/articles/360000360572-X12-2040-to-4010)

[HIPAA](https://support.edifabric.com/hc/en-us/articles/360000372751-HIPAA-270-271-276-277-278-820-834-835-837-999)

For an interactive view of all templates go to EdiNation's EDI Webpad (no registration is required):

[X12](https://www.edination.com/edi-models-x12.html)

[HIPAA](https://www.edination.com/edi-models-hipaa.html)

[IAIABC](https://www.edination.com/edi-models-iaiabc.html)

## 10. Trial use
The trial assemblies are valid for 14 days and are subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the trial packages will begin throwing exceptions.   
To continue using the trial and the examples, you'll need to either request a trial extension or replace the trial packages, together with all references to the trial packages, with the full version of EdiFabric.  

## 11. Warranty
*The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the implied warranties of merchantability and/or fitness for a particular purpose.*

## 12. Additional information

[Install EdiFabric](https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric)

[Trial and Examples](https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples)

[EdiFabric Tutorial](https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics)

[Knowledge Base](https://support.edifabric.com)

[Support](https://support.edifabric.com/hc/en-us/requests/new)

Last updated on January 7, 2021
### 2021 © EdiFabric
