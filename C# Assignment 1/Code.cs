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
                Console.Clear();
                Console.WriteLine("Please choose your program:\n 1. Calculate Income\n 2. Calculate course pass/fail\n 3. Multiply 2 numbers\n 4. Divide 2 numbers\n 5. Compare 2 numbers\n 6. Check if number is odd or even\n 7. More fun!\n 8. Exit");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();

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
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();

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
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();

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
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();

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
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();

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
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();

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
                        Console.ReadKey();
                        break;
                    
                    case 7:

                        bool flag2 = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Please choose your program:\n 1. Is it a prime number?\n 2. What number am I thinking of?\n 3. Exit");
                            int option2 = int.Parse(Console.ReadLine());
                            switch (option2)
                            {
                                case 1:
                                    Console.Clear();

                                    Console.Write("Enter a Number : ");
                                    int numPrime = int.Parse(Console.ReadLine());
                                    bool IsPrime = true;
                                    for (int n = 2; n < numPrime / 2; n++)
                                    {
                                        if (numPrime % n == 0)
                                        {
                                            IsPrime = false;
                                            break;
                                        }
                                    }
                                    if (IsPrime)
                                    {
                                        Console.Write("Number is Prime.");
                                    }
                                    else
                                    {
                                        Console.Write("Number is not Prime.");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();

                                    int i;
                                    int randomInt;
                                    int userGuess;
                                    var rnd = new Random();
                                    randomInt = rnd.Next(1, 100);
                                    Console.WriteLine("I'm thinking of a number. Please take a guess.");
                                    userGuess = int.Parse(Console.ReadLine());
                                    for (i = 0; i < 2; i++)
                                    {
                                        if (userGuess > randomInt)
                                        {
                                            Console.WriteLine("Too high!");
                                        }
                                        else if (userGuess < randomInt)
                                        {
                                            Console.WriteLine("Too low!");
                                        }
                                        Console.WriteLine("Try again.");
                                        userGuess = int.Parse(Console.ReadLine());


                                        if (userGuess == randomInt)
                                        {
                                            Console.WriteLine("Woah! Are you a psychic?");
                                            break;

                                        }

                                    }
                                    if (i == 2)
                                    {
                                        Console.WriteLine("You Lose!");
                                    }
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    flag2 = false;
                                    break;
                                default:
                                    break;
                            }
                            

                        } while (flag2);
                        break;
                    case 8:
                        flag = false;
                        break;
                    default:
                        break;
                }

            } while (flag);

        }

    }

}

              
