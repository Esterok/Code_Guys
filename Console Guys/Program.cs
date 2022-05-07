using System;

namespace Console_Guys
{
    
    internal class Program
    {


        public static void Guys()

        {
            int roomNum;
            string oper = null;
            string password = null;
            int guessCount = 0;
            int guessLimit = 3;
            bool OutOfGuesses = false;



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nYellow Guys - 1");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Magenta Guys - 2");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cyan Guys - 3");

            Console.ResetColor();
            Console.Write("\nEnter your room : ");
            roomNum = int.Parse(Console.ReadLine());

            if (roomNum == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You join yellow's room.");
                Console.WriteLine("Yellow guys like lucky people, you need to prove your luck!");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour chances 50 / 50");
                Console.ReadKey();

                Random rd = new Random();
                int rand_num = rd.Next(0, 100);
                if (rand_num >= 50)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have just proven your luck!");
                    Console.WriteLine("You got respect from the yellow guys.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nPress any button.");
                    Console.ReadKey();


                }
                else
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have failed your test.");
                    Console.WriteLine("\nPress any button to try again.");
                    Console.ReadKey();

                }

            }
            else if (roomNum == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("You join magenta's room");
                Console.WriteLine("In this room you can calculate 2 numbers");

                Console.ResetColor();
                Console.Write("\nEnter the first number : ");
                double firstNum = double.Parse(Console.ReadLine());
                Console.Write("\nEnter the operator (+ - / * ) : ");
                oper = Console.ReadLine();
                Console.Write("\nEnter the second number : ");
                double secondNum = double.Parse(Console.ReadLine());
                if (oper == "+")
                {
                    Console.Write("\n\nAnswer = ");
                    Console.Write(firstNum + secondNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\nPress any button.");
                    Console.ReadKey();
                }
                else if (oper == "-")
                {
                    Console.Write("\n\nAnswer = ");
                    Console.Write(firstNum - secondNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPress any button.");
                    Console.ReadKey();
                }
                else if (oper == "/")
                {
                    Console.Write("\n\nAnswer = ");
                    Console.Write(firstNum / secondNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPress any button.");
                    Console.ReadKey();
                }
                else if (oper == "*")
                {
                    Console.Write("\n\nAnswer = ");
                    Console.Write(firstNum * secondNum);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nPress any button.");
                    Console.ReadKey();
                }
            }
            else if (roomNum == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You join cyan's room");
                Console.WriteLine("In this room cyan guys are trying to hack the PC \nYou need to help them!");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nOkay, give me your password...");
                Console.WriteLine("Help : u D n n e o g");
                


                while (password != "Dungeon" && !OutOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        Console.Write("\nPassword : ");
                        password = Console.ReadLine();
                        guessCount++;
                    }
                    else
                    {
                        OutOfGuesses = true;
                    }
                }
                if (OutOfGuesses)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("You have failed your test.");
                    Console.WriteLine("Cyan guys are disappointed in you");
                    Console.WriteLine("\nPress any button to try again.");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Congratulations, you hacked the PC and earned the respect of the Cyan guys!");
                    Console.WriteLine("\nPress any button.");
                    Console.ReadKey();
                }
            }

            
        }

        public static void Main(string[] args)
        {

            Console.Clear();
            Console.ResetColor();
            string welcome = "Welcome to Console guys";
            Console.SetCursorPosition((Console.WindowWidth - welcome.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcome);

            Guys();


            
            Main(args);

            Console.ReadKey();

        }
    }
}
