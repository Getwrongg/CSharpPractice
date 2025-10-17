using System;

namespace SyntaxStructureDemo
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Syntax and Structure demo.");
            Console.WriteLine("We are running inside the 'Main' method of the 'Program' class.");

            var explanation = ExplainMethodSignature("Main", isStatic: true, returns: "void");
            Console.WriteLine(explanation);

            Console.WriteLine();
            Console.WriteLine("Each statement like this ends with a semicolon to tell the compiler it's complete.");
        }

        private static string ExplainMethodSignature(string methodName, bool isStatic, string returns)
        {
            string accessibility = "public";
            string staticInfo = isStatic ? "static" : "instance";

            return $"This {accessibility} {staticInfo} method called {methodName} returns {returns}, mirroring the breakdown in the Syntax & Structure notes.";
        }
    }
}
