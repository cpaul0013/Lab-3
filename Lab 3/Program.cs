using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the number analyzer. What would you like to be called?: ");
            string userName = Console.ReadLine();
            bool runProgram = true;
            while (runProgram)
            {
                Console.Write($"Okay, {userName} Please enter a number between 1-100: ");
                double userNumber = double.Parse(Console.ReadLine());
               
                if (userNumber <= 0 || userNumber > 100)
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }
                 
                // evens
                if(userNumber % 2 == 0)
                {
                    if(userNumber < 25)
                    {
                        Console.WriteLine("The number is even and less than 25");
                    }
                    else if(userNumber > 25 && userNumber <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if(userNumber > 60)
                    {
                        Console.WriteLine($"{userNumber} is even");
                    }
                }
                
                // odds but a and e had the same directions for above or below 60.
                if(userNumber % 2 != 0)
                {
                    if(userNumber <= 60)
                    {
                        Console.WriteLine($"{userNumber} is odd");
                    }

                    else if(userNumber > 60)
                    {
                        Console.WriteLine($"{userNumber} is odd");
                    }
                }
              
              
                    Console.WriteLine("Would you like to continue? Y / N");
                    string keepGoing = Console.ReadLine();
                    if (keepGoing == "y" || keepGoing == "Y")
                    {
                        runProgram = true;
                        
                    }
                    else if (keepGoing == "n" || keepGoing == "N")
                    {
                    Console.WriteLine($"Goodbye, {userName}");
                        runProgram = false;
                        
                    }
                    


                }
               

                }
            }

        
    }

    

