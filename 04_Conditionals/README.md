# Conditionals in C#

## Overview
Conditionals let your program make decisions instead of charging ahead blindly. Think of them as the road signs that tell your code which street to take based on what it sees. In this topic you'll:

- Understand the language features that let you ask questions like "Is this number big enough?" or "Did the user type yes?".
- Compare different decision tools—`if`, `else if`, `else`, `switch`, and pattern matching—and know when each one shines.
- Read and write clear conditional blocks that align with how professional C# developers structure their logic.

You'll rely on these ideas constantly, especially when combining them with **Loops** to control repeated actions, or with **Error Handling** to choose the right recovery path.

## Why Conditionals Matter on the Job
Every real-world C# app reacts to different scenarios: a login form checking credentials, a machine control system responding to sensor readings, or a console app branching based on menu choices. Employers expect you to:

- Analyse the data your program receives and select the right response.
- Keep logic clear so teammates can follow the "story" of the code.
- Avoid duplicated checks by structuring conditions neatly and reusing helper methods (a technique you'll strengthen in **Methods**).

Understanding conditionals early also makes later concepts like **Polymorphism** easier. You'll start spotting when a conditional can be replaced by a virtual method override—a professional refactor that reduces branching clutter.

## Syntax Walk-through
```csharp
if (condition)
{
    // Runs when the condition is true
}
else if (anotherCondition)
{
    // Runs when the first condition is false but this one is true
}
else
{
    // Runs when none of the above conditions are true
}
```

Key pieces:

- `condition` is any expression that evaluates to `true` or `false`. Use comparison operators (`==`, `!=`, `>`, `<`, `>=`, `<=`) or combine checks with logical operators (`&&`, `||`, `!`).
- `else if` blocks are optional and can be chained. They help you avoid deeply nested `if` statements.
- The final `else` is also optional but handy for "everything else" cases—like default error messages.

For multi-choice decisions, a `switch` statement keeps things tidy:

```csharp
switch (menuOption)
{
    case "1":
        // Handle first option
        break;
    case "2":
        // Handle second option
        break;
    default:
        // Handle unexpected inputs
        break;
}
```

From C# 8 onwards, you can lean on pattern matching for more expressive decisions:

```csharp
string message = input switch
{
    null => "No input provided.",
    "" => "Input was empty.",
    var text when text.Length > 10 => "That's a long answer!",
    _ => "Thanks for the quick reply."
};
```

`_` is the discard pattern—like a catch-all bucket. You'll see patterns again when we cover **Inheritance and Polymorphism** because they let you match on types.

## Common Mistakes and How to Dodge Them
- **Over-complicated conditions** – stacking too many checks in one line makes logic impossible to read. Extract parts into well-named variables or helper methods (see **Methods**).
- **Forgetting braces** – even when a block has one line, keep the braces `{ }` to avoid accidental bugs when adding more code later.
- **Using `=` instead of `==`** – a classic typo that assigns rather than compares. The compiler will usually complain, but watch for this especially when comparing booleans.
- **Ignoring default cases** – `switch` statements without a `default` leave users hanging when they enter unexpected values.
