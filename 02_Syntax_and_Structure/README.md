# Understanding C# Syntax and Structure

## Overview
This section digs into how a C# file is organised: namespaces, classes, methods, and statements. Picture it like a neatly labelled toolbox where every compartment has a purpose. You'll learn how keywords and punctuation guide the compiler to understand your intent.

You'll focus on:
- Breaking down a C# file into namespaces, classes, methods, and statements.
- Reading modifiers like `public`, `private`, and `static` in plain English.
- Seeing how braces `{}` and semicolons `;` define the flow of your program.

This groundwork supports upcoming topics such as **Variables and Types**, **Methods**, and **Classes and Objects**, because you'll know exactly where those pieces sit in the program layout.

## Context in Real Work
C# is a strongly typed, compiled language. The compiler needs strict instructions to transform your text into executable programs. Syntax rules act like road signs: follow them and the compiler knows exactly what to do; ignore them and everything stops.

Understanding the structure lets you read other people's code. When you join a team or look at open-source projects, you rely on these consistent patterns. Later, when you design **Methods** or manage **Error Handling**, the syntax rules you learn here will help you place code in the right spot and communicate intent clearly.

## Syntax Breakdown
### Namespaces
```
namespace ProjectArea
{
    // types live here
}
```
- `namespace` groups related classes and helps avoid naming clashes. Essential when we study **Classes and Objects**.

### Classes and Access Modifiers
```
public class Sample
{
}
```
- `public` means other code can access this class.
- `class` defines a blueprint for objects.
- The braces `{ }` contain members such as methods or fields.

### Methods and Signatures
```
private static int Calculate()
{
    // statements
}
```
- `private` – only usable inside the current class.
- `static` – belongs to the class rather than an instance.
- `int` – return type. Links forward to **Variables and Types**.
- `Calculate` – method name using PascalCase convention.
- `()` – parentheses hold parameters. Empty means no input yet.

### Statements and Semicolons
```
DoSomething();
```
- Each instruction ends with `;` to show the compiler the statement is complete.
- Forgetting a semicolon triggers compile errors you'll practise spotting here.

## Common Mistakes to Watch For
- **Mismatched braces** – leaving out a closing `}` shifts code blocks and confuses the compiler. Counting indentation helps.
- **Wrong access modifier** – marking everything `public` can expose implementation details. Think about who should see each member.
- **CamelCase vs PascalCase** – method names should be PascalCase in C#. Using inconsistent naming makes code harder to read for teammates.
- **Missing `using` directives** – if you forget to include required namespaces, later topics like **Collections** won't compile.
