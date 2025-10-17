# Classes and Objects in C#

## Overview
Classes are blueprints, and objects are the houses built from them. In this topic you'll:

- Understand how a class bundles data (fields and properties) with behaviour (methods).
- Learn the lifecycle of an object—creation, use, and cleanup.
- See how access modifiers, constructors, and `this` glue the concept together.

These ideas are the backbone for everything that follows, especially **Inheritance and Polymorphism**, where you'll extend and customise base classes.

## Why Classes Matter in Industry
Business software models real-world concepts: customers, invoices, bookings, machines. Each of these can become a class. Employers expect you to:

- Translate requirements into well-structured classes that mirror the domain.
- Keep responsibilities focused—each class should represent a single concept (a principle you'll revisit in **Best Practices**).
- Build objects that manage their own state safely, preventing bugs like invalid data or uninitialised fields.

## Syntax Walk-through
A simple class blueprint:

```csharp
public class Student
{
    // Field (private storage)
    private string _studentId;

    // Property (public-facing access with control)
    public string Name { get; set; }

    // Constructor (runs when a new object is created)
    public Student(string studentId, string name)
    {
        _studentId = studentId;
        Name = name;
    }

    // Method (behaviour)
    public string GetDisplayLabel()
    {
        return $"{_studentId} - {Name}";
    }
}
```

Creating and using an object:

```csharp
Student learner = new Student("TAFE123", "Jordan");
string label = learner.GetDisplayLabel();
```

Important pieces:

- `public class Student` – `public` means other parts of the program can create `Student` objects.
- `_studentId` – private field storing data internally. The underscore naming style signals it's a backing field.
- `Name { get; set; }` – auto-implemented property. Later, you'll expand this to include validation logic.
- `Student(...)` – constructor ensures the object starts life with valid data.
- `GetDisplayLabel()` – method that operates on the object's state. Notice no `static` keyword because the behaviour relies on the specific object.

## Common Mistakes and How to Avoid Them
- **Mixing unrelated data** – if a class starts holding too many responsibilities (e.g., student data plus file saving), split it into focused classes.
- **Bypassing encapsulation** – exposing fields directly (`public string studentId;`) makes later changes painful. Stick with properties and private fields.
- **Forgetting constructors** – leaving fields uninitialised can cause null reference issues. Even a simple constructor keeps things safe.
- **Ignoring immutability options** – sometimes data should not change after creation. Consider read-only properties (`init` setters or no `set`) when you reach **Best Practices**.
