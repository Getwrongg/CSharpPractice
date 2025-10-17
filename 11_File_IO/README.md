# File Input and Output in C#

## Overview
File IO (Input/Output) is how your program reads from and writes to files on disk. Whether you're storing configuration settings, exporting reports, or importing data, these skills are essential. In this topic you'll:

- Work with the `System.IO` namespace to create, read, and append text files.
- Use `using` statements to ensure files are closed properly.
- Handle common issues like missing files or locked resources, tying back to **Error Handling**.

## Real-World Context
TAFE-level projects often include tasks like reading CSV enrolment lists or writing log files for auditing. Employers expect graduates to:

- Respect file paths and permissions, especially on shared network drives.
- Prevent data loss by validating before overwriting files.
- Log errors when file operations fail so support staff can diagnose problems.

## Syntax Walk-through
Writing text to a file:

```csharp
using (StreamWriter writer = new StreamWriter("students.txt"))
{
    writer.WriteLine("Jordan, Certificate IV");
    writer.WriteLine("Alex, Diploma");
}
```

- `using` ensures `writer.Dispose()` is called automatically, even if an exception occurs.
- The file is created if it doesn't exist; existing content is overwritten. Use `new StreamWriter(path, append: true)` to append instead.

Reading the entire file:

```csharp
if (File.Exists("students.txt"))
{
    string[] lines = File.ReadAllLines("students.txt");
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
else
{
    Console.WriteLine("No student file found.");
}
```

- `File.Exists` prevents a `FileNotFoundException`—a tidy example of combining IO with **Conditionals**.

Working with directories:

```csharp
string reportsFolder = Path.Combine(Environment.CurrentDirectory, "Reports");
Directory.CreateDirectory(reportsFolder);

string reportPath = Path.Combine(reportsFolder, "Summary.txt");
File.WriteAllText(reportPath, "Daily summary goes here.");
```

- `Path.Combine` handles slashes correctly across Windows, macOS, and Linux.
- `Directory.CreateDirectory` is safe to call even if the folder already exists.

## Common Mistakes and How to Avoid Them
- **Hard-coding absolute paths** – makes the program brittle across different machines. Use `Path.Combine` and configuration files.
- **Leaving files open** – forgetting `using` or `Dispose()` locks the file so other parts of the program can't access it.
- **Ignoring encoding** – when dealing with non-English characters, specify `new StreamWriter(path, false, Encoding.UTF8)`.
- **Not handling exceptions** – wrap IO operations with the strategies from **Error Handling** to give friendly feedback instead of crashing.
