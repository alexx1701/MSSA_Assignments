using System;
using System.Collections.Generic;
namespace ConsoleApp5
{
    
    class Program
    {
        public delegate void emptyEvent();
        public event emptyEvent teacherAngry;
        static void Main(string[] args)
        {
            Dictionary<string, string> studentDict = new Dictionary<string, string>();
            List<string> studentNames = new List<string>();
            List<string> teacherYells = new List<string>();
            teacherYells.Add("Oh, good.");
            teacherYells.Add("Great. The IQ level of our classroom just went up.");
            teacherYells.Add("You'll never amount to anything anyways.");
            teacherYells.Add("You're the reason I struggle to get up in the morning.");
            teacherYells.Add("Alright. That's fine.");
            studentNames.Add("Bruce");
            studentNames.Add("Brian");
            studentNames.Add("Barry");
            studentNames.Add("Meat");
            studentNames.Add("Bradword");

            foreach (string student in studentNames)
            {
                studentDict.Add(student, "A+");
                Console.WriteLine($"Is {student} here?");
                string option = Console.ReadLine();
                option = option.ToLower();
                if (option == "yes")
                {
                    Console.WriteLine($"Ok, thank you {student}.");
                }
                else if (option == "no")
                {
                    grade(student);
                    //notHere();
                    OnteacherAngry();
                }
            }
        
            void notHere()
            {
            teacherYells.RemoveAt(0);
            foreach (string saying in teacherYells)
            {
                Console.WriteLine(saying);
                break;
            }
            }
            void grade(string studentC)
            {
                string x = studentC;
                studentDict[x] = "0";
            }

           void OnteacherAngry() {
                notHere();
            }
        }
    }
}
