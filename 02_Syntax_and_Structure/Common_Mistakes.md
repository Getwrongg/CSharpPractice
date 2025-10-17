# Common Mistakes in Syntax and Structure

- **Mismatched braces** – leaving out a closing `}` shifts code blocks and confuses the compiler. Counting indentation helps.
- **Wrong access modifier** – marking everything `public` can expose implementation details. Think about who should see each member.
- **CamelCase vs PascalCase** – method names should be PascalCase in C#. Using inconsistent naming makes code harder to read for teammates.
- **Missing `using` directives** – if you forget to include required namespaces, later topics like **Collections** won't compile.
