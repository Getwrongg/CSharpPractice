# Skeleton of a C# Program

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
