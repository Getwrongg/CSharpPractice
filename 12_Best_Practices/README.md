# C# Best Practices for Beginners

## Overview
Best practices are the habits that keep your code clean, reliable, and easy to maintain. Think of them as the shop rules that keep the workshop safe and organised. In this section you'll:

- Learn naming and formatting conventions that make your code feel at home in professional teams.
- Discover strategies for reducing bugs, such as defensive programming and unit testing hooks.
- Connect earlier topics—**Methods**, **Classes**, **Error Handling**, and more—into a coherent style guide.

## Why This Matters in the Real World
Employers judge code quality as much as functionality. Following consistent practices means:

- Teammates can read and modify your work quickly.
- You avoid regressions when adding new features because the structure is predictable.
- Your code passes code reviews with fewer rework cycles, speeding up delivery.

## Key Practices and Examples
### Naming and Formatting

```csharp
public class CourseSchedule
{
    public DateTime StartDate { get; set; }

    public void EnrolStudent(string studentId)
    {
        // Implementation goes here
    }
}
```

- Use **PascalCase** for class and method names (`CourseSchedule`, `EnrolStudent`).
- Use **camelCase** for local variables and parameters (`studentId`).
- Keep indentation consistent (4 spaces per level is standard in C#).

### Keep Methods Focused

```csharp
public decimal CalculateTuition(decimal baseFee, decimal discountPercentage)
{
    decimal discountAmount = baseFee * discountPercentage;
    return baseFee - discountAmount;
}
```

- One job per method. If you find yourself adding logging, validation, and calculations into one method, break it up.
- Combine this habit with **Error Handling** by validating inputs before processing.

### Guard Against Nulls

```csharp
public void PrintStudentName(string? name)
{
    if (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("No name provided.");
        return;
    }

    Console.WriteLine(name);
}
```

- Use nullable reference types (`string?`) to signal optional data.
- Guard clauses keep your logic tidy and prevent `NullReferenceException`s.

### Comment with Purpose

```csharp
// Calculates weekly study hours based on enrolment load.
public int EstimateStudyHours(int units)
{
    const int hoursPerUnit = 4;
    return units * hoursPerUnit;
}
```

- Comments explain *why* something is done, not *what* the code already shows.
- Keep comments up to date. Out-of-date comments are worse than none.

### Plan for Testing

```csharp
public interface IDateProvider
{
    DateTime Today { get; }
}
```

- Introducing interfaces for external dependencies lets you mock them during unit tests.
- This ties back to **Inheritance and Polymorphism**, where interfaces promote flexible design.

## Common Mistakes and How to Avoid Them
- **Copy-paste coding** – duplicating blocks creates maintenance headaches. Extract shared logic into **Methods** or helper classes.
- **Skipping reviews** – even small changes benefit from another set of eyes. Practice explaining your code to classmates.
- **Neglecting documentation** – keep README files (like the ones in this repository) updated so future you knows why decisions were made.
- **Ignoring performance basics** – watch out for unnecessary loops or heavy file operations. Revisit **Loops**, **Collections**, and **File IO** when tuning efficiency.
