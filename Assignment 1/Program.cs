using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Please choose your program:\n 1. Calculate Income\n 2. Calculate course pass/fail\n 3. Multiply 2 numbers\n 4. Divide 2 numbers\n 5. Compare 2 numbers\n 6. Check if number is odd or even\n 7. Exit");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        double wageHr;
                        double hoursWeek;
                        double weekWage;
                        double monthWage;
                        Console.WriteLine("Please enter your hourly wage:");
                        wageHr = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your hours worked per week:");
                        hoursWeek = double.Parse(Console.ReadLine());
                        weekWage = wageHr * hoursWeek;
                        monthWage = weekWage * 4;
                        Console.WriteLine($"Your monthly wage is ${monthWage}.");

                        break;

                    case 2:
                        string name;
                        double finalGPA;
                        double passFail = 2.5;
                        Console.WriteLine("Please enter your name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Please enter your final GPA:");
                        finalGPA = double.Parse(Console.ReadLine());
                        if (finalGPA >= passFail) { 

                            Console.WriteLine($"You passed, {name}!");
                         }
                        else
                        {
                            Console.WriteLine($"You failed, {name}! :(");
                        }
                        break;

                    case 3:
                        double numOne;
                        double numTwo;
                        double result;
                        Console.WriteLine("Please enter your first number:");
                        numOne = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your second number:");
                        numTwo = double.Parse(Console.ReadLine());
                        if (numOne == 0 || numTwo == 0) {

                            Console.WriteLine("Really? It's 0.");
                        }
                        else
                        {
                            result = numOne * numTwo;
                            Console.WriteLine($"{numOne} x {numTwo} is {result}.");
                        }
                        break;

                    case 4:
                        double division1;
                        double division2;
                        double divisionResult;
                        Console.WriteLine("Please enter your first number:");
                        division1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your second number:");
                        division2 = double.Parse(Console.ReadLine());
                        if (division2 == 0)
                        {
                            Console.WriteLine("YOU CANNOT DIVIDE BY 0.");
                        }
                        else
                        {
                            divisionResult = division1 / division2;
                            Console.WriteLine($"{division1} / {division2} is {divisionResult}.");
                        }
                        break;

                    case 5:
                        double comparison1;
                        double comparison2;
                        Console.WriteLine("Please enter your first number:");
                        comparison1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter your second number:");
                        comparison2 = double.Parse(Console.ReadLine());
                        if (comparison1 > comparison2)
                        {
                            Console.WriteLine($"{comparison1} is the larger number.");
                        }
                        else if (comparison2 > comparison1)
                        {
                            Console.WriteLine($"{comparison2} is the larger number.");
                        }
                        else
                        {
                            Console.WriteLine("You have entered the same number twice.");
                        }

                        break;

                    case 6:
                        double oddEven;
                        Console.WriteLine("Please enter a number:");
                        oddEven = double.Parse(Console.ReadLine());
                        if (oddEven % 2 == 0)
                        {
                            Console.WriteLine("Your number is even");
                        }
                        else
                        {
                            Console.WriteLine("Your number is odd.");
                        }
                        break;
                    case 7:
                        flag = false;
                        break;

                    default:
                        break;
                }

            } while (flag);

        }

    }

}

              
