SDK Contents: 

0.	For a quick translation of EDI files, go to EdiFabric.Sdk.Demo project

TRIAL LIMITATIONS:
All trial products (Demo and SDK) grant you evaluation license for 14 days.
The performance of the trial version is slower than the real version.
The size of the assemblies in the trial version is larger than the real assemblies.
The trial supports .NET Framework 4.5 and .NET Core 2.0.
The trial has a file size limitation of 2 KB.

1.	For examples on how to translate\parse\read EDI files, search for the following projects:

For X12 or HIPAA:		EdiFabric.Sdk.X12.Read
For EDIFACT or EANCOM:	EdiFabric.Sdk.Edifact.Read
For VDA:					EdiFabric.Sdk.Vda.Read

2.	For examples on how to create\generate\write EDI files, search for the following projects:

For X12 or HIPAA:		EdiFabric.Sdk.X12.Write
For EDIFACT or EANCOM:	EdiFabric.Sdk.Edifact.Write
For VDA:					EdiFabric.Sdk.Vda.Write

3.	For examples on how to generate acknowledgments, search for the following projects:

For X12 or HIPAA:		EdiFabric.Sdk.X12.Acknowledge
For EDIFACT or EANCOM:	EdiFabric.Sdk.Edifact.Acknowledge

4.	For examples on how to serialize\deserialize to\from XML, search for the following projects:

For X12 or HIPAA:		EdiFabric.Sdk.X12.Export.Xml
For EDIFACT or EANCOM:	EdiFabric.Sdk.Edifact.Export.Xml

5.	For example templates, search for the following projects:

For X12:			EdiFabric.Sdk.X12.Templates.V004010
For HIPAA:		EdiFabric.Sdk.Hipaa.Templates.V005010
For EDIFACT:		EdiFabric.Sdk.Edifact.Templates.D96A
				EdiFabric.Sdk.Edifact.Templates.Smdg
				EdiFabric.Sdk.Edifact.Templates.USCustoms
For EANCOM:		EdiFabric.Sdk.Eancom.Templates.D01B.Syntax3
For VDA:			EdiFabric.Sdk.Vda.Templates

6.	For transaction specific examples, search for the following projects:

For X12:			EdiFabric.Sdk.X12.T210
				EdiFabric.Sdk.X12.T214
				EdiFabric.Sdk.X12.T404
				EdiFabric.Sdk.X12.T810
				EdiFabric.Sdk.X12.T824
				EdiFabric.Sdk.X12.T832
				EdiFabric.Sdk.X12.T850
				EdiFabric.Sdk.X12.T855
				EdiFabric.Sdk.X12.T856
				EdiFabric.Sdk.X12.T857
				EdiFabric.Sdk.X12.T861

For HIPAA:		EdiFabric.Sdk.Hipaa.T270	
				EdiFabric.Sdk.Hipaa.T271
				EdiFabric.Sdk.Hipaa.T276
				EdiFabric.Sdk.Hipaa.T277
				EdiFabric.Sdk.Hipaa.T277
				EdiFabric.Sdk.Hipaa.T820
				EdiFabric.Sdk.Hipaa.T834
				EdiFabric.Sdk.Hipaa.T835
				EdiFabric.Sdk.Hipaa.T837D
				EdiFabric.Sdk.Hipaa.T837I
				EdiFabric.Sdk.Hipaa.T837P

For EDIFACT:		EdiFabric.Sdk.Edifact.BAPLIE	
				EdiFabric.Sdk.Edifact.CUSCAR
				EdiFabric.Sdk.Edifact.DESADV
				EdiFabric.Sdk.Edifact.IFTMIN
				EdiFabric.Sdk.Edifact.IFTSTA
				EdiFabric.Sdk.Edifact.INVOIC
				EdiFabric.Sdk.Edifact.ORDERS
				EdiFabric.Sdk.Edifact.ORDRSP
				EdiFabric.Sdk.Edifact.PAXLST
				EdiFabric.Sdk.Edifact.PNRGOV
				EdiFabric.Sdk.Edifact.PRICAT

For EANCOM:		EdiFabric.Sdk.Eancom.INVOIC

7.	For additional EDI Templates (that do not support validation), install from NuGet:

For HIPAA:		Install-Package EdiFabric.Templates.Hipaa -Version 1.0.0

For X12:			Install-Package EdiFabric.Templates.X12 -Version 1.0.0

For EDIFACT:		Install-Package EdiFabric.Templates.Edifact -Version 1.0.0

For VDA:			Install-Package EdiFabric.Templates.Vda -Version 1.0.0

For PNRGOV:		Install-Package EdiFabric.Templates.Padis -Version 1.0.0



If you have any questions, please do not hesitate to contact us at office@edifabric.com
