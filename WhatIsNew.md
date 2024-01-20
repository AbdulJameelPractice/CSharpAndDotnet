
 - [What is New in .NET 6 and C# 10 ](#what-is-new-in-net-6-and-c-10)
 - [What is New in .NET 7 and C# 11](#what-is-new-in-net-7-and-c-11)
 - [what-is-new-in-net-8-and-c-12](#what-is-new-in-net-8-and-c-12)
## What is New in .NET 6 and C# 10
- Unification of .net platforms,
- single BCL and single SDK
- there is no core word with .NET 6
- 64 bit of visual studio 2022 support
- Hot Reload support while debugging for xaml and C#
- C# 10 = new version
- new templates addition for visual studio 
- ASP.NET Core 6
- Angular template support bootstrap 5
- most ASP.NET Core 6 changes are for Blazor
- Start of Minimal API Support
- .NET MAUI support - next evolution of Xamarin.Forms
- EF Core 6, C++
- Released in Nov 2021
- Promoting MAUI and Blazor for web and other clients
- started with .NET 5 in 2020 completed in 2021 with .NET 6
- .NET 6 is a LTS supported until Nov 2024
- update asap
- current release: supported only 6 moths after release of next version.
- LTS - long term support: supported for 3 years after release of next version.
- good strategy to just move from a LTS to LTS, e.g .NET 6 to .NET 8
### Unification of .NET 
-  legacy: .NET Framework 4.8, Xamarin (mono, ios/Android), .NET Core (cross platform)
- .NET Standard helped to shared the code
- Mono: Original open source of .NET built from .NET framework 2.0
- a single platform after unification **.NET 6**
- single .NET for building all types of apps, desktop, cloud, mobile, IOT etc
- Single SDK and BCL
- Program.cs and Startup.cs is combined into a single class Program.cs
- ConfigureService and ConfigureMethod is not available.
- support for Bootstrap 5.1

### What is new in Visual Studio 2022
- support for Hot Reload
  - Avoid App Restarts
  - Support for C# Code and XAML
  - support for CLI tools
  - can be enabled on save
  - works in debug configuration
  - some code changes are not supported
  - if it not works just restart
  - support for project types ASP.NET Core, Blazor, Console, WinForms, WPF, UWP, WinUI3, .NET MAUI, Azure Functions
  - C# and VB are supported.
- New Project templates
- new icons and tab color
- 64 bit version support

### ASP.NET Core Platform 6.0
 - new hosting model with a single program classes.
 - you can still keep using current program and startup class though
 - top level statement in program.cs to get rid of lot of boilerplate.
 - support for bootstrap 5.1.
 - New Features
   - CSS Isolation for Core MVC and Razor Pages
   - Async Streaming
   - Bootstrap 5.1 support
   - Hot Reload support for Blazor
   - Web Assembly AOT
   - Hybrid Apps with Blazor and MAUI
     - hybrid apps, Native and Web UI
     - hosting blazor application inside .NET MAUI App
     - cross platform native app
     - runs inside embedded native web UI
     - web assembly not required
     - More Capabilities on the device
     - you can take existing blazor app and put it in .net MAUI and ship for cross platform devices.
   - Error Boundaries
   - Dynamic components
   
 - ASP.NET Core MVC => ASP.NET MVC in legacy .net framework
   - Server side application
   - Generated html is generated at server and sent to client
   - ASP.NET Core 6 MVC is fully compatible with previous version
   - no issues in updating your `asp.net core mvc` apps to .NET 6.0
   - often used for larger enterprise applications.
 - ASP.NET Core Razor Pages
   - Simpler approach to build apps
   - fully compatible with previous .net core version
   - new template
 - ASP.NET Core Blazor(client side, server side)
   - Client side using C#
   - lot of enhancements with every version of .NET
   - many new features no breaking features
 - ASP.NET Core APIs
   - create API
   - no major issues in upgrade
   - support for Minimal API
 - ASP.NET Core Minimal Api's
   - started support from .NET 6
   - just a few lines of code.

### New Features in .NET 6 and C# 10.
- C# 10 new feature
  - global `using statement`
  - file-scoped namespaces
  - extended property types
  - structure type changes
  - const interpolated strings.
  - changes to record
  - assignment and declaration in same deconstruction.

global using
```csharp
global using System;
global using System.Collections.Generic;
global using System.Linq
```
file scoped namespace
```csharp
namespace SampleNamespace;
public class Example
{
}
```
const string interpolation
```csharp
const string folderPath="/docs";
const string logFilePath = $"{folderPath}/log.txt";
```
implicit using common namespaces
```csharp
  <ImplicitUsings>enable</ImplicitUsings>
 
// included namespaces by default 
// 01_CSharpFundamentals\BethanysPieShopHRM\obj\Debug\net8.0
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
```
DateOnly and TimeOnly
```csharp
  public DateOnly date = new DateOnly(10,2,3);
  public TimeOnly time = new TimeOnly(12, 12, 12);

    public void PrintData()
    {
        Console.WriteLine(date.ToLongDateString());
        Console.WriteLine(time.ToLongTimeString());
        
        
        Console.WriteLine(Environment.ProcessId);
        Console.WriteLine(Environment.ProcessPath);
    }
```

![Alt TExt](docs/NewInDotNet6_1.png)
![Alt TExt](docs/NewInDotNet6_2.png)
![Alt TExt](docs/NewInDotNet6_3.png)
![Alt TExt](docs/NewInDotNet6_4.png)
![Alt TExt](docs/NewInDotNet6_5.png)
![Alt TExt](docs/NewInDotNet6_6.png)
![Alt TExt](docs/NewInDotNet6_7.png)


## What is new in .NET 7 and C# 11
 - Released at the end of 2022.
 - STS Release
 - Single BCL and SDK - only .NET 
 - Cross platform native UI  - .NET MAUI
 - Cross platform Web UI  - Blazor
 - Performance improvements in .NET 7
 - ARM64 improvements
 - Native AOT
 - On Stack Replacement (OSR)
 - C# 11 support - new version of the language
 - .NET APIs improvements
   - microseconds and nano seconds added to DateTime
   - Microsoft.Extensions.Caching improvements
   - System.Formats.Tar
   - System.Text.Json Changes
 - ASP.NET Core Improvements - most changed
   - Core Framework changes, rate limiting, output caching
   - Minor changes to ASP.NET Core MVC/Razor Pages
   - Minimal APIS additions
   - Blazor - bigger changes
 - .NET MAUI Changes
   - Performance
   - Desktop Targeting improvements, tooltip, content menu, right controls
   - New Controls, map etc
   - Blazor Hybrid
 - Tooling Improvements
   - Azure Support, you can upgrade azure functions, azure apps to this version
   - Container Support
   - Improvements in hot reload
   - CLI Improvements
 - Upgrade Assistant to upgrade to latest .NET Versions
 - can help with migration from .NET Framework to Latest .NET
 - STS - 6 months after .NET 8 release
 - .NET 7 is production ready
 - Upgrade Existing .NET Project

![Alt TExt](docs/NewInDotNet7_1.png)
![Alt TExt](docs/NewInDotNet7_2.png)
![Alt TExt](docs/NewInDotNet7_3.png)
![Alt TExt](docs/NewInDotNet7_4.png)
![Alt TExt](docs/NewInDotNet7_5.png)

## What is new in .NET 8 and C# 12