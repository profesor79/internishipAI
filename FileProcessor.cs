using System;
using System.Collections.Generic;
using System.Text;

namespace internishipAI
{
 public   class FileProcessor
    {

        public void ReadFile(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            var instructions = new List<string>();
            foreach (var line in lines)
            {
                if (line.Trim().ToUpper().StartsWith("G"))
                {
                    instructions.Add(line);
                }
            }
           
            // now calculate total lines distance by getting
            var commandsCount = instructions.Count;

            for (int i = 0; i < commandsCount-1; i++)
            {
                var start = instructions[i];
                var end = instructions[i + 1];
                var s1Commands = start.Split(" ");
                foreach (var command in s1Commands)
                {
                    Console.WriteLine(command);
                }

            }
            }
            }
}
