# Inheritance and Polymorphism in C#

## Overview
Inheritance lets you build specialised versions of an existing class, while polymorphism lets those specialisations behave differently when treated as the base type. Picture a general "Vehicle" plan that spawns cars, trucks, and buses. In this topic you'll:

- Understand how `: BaseClass` extends functionality.
- Learn when to use `virtual`, `override`, and `abstract` to control behaviour.
- See how interfaces give you polymorphism without sharing implementation.

These tools help you reduce duplication and prepare you for larger architectures you'll meet in real projects.

## Why This Matters in Industry
Well-structured inheritance keeps code maintainable. You can fix a bug in a base class and immediately benefit every subclass. Employers look for developers who:

- Spot patterns that deserve a base class versus ones better served by composition (a judgement call refined in **Best Practices**).
- Use polymorphism to remove messy `switch` statements that test object types everywhere.
- Understand interface-driven design—critical when writing code that plugs into frameworks like ASP.NET.

## Syntax Walk-through
Basic inheritance:

```csharp
public class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle starting...");
    }
}

public class ElectricScooter : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Scooter powers on silently.");
    }
}
```

- `Vehicle` declares a `virtual` method, meaning subclasses can override it.
- `ElectricScooter : Vehicle` – the colon reads "ElectricScooter is a Vehicle".
- `override` replaces the base implementation while still sharing the same method signature.

Sometimes you want a method to *require* an override. Use `abstract`:

```csharp
public abstract class Report
{
    public abstract void Generate();
}

public class PdfReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Creating PDF output...");
    }
}
```

You can't instantiate `Report` directly—only concrete subclasses like `PdfReport`.

Interfaces offer another angle:

```csharp
public interface IAuditable
{
    void RecordAction(string description);
}

public class BankAccount : IAuditable
{
    public void RecordAction(string description)
    {
        Console.WriteLine($"Audit: {description}");
    }
}
```

- Classes can implement multiple interfaces, giving you polymorphism without a strict class hierarchy.
- Interfaces pair nicely with dependency injection, a topic you'll touch on when building larger projects.

## Common Mistakes and How to Avoid Them
- **Overusing inheritance** – not every shared behaviour deserves a base class. Sometimes composition (holding a reference to another class) is simpler.
- **Forgetting `base` calls** – when overriding methods that still need the base behaviour, call `base.SomeMethod()` to avoid losing essential setup.
- **Leaking implementation details** – keep base classes focused on shared behaviour. Subclasses should handle specifics.
- **Ignoring interfaces** – if you only ever inherit from one base class, you might miss the flexibility interfaces offer when working with frameworks and testing.
