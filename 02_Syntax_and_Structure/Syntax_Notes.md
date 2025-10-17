# Key Syntax Elements

## Namespaces
```
namespace ProjectArea
{
    // types live here
}
```
- `namespace` groups related classes. Helps avoid naming clashes. Essential when we study **Classes and Objects**.

## Classes and Access Modifiers
```
public class Sample
{
}
```
- `public` means other code can access this class.
- `class` defines a blueprint for objects.
- The braces `{ }` contain members such as methods or fields.

## Methods and Signatures
```
private static int Calculate()
{
    // statements
}
```
- `private` – only usable inside the current class.
- `static` – belongs to the class rather than an instance.
- `int` – return type. Links forward to **Variables and Types**.
- `Calculate` – method name using PascalCase convention.
- `()` – parentheses hold parameters. Empty means no input yet.

## Statements and Semicolons
```
DoSomething();
```
- Each instruction ends with `;` to show the compiler the statement is complete.
- Forgetting a semicolon triggers compile errors you'll practise spotting here.
