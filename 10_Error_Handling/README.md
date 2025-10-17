# Error Handling in C#

## Overview
Error handling is about steering your program safely when something goes wrong—like missing files, invalid inputs, or network hiccups. Instead of crashing, your app can recover gracefully or inform the user what to do next. In this topic you'll:

- Learn how `try`, `catch`, and `finally` blocks structure your defensive code.
- Understand the difference between exceptions you expect (like validation errors) and true system failures.
- Explore when to throw custom exceptions to give clearer feedback.

This knowledge pairs closely with **File IO** (where things often fail) and **Collections** (where you might access missing keys).

## Why It Matters on the Job
Professional software must be reliable. Employers expect developers to:

- Protect users from cryptic crashes by handling predictable problems.
- Log errors so the support team can diagnose issues later.
- Choose the right balance between catching too much (hiding bugs) and too little (letting the app crash).

## Syntax Walk-through
Basic structure:

```csharp
try
{
    int number = int.Parse(userInput);
    Console.WriteLine($"You entered {number}");
}
catch (FormatException ex)
{
    Console.WriteLine("Please enter digits only.");
}
finally
{
    Console.WriteLine("Thanks for using the app.");
}
```

- `try` wraps code that might throw an exception.
- `catch (FormatException ex)` handles a specific problem—in this case, non-numeric text.
- `finally` runs whether or not an exception occurs. Perfect for clean-up work like closing files (you'll see this again in **File IO**).

Throwing your own exception:

```csharp
public void ValidateAge(int age)
{
    if (age < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(age), "Age cannot be negative.");
    }
}
```

- `throw` stops the current flow and hands control to the nearest matching `catch` block.
- `nameof(age)` keeps error messages in sync even if you rename the parameter later.

## Common Mistakes and How to Avoid Them
- **Swallowing exceptions** – an empty `catch` block hides problems. Always log or surface useful information.
- **Catching the base `Exception` too early** – doing so can mask specific issues. Catch precise exception types when possible.
- **Using exceptions for normal flow** – don't throw exceptions to signal expected outcomes (like a search returning zero results). Return values or use conditionals instead.
- **Forgetting to release resources** – use `finally` or a `using` statement to dispose of objects that hold onto files, database connections, or network sockets.
