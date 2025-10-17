# Declaring Variables

```
Type variableName = initialValue;
```
- `Type` – `int`, `double`, `string`, etc. Choose based on the data you need to store.
- `variableName` – use camelCase for local variables, e.g., `studentCount`.
- `initialValue` – optional, but helps prevent unassigned variable errors.

## Type Inference
```
var itemCount = 5;
```
- `var` lets the compiler figure out the type from the right-hand side.
- Still strongly typed: `itemCount` is treated as `int` after this line.
- Use when the type is obvious; avoid when it hides meaning.

## Constants
```
const double GstRate = 0.10;
```
- `const` makes the value fixed at compile time.
- Name constants with PascalCase.
- Handy when values are reused across **Methods** and **Classes**.

## Reference vs Value Type Hint
```
string studentName = "Casey";   // reference type
int seatNumber = 12;            // value type
```
- Reference types point to objects on the heap; value types store data directly.
- We'll revisit these differences when we cover **Classes and Objects** and **Collections**.
