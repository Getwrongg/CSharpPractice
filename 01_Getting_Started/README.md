# Getting Started with C#

## Overview
Welcome! This section sets the scene for what C# is, where it lives, and how you'll be using it throughout this learning journey. We'll unpack the basic building blocks such as the .NET ecosystem, development tools, and how a simple C# application is organised. Think of this as learning the layout of the workshop before you pick up the tools.

By the end you'll be comfortable with:
- Describing what C# is used for in Aussie industries.
- Setting up your development environment on Windows machines commonly used in TAFE labs.
- Reading the skeleton of a basic C# program and knowing what each part is called.

You'll see every idea from this section pop up again later, especially when we dive into syntax and program structure in the next topic.

## Context in Real Work
Before writing any C# code, you need to understand the environment it lives in. C# runs on the .NET platform, which looks after things like memory management, libraries, and the compiler. Knowing this upfront helps you make sense of later topics like namespaces and classes because you'll know who is in charge under the hood.

In real workplaces, developers rarely start from scratch. They inherit projects, set up workstations, and join existing teams. This topic mirrors that experience by showing you how to prepare your tools and understand the moving parts. When you reach topics like **Syntax and Structure** and **Methods**, you'll already recognise the standard pieces because you've met them here.

## Syntax Walk-through
```
using NamespaceName;

namespace ProjectNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // statements go here
        }
    }
}
```

- `using NamespaceName;` – tells the compiler which library or namespace to bring into reach. You'll revisit this in **Syntax and Structure**.
- `namespace ProjectNamespace` – wraps related code into a named space so it doesn't clash with other code. We'll unpack namespaces again when we create classes in later topics.
- `class Program` – defines a blueprint for objects. At the start you just need to know the entry point lives inside a class; the deeper meaning arrives in **Classes and Objects**.
- `static void Main(string[] args)` – the entry method. `static` means it belongs to the class itself, `void` means it returns nothing, and `string[] args` represents incoming text values from the command line. These keywords are broken down further when we tackle **Methods**.

## Common Mistakes to Watch For
- **Skipping the tooling setup** – jumping straight into coding without checking .NET SDK versions can lead to confusing compiler errors later.
- **Ignoring namespaces** – leaving out `using` statements or not understanding namespaces makes future topics like classes and collections harder to digest.
- **Copying code blindly** – pasting sample programs without checking each keyword slows down learning. Try narrating what every part of the skeleton does.
