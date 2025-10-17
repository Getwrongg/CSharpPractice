# Methods in C#

## Overview
Methods are the reusable actions of your program—little task cards you can hand around and execute whenever needed. In this topic you'll:

- Break down the structure of a method signature so you know what each keyword is doing.
- Understand the difference between parameters (inputs) and return values (outputs).
- Learn when to create static methods versus instance methods, setting you up for success in **Classes and Objects**.

Mastering methods keeps your code DRY (Don't Repeat Yourself) and makes later modules like **Error Handling** and **File IO** far easier because you'll extract complex work into well-named helpers.

## Why Methods Matter at Work
Teams rely on methods to divide responsibilities. A tidy method:

- Makes the codebase easier to navigate because you can search for the method name.
- Supports unit testing (which you'll explore when you start building real projects).
- Encourages collaboration—different team members can own different methods without stepping on each other's toes.

You'll also revisit methods when learning about **Inheritance and Polymorphism**, where overriding virtual methods allows child classes to customise behaviour.

## Syntax Walk-through
Here's the basic layout:

```csharp
public static int Add(int firstNumber, int secondNumber)
{
    int total = firstNumber + secondNumber;
    return total;
}
```

- `public` – access modifier. It decides who can call the method. Other options include `private`, `protected`, and `internal`, which you'll experiment with in **Classes and Objects**.
- `static` – method belongs to the class itself rather than an individual object. Drop this keyword when you need instance-specific behaviour.
- `int` (before the method name) – return type. Swap this for `void` when nothing is returned.
- `Add` – method name. Use verbs that explain the action, following **Best Practices** naming conventions.
- `(int firstNumber, int secondNumber)` – parameter list. Each parameter needs a type and a name.
- `return total;` – hands back the result. Every execution path in a non-`void` method must return a value.

You can also provide optional parameters and default values:

```csharp
public void LogMessage(string message, bool includeTimestamp = true)
{
    if (includeTimestamp)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
    else
    {
        Console.WriteLine(message);
    }
}
```

Notice how conditionals and methods play together—the method decides how to output the message based on the caller's preference.

## Common Mistakes and How to Fix Them
- **Too many responsibilities** – if a method handles more than one job, split it up. Aim for clear names like `CalculateScore` and `DisplayScore` rather than one mega-method.
- **Forgetting to return** – the compiler will warn you, but logic bugs can appear if your return statements sit inside conditionals. Ensure every path returns the intended value.
- **Using global variables instead of parameters** – passing data in through parameters keeps methods predictable and easier to test.
- **Ignoring access modifiers** – leaving everything `public` opens the door to accidental misuse. Revisit the method later in **Classes and Objects** to tighten visibility where appropriate.
