# Variables and Types

## Overview
In this topic you learn how C# stores information. Variables are like labelled boxes, and the type system tells you what can go inside each box. Understanding this concept keeps your programs reliable and reduces surprises.

You'll cover:
- Declaring variables with clear names and appropriate types.
- Differentiating between value types (like `int`) and reference types (like `string`).
- Using type inference (`var`) responsibly.

These skills connect directly to **Conditionals**, **Loops**, and **Methods**, where you'll manipulate data and make decisions based on variable values.

## Context in Real Work
Programs are built on data. Whether you're counting ticket sales or storing student names, you need a reliable way to hold information. C# enforces types so that you can't accidentally mix apples with oranges.

Employers rely on type safety because it prevents runtime errors. When we get to **Error Handling** you'll see how strong typing reduces the number of issues you need to catch. Likewise, when designing **Methods**, you'll use parameter and return types to describe the flow of data.

## Syntax Cheatsheet
### Declaring Variables
```
Type variableName = initialValue;
```
- `Type` – `int`, `double`, `string`, etc. Choose based on the data you need to store.
- `variableName` – use camelCase for local variables, e.g., `studentCount`.
- `initialValue` – optional, but helps prevent unassigned variable errors.

### Type Inference
```
var itemCount = 5;
```
- `var` lets the compiler figure out the type from the right-hand side.
- Still strongly typed: `itemCount` is treated as `int` after this line.
- Use when the type is obvious; avoid when it hides meaning.

### Constants
```
const double GstRate = 0.10;
```
- `const` makes the value fixed at compile time.
- Name constants with PascalCase.
- Handy when values are reused across **Methods** and **Classes**.

### Reference vs Value Type Hint
```
string studentName = "Casey";   // reference type
int seatNumber = 12;            // value type
```
- Reference types point to objects on the heap; value types store data directly.
- We'll revisit these differences when we cover **Classes and Objects** and **Collections**.

## Common Mistakes to Watch For
- **Using the wrong type** – storing decimal currency values in `float` can cause rounding errors. Prefer `decimal` for money.
- **Shadowing variables** – declaring a variable with the same name inside a smaller scope can hide the original value. Watch out when we start using **Loops**.
- **Overusing `var`** – when the type isn't clear, `var` makes the code cryptic for others reading it later.
- **Forgetting to initialise** – unassigned variables cause compile-time errors. Give them sensible defaults.
