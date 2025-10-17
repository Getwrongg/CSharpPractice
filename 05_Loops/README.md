# Loops in C#

## Overview
Loops let your program repeat work without copying the same lines over and over. Picture a loop as a tradie checking each item on a checklist—start at the top, tick it off, move to the next. In this section you'll learn to:

- Choose between `for`, `foreach`, `while`, and `do-while` loops depending on the data and stopping rules.
- Control the flow inside loops using `break`, `continue`, and guard clauses so the code stays readable.
- Combine loops with **Conditionals** to react differently on each pass.

These patterns become critical in **Collections** when you process lists, arrays, or dictionaries, and they underpin the data transformations you'll see in project work.

## Where Loops Show Up in Real Apps
Any time a program processes multiple inputs—rows from a CSV, user records in a database, or sensor readings from equipment—you'll use loops. Employers value developers who:

- Prevent infinite loops by designing clear exit conditions.
- Write loops that scale when data grows, which you'll explore again in **Best Practices** under performance tips.
- Know when to swap in higher-level constructs like LINQ later on for cleaner data processing.

## Syntax Walk-through
A classic counting loop:

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Ticket number {i}");
}
```

- `int i = 0` – starting point.
- `i < 5` – loop keeps running while this condition is true.
- `i++` – increments `i` after each pass.

Looping through a collection safely:

```csharp
foreach (string course in courses)
{
    Console.WriteLine(course);
}
```

- `foreach` protects you from indexing errors and reads naturally: "for each course in courses".
- Works on any type that implements `IEnumerable`, which you'll meet again in **Collections**.

When you don't know how many times the code should run, reach for `while`:

```csharp
while (!input.Equals("quit", StringComparison.OrdinalIgnoreCase))
{
    // Process the input
    input = Console.ReadLine();
}
```

Need the block to execute at least once? `do-while` has your back:

```csharp
do
{
    Console.WriteLine("Enter a number between 1 and 10:");
    response = Console.ReadLine();
}
while (!int.TryParse(response, out int number) || number < 1 || number > 10);
```

## Common Mistakes and How to Avoid Them
- **Forgetting to update the loop variable** – leads to infinite loops. Always double-check that something inside the loop nudges the condition toward false.
- **Modifying a collection while iterating** – removing items inside a `foreach` causes runtime errors. Use a `for` loop or collect changes first.
- **Looping when a method would do** – if you're repeating the same code in multiple places, refactor into a **Method** to reduce duplication.
- **Ignoring performance** – nested loops (`for` inside another `for`) can slow programs. When you hit **Collections**, you'll learn about alternative data structures to reduce heavy looping.
