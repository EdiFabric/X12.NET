Thank you for downloading EdiFabric's X12 examples

1. Overview
The examples are organized into different projects in two logical categories: by product feature and by message type. All examples are provided for both .NET Framework 4.8 and .NET 6 in separate Visual Studio solutions.

2. Requirements
- Visual Studio, compatible with the supported .NET versions
- Minimum .NET Framework 4.8 or .NET 6. Downgrade to .NET Framework 4.5 is possible by changing the target framework for each project.

3. Serial Key and EdiFabric DLLs
All projects reference EdiFabric EDI Tools as NuGet packages from nuget.org. If you wish to install EdiFabric EDI Tools as DLLs, download the trial DLLs from https://sowl.co/oApEt. 

4. Setup
Rebuild the solution with Package Restore enabled. If there are any build errors, manually install the missing packages from https://www.nuget.org/packages?q=edifabric.

5. Getting started
To get started, set project EdiFabric.Examples.X12.Demo as the startup project, open Program.cs and follow the instructions there. This project allows you to quickly translate your own EDI files.

6. Examples by feature
Explore the different features of EdiFabric, such as translating from EDI file (ReadEDI), generating EDI file (WriteEDI), validating EDI transactions (ValidateEDI), 
import/export from/to JSON , XML, CSV, create/save/query database (DB), generate CONTRL acknowledgments (AcknowledgeEDI) and how to map to/from an EDI template using Automapper and XSLT (MapEDI).

7. Examples by message type
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

8. Validation
All templates in EdiFabric.Templates.X12 and EdiFabric.Templates.Hipaa can be used for validation. 

9. EDI Templates
The trial comes with the following prebuilt template assemblies:

EdiFabric.Templates.X12.dll - X12 ASC 004010
EdiFabric.Templates.Hipaa.dll - X12 HIPAA 5010

EdiFabric supports all X12/HIPAA versions and message types. We have an extensive library of EDI templates, however, if you can't find a particular transaction, please let us know. 
The following templates are available out-of-the-box:

X12
https://support.edifabric.com/hc/en-us/articles/360000360572-X12-2040-to-4010

HIPAA
https://support.edifabric.com/hc/en-us/articles/360000372751-HIPAA-270-271-276-277-278-820-834-835-837-999

For an interactive view of all templates, go to EdiNation (no registration is required):
https://edination.com/edi-formats.html

10. Trial use
The trial serial key is valid for 14 days, and using the product with a trial license is subject to EdiFabric's license terms available at https://www.edifabric.com/files/eula.pdf. Upon expiry, the product will begin throwing exceptions. 
To continue using the trial and the examples, you'll need to request a trial extension.

11. Warranty
The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the
implied warranties of merchantability and/or fitness for a particular purpose.

12. Additional information

Install EdiFabric
https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric

Trial and examples
https://support.edifabric.com/hc/en-us/articles/360000280532-Trial-and-Examples

EdiFabric tutorial
https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics

Knowledge Base
https://support.edifabric.com

Support
https://support.edifabric.com/hc/en-us/requests/new

Last updated on June 20, 2023
2023 � EdiFabric