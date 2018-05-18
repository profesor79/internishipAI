using System;

namespace internishipAI
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileProcessor= new FileProcessor();
            var fileName = "201_Z_Rail_Arm_Bottom_Left.gcode";
            fileProcessor.ReadFile(fileName);
            Console.ReadLine();
        }
    }
}
