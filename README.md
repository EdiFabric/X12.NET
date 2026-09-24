# EdiFabric C# .NET Examples for X12

**EdiFabric 11.0.0** is a .NET SDK that parses, generates, validates, acknowledges, and splits EDI files. These examples cover **X12 4010** and **HIPAA 5010**.

EdiFabric does not include communication components (AS2 or SFTP), a dashboard, or a UI. It is a library you call from your own application.

The .NET 6 projects compile the same sources as the .NET Framework 4.8 projects. Both solutions reference [EdiFabric 11.0.0](https://www.nuget.org/packages/EdiFabric) and the template packages from NuGet. The examples target .NET 6 for backward compatibility. EdiFabric 11.0.0 also ships targets for .NET 8, .NET 9, and .NET 10. To evaluate one of those, change `TargetFramework` in the project file and rebuild.

| Path | Purpose |
| --- | --- |
| `NET 6/EdiFabric.Examples.X12.sln` | .NET 6 solution |
| `NET Framework 4.8/EdiFabric.Examples.X12.sln` | .NET Framework 4.8 solution |
| `NET Framework 4.8/EdiFabric.Examples.X12.Common/Config.cs` | Serial key shared by every example |
| `NET Framework 4.8/EdiFabric.Examples.X12.Demo/Program.cs` | Runnable walkthrough: read, then validate |
| `Files/` | Sample X12 and HIPAA interchanges |

## Requirements

- Visual Studio 2022, or the .NET SDK. [Download Visual Studio](https://visualstudio.microsoft.com/downloads/).
- .NET 6 for `NET 6/EdiFabric.Examples.X12.sln`. The projects set `<TargetFramework>net6.0</TargetFramework>` so they stay compatible with existing .NET 6 apps. EdiFabric 11.0.0 also provides `net8.0`, `net9.0`, and `net10.0`. To evaluate a later version, change that property (for example to `net8.0`) and rebuild.
- .NET Framework 4.8 for `NET Framework 4.8/EdiFabric.Examples.X12.sln`.

1. [Sign up free for **Community**](https://www.edifabric.com/pricing.html) to get an evaluation serial key. Community never expires, requires no credit card, and is limited to 250 operations per day for non-production use. After signup, retrieve your serial from [Your Account](https://support.edifabric.com/hc/en-us/articles/360007159031-Your-Account-API-key).
2. Paste that serial into `TrialSerialKey` in `NET Framework 4.8/EdiFabric.Examples.X12.Common/Config.cs`. The .NET 6 projects link this file, so one edit covers both solutions.

NuGet restore pulls **EdiFabric 11.0.0**, **EdiFabric.Templates.X12 3.0.0**, and, where a project needs them, **EdiFabric.Templates.Hipaa 3.0.0**.

## Getting started

**Sign up free for Community** at [edifabric.com/pricing](https://www.edifabric.com/pricing.html) and put your serial in `Config.TrialSerialKey`. Then open a solution, set **EdiFabric.Examples.X12.Demo** as the startup project, and run it.

From the command line:

```bash
cd "NET 6/EdiFabric.Examples.X12.Demo"
dotnet run
```

The demo reads `Files/X12/PurchaseOrders.txt` with `EdiFabric.Templates.X12` and `Files/HIPAA/ClaimPayment.txt` with `EdiFabric.Templates.Hipaa`. It parses every transaction with `X12Reader` and validates each one with `IsValid`. Set a breakpoint at the end of `Translate_X12_4010` or `Translate_HIPAA_5010` and inspect `ediItems`.

To translate your own file, change the path in `EdiFabric.Examples.X12.Demo/Program.cs`.

## Usage

Every example calls `License.SetSerial` before it reads or writes. On Community that is the call to use. See [Licensing](#licensing) for Developer and Enterprise.

```csharp
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.X12004010;

License.SetSerial(serial);   // from your Community or paid plan

var ediStream = File.OpenRead(@"Files\X12\PurchaseOrders.txt");

List<IEdiItem> ediItems;
using (var ediReader = new X12Reader(ediStream, "EdiFabric.Templates.X12"))
    ediItems = ediReader.ReadToEnd().ToList();

var purchaseOrders = ediItems.OfType<TS850>();
```

`X12Reader` takes the stream and the template assembly name (`EdiFabric.Templates.X12` or `EdiFabric.Templates.Hipaa`). `ReadToEnd` loads the interchange into memory. For large files, use the streaming samples in **ReadEDI**.

### Validation and acknowledgments

After a transaction parses, `IsValid` checks it against the template. **ValidateEDI** shows custom codes, data types, and ISA and GS. **AcknowledgeEDI** builds a 997 for a valid group, an invalid group, and duplicates.

```csharp
foreach (var message in ediItems.OfType<EdiMessage>())
{
    if (message.HasErrors)
        continue;

    MessageErrorContext mec;
    if (!message.IsValid(out mec))
    {
        var validationIssues = mec.Flatten();
    }
}
```

### Writing EDI

**WriteEDI** builds an interchange with `X12Writer`: ISA, then GS, then the transaction. The same project covers custom delimiters, a postfix after each segment, batches, and empty data elements.

```csharp
using (var stream = new MemoryStream())
{
    using (var writer = new X12Writer(stream))
    {
        writer.Write(SegmentBuilders.BuildIsa("1"));
        writer.Write(SegmentBuilders.BuildGs("1"));
        writer.Write(invoice);
    }
}
```

## Examples by feature

| Project | What it shows |
| --- | --- |
| `EdiFabric.Examples.X12.Demo` | Read an X12 4010 file and a HIPAA 5010 file, then validate each transaction |
| `EdiFabric.Examples.X12.ReadEDI` | Read to end, stream, batch, split on a repeating loop, corrupt files, partner templates, custom ISA/GS |
| `EdiFabric.Examples.X12.WriteEDI` | Write to a stream or file, delimiters, new lines, batches, empty elements, no auto trailers |
| `EdiFabric.Examples.X12.ValidateEDI` | Validate after read and before write, custom codes, data types, ISA and GS, 810, 850, and 837P |
| `EdiFabric.Examples.X12.AcknowledgeEDI` | Generate and read 997 |
| `EdiFabric.Examples.X12.JSON` | Serialize and deserialize JSON |
| `EdiFabric.Examples.X12.XML` | `XmlSerializer` and `DataContractSerializer` |
| `EdiFabric.Examples.X12.CSV` | Import and export CSV |
| `EdiFabric.Examples.X12.DB` | Save and reload an 850 with EF Core (create the database before you run it) |
| `EdiFabric.Examples.X12.T837P.DB` | Save and reload an 837P with EF Core (create the database before you run it) |
| `EdiFabric.Examples.X12.MapEDI` | Map with AutoMapper and XSLT |
| `EdiFabric.Examples.X12.ModifyTemplates` | Parse a partner-specific 850 template |
| `EdiFabric.Examples.X12.Templates` | Example EDI templates |

## Examples by message type

Each project reads a sample file and writes the same transaction back out.

| Project | Transaction |
| --- | --- |
| `EdiFabric.Examples.X12.T210` | X12 4010 210, freight invoice |
| `EdiFabric.Examples.X12.T214` | X12 4010 214, shipment status |
| `EdiFabric.Examples.X12.T404` | X12 4010 404, rail carrier shipment |
| `EdiFabric.Examples.X12.T810` | X12 4010 810, invoice |
| `EdiFabric.Examples.X12.T824` | X12 4010 824, application advice |
| `EdiFabric.Examples.X12.T832` | X12 4010 832, price catalog |
| `EdiFabric.Examples.X12.T850` | X12 4010 850, purchase order |
| `EdiFabric.Examples.X12.T855` | X12 4010 855, purchase order acknowledgment |
| `EdiFabric.Examples.X12.T856` | X12 4010 856, ship notice |
| `EdiFabric.Examples.X12.T857` | X12 4010 857, shipment and billing notice |
| `EdiFabric.Examples.X12.T861` | X12 4010 861, receiving advice |
| `EdiFabric.Examples.X12.T945` | X12 4010 945, warehouse shipping advice |
| `EdiFabric.Examples.X12.T270` | HIPAA 5010 270, eligibility request |
| `EdiFabric.Examples.X12.T271` | HIPAA 5010 271, eligibility response |
| `EdiFabric.Examples.X12.T276` | HIPAA 5010 276, claim status request |
| `EdiFabric.Examples.X12.T277` | HIPAA 5010 277, claim status response |
| `EdiFabric.Examples.X12.T278` | HIPAA 5010 278, services review |
| `EdiFabric.Examples.X12.T820` | HIPAA 5010 820, payment order |
| `EdiFabric.Examples.X12.T820HIX` | HIPAA 5010 820 HIX, payment order and remittance advice |
| `EdiFabric.Examples.X12.T834` | HIPAA 5010 834, benefit enrollment |
| `EdiFabric.Examples.X12.T835` | HIPAA 5010 835, claim payment |
| `EdiFabric.Examples.X12.T837D` | HIPAA 5010 837D, dental claim |
| `EdiFabric.Examples.X12.T837I` | HIPAA 5010 837I, institutional claim |
| `EdiFabric.Examples.X12.T837P` | HIPAA 5010 837P, professional claim |

For another version on a paid plan, add that model as C# files. See [EDI templates](#edi-templates).

## Licensing

> [!NOTE]
> Sign up free for the [Community plan](https://www.edifabric.com/pricing.html)
> to get an evaluation serial key. Community never expires, requires no credit
> card, and is for non-production evaluation, learning, and prototyping
> (250 operations per day). After signup, copy your serial from
> [Your Account](https://support.edifabric.com/hc/en-us/articles/360007159031-Your-Account-API-key)
> into `Config.TrialSerialKey`.
>
> One operation is one parse, generate, validate, or acknowledge call. The 250-a-day
> quota is shared across ediFabric .NET, Native, and Cloud. If you hit it, calls
> throw `LicenseException` with [error 639](#error-codes). Upgrade at
> [edifabric.com/pricing](https://www.edifabric.com/pricing.html) to continue.
>
> Use of the product is subject to the [EULA](https://www.edifabric.com/files/eula.pdf).

| Plan | What works | Recommended |
| --- | --- | --- |
| Community | `License.SetSerial` only. Online check. 250 operations per day. Non-production. | `License.SetSerial` |
| Developer | `License.SetSerial` and `License.EnsureToken` (`EnsureToken` caches the result for 1 day) | `License.EnsureToken` |
| Enterprise | `License.SetSerial`, `License.GetToken` / `License.SetToken` | `License.SetToken` (offline tokens) |

```csharp
// Community: authorize against the license server
License.SetSerial(serial);

// Developer (recommended): 1-day built-in cache; refreshes if the token expires within N seconds
License.EnsureToken(serial, seconds: 3600);

// Enterprise: set an offline token
License.SetToken(token);
```

The examples call `License.SetSerial(Config.TrialSerialKey)`. On Developer, call `License.EnsureToken` instead. `TokenFileCache.Set()` in `EdiFabric.Examples.X12.Common` is the manual `GetToken` / `SetToken` cache, for when you want to store the token yourself.

## Error codes

License failures throw `LicenseException`. `ErrorCode` is the number below, and `Message` is the text.

**Error 639** means the Community daily quota was exceeded. Upgrade your plan at [edifabric.com/pricing](https://www.edifabric.com/pricing.html) if you wish to continue.

| Code | Message |
| --- | --- |
| 1 | The suggested output buffer size is too small |
| 501 | Unexpected error occured. Contact support@edifabric.com for assistance |
| 611 | The input buffer is either null or its size is nill |
| 612 | The logger failed to log |
| 613 | The map configuration file is invalid |
| 614 | The output capacity must be positive |
| 615 | Models map must be set before parsing or splitting |
| 616 | Mode must be any of: 1 - Parse, 2 - Parse and Validate, 3 - Parse and Validate and Acknowledge |
| 617 | Parser failed. Contact support@edifabric.com and include a sample project/file to reproduce the issue |
| 618 | Validation failed. Contact support@edifabric.com and include a sample project/file to reproduce the issue |
| 619 | Validation serializer failed. Contact support@edifabric.com and include a sample project/file to reproduce the issue |
| 620 | The token is invalid. Contact support@edifabric.com for assistance |
| 621 | The configuration file is invalid |
| 622 | The split segment ID must not be blank |
| 623 | Call start_split before splitting |
| 624 | The result can't be retrieved. Contact support@edifabric.com and include a sample project/file to reproduce the issue |
| 625 | Result buffer size mismatched |
| 626 | Call start_merge before merging |
| 627 | The output buffer is either null or its size is nill |
| 628 | The serial number is missing or incorrect. GetToken doesn't work with developer license. Contact support@edifabric.com for assistance |
| 629 | License was not installed. Contact support@edifabric.com for assistance |
| 630 | No license to use this version. Contact support@edifabric.com for assistance |
| 631 | The token has expired. Get and set a new token to continue. Contact support@edifabric.com for assistance |
| 632 | The token is missing. Set token to continue. Contact support@edifabric.com for assistance |
| 633 | Reached the maximum number of licenses. Set token to continue. Contact support@edifabric.com for assistance |
| 634 | Environment not recognized for licensing or reached the maximum number of licenses. Contact support@edifabric.com for assistance |
| 635 | Serial or token not found. Either set token or serial to continue. Contact support@edifabric.com for assistance |
| 636 | The rate to get serials was exceeded for your license. Wait for 60 seconds and try again or upgrade your license. Contact support@edifabric.com for assistance |
| 637 | Invalid JSON. Enable logging for additional details |
| 638 | The operation is not supported by your license |
| 639 | Your license has reached its daily call limit. Upgrade your plan at edifabric.com to continue using the product. |

## EDI templates

The models published on NuGet, such as **EdiFabric.Templates.X12**, **EdiFabric.Templates.Hipaa**, **EdiFabric.Templates.Edifact**, and **EdiFabric.Templates.Padis**, are for evaluation only. They are a Community plan limitation. These examples reference **EdiFabric.Templates.X12** and **EdiFabric.Templates.Hipaa** so you can run the samples on Community.

Paid plans provide every template as plain C# files. Add them to the solution by following [How to create EDI template projects](https://support.edifabric.com/hc/en-us/articles/360016750838-How-to-create-EDI-Template-projects). For evaluation and the Community plan, you can still download the templates in compiled form by following the same article.

The same classes validate as well as parse. EdiFabric supports the X12 and HIPAA versions. If a transaction is missing, [ask for it](https://support.edifabric.com/hc/en-us/requests/new).

- [X12](https://support.edifabric.com/hc/en-us/articles/360000360572-X12-2040-to-4010)
- [HIPAA](https://support.edifabric.com/hc/en-us/articles/360000372751-HIPAA-270-271-276-277-278-820-834-835-837-999)
- [EdiNation spec library](https://edination.edifabric.com/edi-spec-library.html) (no registration)

## Warranty

The source code in these example projects is strictly for demonstrational purposes and is provided "AS IS" without warranty of any kind, whether expressed or implied, including but not limited to the implied warranties of merchantability and/or fitness for a particular purpose.

## Links

- [Install EdiFabric](https://support.edifabric.com/hc/en-us/articles/360016808578-Install-EdiFabric)
- [Tutorial](https://support.edifabric.com/hc/en-us/articles/360000291511-Tutorial-EDI-NET-Tools-Basics)
- [EDI to database](https://support.edifabric.com/hc/en-us/articles/360029265372-EDI-to-DB)
- [Knowledge base](https://support.edifabric.com)
- [Community plan (free signup)](https://www.edifabric.com/pricing.html)
- [Your Account](https://support.edifabric.com/hc/en-us/articles/360007159031-Your-Account-API-key)
- [Support](https://support.edifabric.com/hc/en-us/requests/new)
- Support: support@edifabric.com

### 2026 © EdiFabric
