# C# 10

- [C# 10](#c-10)
  - [C# The Big Picture](#c-the-big-picture)
    - [The Evolution of C#](#the-evolution-of-c)
  - [C#10 Fundamentals](#c10-fundamentals)
    - [C# Language](#c-language)
    - [building block of any language including C#](#building-block-of-any-language-including-c)


C# is the most popular language to build .NET applications today. It’s part of the .NET ecosystem, which offers developers all the tools, languages and frameworks to create all types of applications including web, cloud, desktop and mobile.

 C# 10, the latest version part of the .NET 6 release. C# 12 is supported along with .NET 8.0, release.

 what is new is C#10, 11 and 12?

 ## C# The Big Picture
 One of the top programming language in the world.

 - Fallows C like approach for developing program
 - Strongly typed language, statically typed at compile type - compile type inference
 - implicit type is var
 - type safety and safe - types are inference at compile type instead of run time
 - Resilient and safe with native performance 
 - C# is object oriented language
 - `int` is C# language keyword or construct being mapped to System.Int32 in .NET base class library
 - C# is object oriented with functional feature (extended with extension methods) e.g. aggregate extension method for list of arrays
 - since 2014, C# is available as open source with cross-platform using .NET 6
 - General purpose language to develop web, mobile, desktop, IOT, cloud etc applications
 - Managed Execution in C#
 - C++ is compiled language, compiled native and needs manual management, fastest performance profile, needs multiple version needs to be generated for each platform(lack of portability), 
 - Interpreted or dynamic REPL - loose or dynamic typing, slow performance profile, permissive runtime type conversion. e.g python
 - C# is interpreted language with **Managed Execution** , strong typing, runtime type safety, garbage collection and native code performance.
 - `managed execution engine` is of hybrid type
 - edit time (C#) => compile-time intermediate language => (binary encoded .dll| .exe)=> JIT (IL to cpu understand code) => runs on CPU 
 - JIT compiled when required and cached for subsequent calls. if the method is not called then JIT compiler resources are not used to compile that code
 - JIT compiler also ensure type safety during the run time
 - Execution Engine : Common Language Runtime (CLR) - JIT Compilation, Run time safety and Garbage Collection
 - .NET6 and beyond (cross platform) and legacy  platform for windows .NET 4.8
 - All new C# Projects should target the cross platform version of .NET
 - Base Class Library - suite of library part of .net installation
 - By Learning C#, you learn the broader .NET platform
 - By Learning .NET, you can choose the best language for the task at hand.
 - C# code is compiled into IL assemblies
 - IL is JIT-compiled at runtime if/when used.
 - JITed code exhibits native performance
 - CLR ensures runtime type safety
 - BCL includes general purpose libraries and app framework functionality
 - course reference .NET class libraries: The Big Picture - Matthew Soucoup
 - Introduction to the C# Type Systems - gill Cleeren

![Alt text](docs/2023-11-27_18h02_23.png)

![Alt text](docs/2023-11-27_18h08_43.png)

![Alt text](docs/2023-11-27_18h14_43.png)

![Alt text](docs/2023-11-27_18h16_33.png)

### The Evolution of C#
- `The only constant is change`
- Incremental not abrupt
- opt-in not mandatory
- Non breaking, not disruptive
- Codification of common patterns and best practices that emerge in the community
- Simpler and/or faster and/or safer code
- C# 9 support top level statement with one line of code
- C#6 added string interporlatin $"args[{m}]"
- Canonical Properties => Public int X {get;set;} - auto properties added in C#3
- C#9 introduces init properties, that has the values initially set by the caller
- C#6 expression bodied member `public override string ToString()=> $"{x} - {y}"`
- Switch Expression 
  
![Alt text](<docs/switch expression.png>)

![Alt text](docs/2024-01-03_19h46_10.png)

## C#10 Fundamentals
 - The .NET Ecosystem support developing application for desktop, web, mobile, cloud, IOT, Games and AI
 - Ecosystem also support several language(C#, F# and VB.NET) and libraries to build apps, Tools to support to build apps
 - .NET 6 - cross platform runs everywhere windows, mac and linux
### C# Language
     popular, well maintained, commonly used for building .NET application
     Object oriented programming language
     Type safe language
     Familiar for C, C++, Java and JS Developers
     Actively maintained and backward compatible
     can be used to build all types of .NET applications
     build console, desktop, web application, mobile apps, services
     you can use .NET CLI and VS code to build apps for all platforms
- [C# documentation](https://docs.microsoft.com/en-us/dotnet/csharp)
- [.NET API browser](https://learn.microsoft.com/en-us/dotnet/api/)

![Alt text](<docs/Csharp_actively maintianed.png>)

### building block of any language including C#
- `Statements`: actions maintain the program Console.WriteLine(""), flow of program executed in an vertical order, ends with semicolon
- `Identifiers`: naming a thing, variable, read value from console, name classes, namespaces etc, 2_input is invalid identifiers
- `Comments`: - additional info about our code, single line // , multiline /* */
- `Keywords`: int, in, ref, while - reserved words with special meaning and cannot be changed, more than 70 keywords
- `Variable`: storage locator and holds a value, use a memory of computer, unique name, and can access using name, and it has type, int, string, date etc
 ```cs 
  int age; // variable declaration
  int Age;
  int ageOfEmployees;

  age=25; // assigned variable using = assignment variable
  Console.Write(age); // use of variable
  ```
- C# is a strongly typed language, every variable has a type. Used to store information, Expressions will return a value of a specified type.
- Data Type - type of data variable can store
- Size and location in memory
- depends on the type of data, some of them are stored on `heap` and some of them are stored on `stack`
- Data range = min and max values
- supported operations e.g. add two integers, not add two boolean
- Predefined types and User-defined types
- `Predefined types`
  - bool
  - int - 32, 4 bytes to store data
  - string
  - float
  - decimal - height precision
  - double
  - char - single characters
  - byte(sbyte) - 8 bit integer 0 to 255
  - short(ushort) - 16bit integer
  - object
- once the type of variable is declared it cannot change its type during its life time.
- `constant variables`: value cannot be changed
 ```cs
 const decimal interestRate = 0.07;
 ```
 - `string`: series or list of characters, contains text, stored as a list of char object, string type
 - `Operator`: a symbol used to perform operations on operands. operands can be variables and values.
   - Arithmetic: +, -. *, /, %, ++, --
   - Comparison: ==, !=, <, >, <=, >=
   - Logical: &&, ||, !
   - Assignment: =, +=, -= etc
-

![Alt text](docs/2024-01-13_17h22_09.png)
![Alt text](docs/2024-01-13_16h49_41.png)
![Alt text](docs/2024-01-13_17h38_19.png)
![Alt text](docs/2024-01-13_17h39_31.png)