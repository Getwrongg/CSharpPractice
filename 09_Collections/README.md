# Collections in C#

## Overview
Collections are containers that hold multiple values so you can manage them as a group. Imagine a toolbox with labelled compartments—lists, dictionaries, queues—each suited to a different job. In this topic you'll:

- Understand the standard collection types in `System.Collections.Generic`.
- Choose the right structure based on how you add, search, and remove items.
- Iterate through collections safely, tying back to skills from **Loops** and **Conditionals**.

This knowledge unlocks real-world scenarios like managing student records, storing settings, or buffering sensor readings.

## Why Collections Matter in the Workplace
Every business application handles sets of data. Employers expect you to:

- Pick efficient data structures so the software remains responsive.
- Use strongly typed collections (`List<T>`, `Dictionary<TKey, TValue>`) to catch mistakes at compile time.
- Combine collections with **Error Handling** to protect against missing keys or empty lists.

## Syntax Walk-through
### Lists

```csharp
List<string> campuses = new List<string>();
campuses.Add("Sydney");
campuses.Add("Melbourne");

foreach (string campus in campuses)
{
    Console.WriteLine(campus);
}
```

- `List<string>` stores items in order and allows duplicates.
- `.Add`, `.Remove`, `.Contains`, and `.Count` are common members.

### Dictionaries

```csharp
Dictionary<string, string> courseCodes = new Dictionary<string, string>
{
    { "CERT4", "Certificate IV in IT" },
    { "DIPIT", "Diploma of IT" }
};

if (courseCodes.TryGetValue("CERT4", out string courseName))
{
    Console.WriteLine(courseName);
}
```

- Key-value pairs are perfect when you need fast lookups.
- `TryGetValue` avoids exceptions if the key is missing—a technique that links to **Error Handling**.

### Queues and Stacks

```csharp
Queue<string> helpDesk = new Queue<string>();
helpDesk.Enqueue("Printer jam");
helpDesk.Enqueue("Password reset");

string nextTicket = helpDesk.Dequeue(); // FIFO: first in, first out
```

```csharp
Stack<string> undoHistory = new Stack<string>();
undoHistory.Push("Typed line 1");
undoHistory.Push("Typed line 2");

string lastAction = undoHistory.Pop(); // LIFO: last in, first out
```

- Queues suit scheduling tasks; stacks suit undo/redo features.

## Common Mistakes and How to Avoid Them
- **Using the wrong collection** – for unique items, consider `HashSet<T>`; for sorted results, try `SortedList` or `SortedDictionary`.
- **Forgetting null checks** – always check that a collection has been initialised before using it. `List<string> names = null;` followed by `names.Add(...)` will throw a `NullReferenceException`.
- **Modifying during iteration** – just like in **Loops**, changing a collection while looping with `foreach` can cause runtime errors. Use a `for` loop or collect changes first.
- **Not clearing collections** – leftover data can cause memory bloat or incorrect results. Use `.Clear()` when reusing a collection.
