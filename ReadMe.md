# C# 10

- [C# 10](#c-10)
  - [C# The Big Picture](#c-the-big-picture)
    - [The Evolution of C#](#the-evolution-of-c)
  - [C#10 Fundamentals](#c10-fundamentals)
    - [C# Language](#c-language)
    - [Building Blocks of C#](#building-blocks-of-c)
    - [Decision and Iterations Statements in C#](#decision-and-iterations-statements-in-c)
    - [Methods in C#](#methods-in-c)
    - [Working with Strings in C#](#working-with-strings-in-c)
    - [Classes and Objects in C#](#classes-and-objects-in-c)
    - [Value Types and Reference Types](#value-types-and-reference-types)
    - [OOPS in C#](#oops-in-c)
  - [What is New in .NET 6/7/8](#what-is-new-in-net-678)
  - [Async Programming](#async-programming)


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

### Building Blocks of C#
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
 - DateTime and TimeSpan
 - [Api Browser for DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime.maxvalue?view=net-8.0)
 - implicit variable - a variable declared using `var` keyword. type is inferred (type is assigned based on right hand side value type)
  
![Alt text](docs/2024-01-13_18h06_11.png)
![Alt text](docs/2024-01-13_17h22_09.png)
![Alt text](docs/2024-01-13_16h49_41.png)
![Alt text](docs/2024-01-13_17h38_19.png)
![Alt text](docs/2024-01-13_17h39_31.png)
![Alt text](docs/2024-01-13_17h45_01.png)
![Alt text](docs/2024-01-13_17h44_32.png)
![Alt text](docs/2024-01-13_17h56_27.png)
![Alt text](docs/2024-01-13_18h06_36.png)
![Alt text](docs/2024-01-13_18h07_28.png)


### Decision and Iterations Statements in C#
 - logical operator && and ||
 - && return true if both are true
 - || return true if any expression is true
 - flow of execution can be altered with conditions
 - `if`
 - `switch`
 - `while`
 - `do while` : executed at-least once
 - `for`

![Alt text](docs/2024-01-13_19h51_10.png)
![Alt text](docs/2024-01-13_19h53_39.png)
![Alt text](docs/2024-01-13_19h55_28.png)
![Alt text](docs/2024-01-13_19h58_49.png)
![Alt text](docs/2024-01-13_19h59_52.png)
![Alt text](docs/2024-01-13_20h00_43.png)


### Methods in C#
 - spilt the code in smaller blocks
 - impose code `reusability`
 - they are code blocks contains statements
 - contain name, can be invoked with that name
 - Receives parameters and optionally returns value
 - improve readability of the code
 - Declared with a class or struct
 - all execution path should return a value if method has defined a return type
 - A Method can return nothing with `void` type
 - we can pass arguments, values for the parameters
 - you can capture return value in a variable if the method is returning a value
 - a method with same name with different parameters is called as `method overloading`
 - different parameter of different parameter types.
 - local scope: with in the local method, local variable
 - optional parameters: has a default value for parameters one or more, caller can omit the optional parameters. should be at the end of the parameters list.
 - Named arguments: caller can have name of the parameters. One or more parameters can have a name defined when invoking the method.
 - order can be changed but you need to pass all required parameters (non optional parameters)
 - Expression Bodied syntax for method. => 
 - `Main Method:` Entry method which gets called upn start of the app
 - Gets created implicitly since C#10 and VS 2022

![Alt text](docs/2024-01-13_20h26_22.png)
![Alt text](docs/2024-01-13_20h06_26.png)
![Alt text](docs/2024-01-13_20h31_27.png)
![Alt text](docs/2024-01-13_20h33_18.png)

### Working with Strings in C#
- ToLower() 
- String.Format("")
- try parse for parsing
- methods to support various operations on string.
- strings are immutable
- any operation can return a new value in the heap
- can have performance impact 
- loop actions or many concatenate actions can cause high memory use!
- use StringBuilder, when performing more operations on string

![Alt text](docs/2024-01-13_20h55_29.png)
![Alt text](docs/2024-01-13_20h52_55.png)
![Alt text](docs/2024-01-13_21h00_56.png)
![Alt text](docs/2024-01-13_21h03_18.png)

### Classes and Objects in C#
- represent custom type, typical model
- `class`: most commonly used 
  - are reference types and commonly used
  - main building block in C#
  - Blueprint of an object
  - Contain properties data and functionality to work on its data
  - created using `class` keyword
  - foundation of object orientation
  - most code will live inside a class
  - Fields, Methods, Properties(wrapper for fields), Events
- Struct: specific properties and similar to class
- Access Modifies: public, private, protected(class and inherited classes)
- Objects: instance of the class, holds a value for the fields in the class
- Constructors: called when instantiating an object happens, Default or custom
  - used to pass initial values 
  - same name as class name
  - *only access modifiers and no return type*

![Alt text](docs/Co.png)
![Alt text](docs/2024-01-13_21h19_35.png)
![Alt text](docs/ClassConstructor.png)
![Alt text](docs/2024-01-13_21h23_59.png)
![Alt text](docs/2024-01-13_21h24_34.png)

### Value Types and Reference Types
- `Value Types`: types that holds direct value and usually stored on `stack`. 
  - int, float, double, char
  - fixed size
  - allocated by compiler on stack
  - value is copied to this memory location.
- `Reference Types`: allocated on `heap`
  - heap: mess memory of the machine
  - stack contain just a pointer to the memory address
  - classes are reference types
- Passing Parameters
  - By Value: Default if nothing else is specified, 
    - A Copy is created for the method
    - method can do anything with that parameters
    - doesn't impact the caller of the method
  - By Reference: require use of `ref` keyword on parameters 
    - pass a reference is passed to the method
    - no copy is made
    - changes made in method affect original values
    - **ref** keyword is used
    - must be initialized before using the ref parameters
    - strings are reference type 
  - out keyword
    - don't need to be initialized
    - Multiple values can be returned, can be done with ref as well but ref must be initialized

![Alt text](docs/VTRT_1.png)
![Alt text](docs/VTRT_2.png)
![Alt text](docs/VTRT_3.png)
![Alt text](docs/VTRT_4.png)
![Alt text](docs/VTRT_5.png)
![Alt text](docs/VTRT_6.png)
![Alt text](docs/VTRT_7.png)
![Alt text](docs/VTRT_8.png)

- Group classes using `namespaces`.
- `namespace` along with class name is used to access the class
- **static** value is shared across all instances of the class. initialize at one place the value is affected for all objects.
- **static** methods can be called without instantiating the class.
- **static** methods can only access static members of the class.
- when a reference type is **null**, it means it is not pointing to any object in the heap. but it is pointing to a memory location in the stack to store variable value
- the fallowing code compiles but throws an exception at run time
```cs
Employee emp = null;
emp.GetFullName();
```
- `Null Conditional Operator` ?. - checks for null before accessing the member
- `Null Coalescing Operator` ?? - returns a default value if the value is null
- you can assign the emp to null once usage it done in dispose.
- value type can also be null. use nullable type e.g. ``` int? age = null; ```
- nullable value type can set to null if the value is not explicitly set.
- `Nullable` type is a struct with two properties
  - HasValue: true if the value is set
  - Value: returns the value if set, otherwise throws an exception 
- Garbage Collection - CLR manages the memory for the application.
- CLR manages the memory for the application. removes the objects that are not used anymore. they are also known as zombie objects.


![Alt text](docs/Namespace_1.png)
![Alt text](docs/Namespace_2.png)
![Alt text](docs/staticmethod.png)

### OOPS in C#
- business model is updated to classes and object
- re-usability, easy to read code and maintenance for longer run
- Focus on classes and objects
- Classes, Objects, methods, properties
- The Four pillars of OO
  - Encapsulation
    - information is contained inside the object
    - only certain information is exposed
    - Hides internal implementation and data
    - only required data is exposed
    - dont exposed car engine is working, but headlight is exposed
    - Avoid data corruption
    - public and private
    - access modifiers should come to your mind when thinking bout encapsulation
    - if you use private set inside a property only that class can set the property field.
    - you can still get the value but cannot set the value.
    - constructor should update the property instead of file so that any validation logic can execute.
    - you can use protected set if you want value to be set in derived type.
```csharp
public class Employee
{
    public string firstNamee;
    public int age;
    public Employee(string name, int ageValue)
        {
            //.....
        }
}

Employee emp = new Employee("test",20);
// there is no validation while setting.
emp.firstNamee="renamed";
// firstNamee is exposed

// fixed with abstraction
public class Employee
{
    private string firstNamee;
    private int age;
    public Employee(string name, int ageValue)
        {
            //.....
        }
    public string FirstName 
    {
        get
        {
            return firstNamee;
        }
        set
        {
            // you can include logic to validate if firstNamee is set correct value.
            firstNamee=value;
        }
    }
}

```
  - Abstraction
    - Abstract Representation of the program
    - exposes simple interface to the caller.
    - Gas pedal is an abstraction, how much gas or petrol is the local complexity of the system, need not be exposed
    - only mechanism useful for other objects are revealed
    - implementation is hidden
    - makes changes becomes easier
    - complexity of the object is not expose
  - Inheritance
    - classes can reuse functionality from others
    - Relation between classes
    - lower development time because of re-usability
    - derived class can access public and protected type of the base class.
    - protected are access in inheriting type but not outside of the class
    - inheritance bring a is-A relationship, Manager is a employee
    - composition: Has a relation employee has address, address object is part of the employee object
  - Polymorphism
    - Share behaviors but can be in more than one form
    - Child can be used like its parent
    - Correct method will be used based on the execution.
    - override: hides the base class type, you can add a modified version to your own subtype
    - a base class method with a new implementation.
    - uses virtual and override keywords
    - adds the ability to create an object of subobject and assign it to parent object.
    - 

![Alt Text](/docs/OOPS_1.png)
![Alt Text](/docs/OOPS_2.png)
![Alt Text](/docs/OOPS_3.png)
![Alt Text](/docs/OOPS_4.png)
![Alt Text](/docs/OOPS_5.png)

## What is New in .NET 6/7/8 
[What is New in .NET 6/7/8](WhatIsNew.md)

## Async Programming
[Async Programming in C#](03_AsyncProgramming/AsynProgramming.md)

## data access
[Data Access in C#](04_DataAccessInCSharp/DataAccess_CSharp.md)