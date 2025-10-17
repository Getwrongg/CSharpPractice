# Common Mistakes with Variables and Types

- **Using the wrong type** – storing decimal currency values in `float` can cause rounding errors. Prefer `decimal` for money.
- **Shadowing variables** – declaring a variable with the same name inside a smaller scope can hide the original value. Watch out when we start using **Loops**.
- **Overusing `var`** – when the type isn't clear, `var` makes the code cryptic for others reading it later.
- **Forgetting to initialise** – unassigned variables cause compile-time errors. Give them sensible defaults.
