# C# Intro
C# is an object-oriented programming language which is similar to Java the most in terms of syntax and logic.
## CMD commands
- Create new c# project: `dotnet new console` 
- Run `C#` projects: `dotnet run`
## multidimensional array
Create new 2d-array: `String[,] arrName`
## C# static
Modifier to declare a `static` member, which belongs to the class itself rather than to any specific object (e.g. cannot create new `Math` object. But you can only use function inside its.)
# OOP characteristic
## Inheritance
1 or more child classes receiving fields. methods, etc. from a common parent.
## Abstraction
Modifier that indicates missing components or incomplete implementation. There are 2 types:
- `Abstract class`: cannot be declared. Can only be used as `super-class` inherited by other `sub-class`
- `Abstract method`: Has no body. All sub-classes must re-define when inherit from a class with abstract methods.