using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Topic_5._5___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;


            while (!done)
            {


                Console.WriteLine("Press any button to roll dice or type QUIT to quit the program");
                string response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "QUIT")
                {
                    done = true;
                }

                else
                {

                    Die die1, die2;


                    die1 = new Die(ConsoleColor.Red);
                    die2 = new Die(ConsoleColor.Green);



                    int sum;

                    die1.RollDie();
                    die1.DrawRoll();
                    die2.RollDie();
                    die2.DrawRoll();


                    Console.ForegroundColor = ConsoleColor.Gray;

                    sum = die1.Roll + die2.Roll;

                    if (die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("Doubles!");
                    }

                    if (die1.Roll == 1 && die2.Roll == 1)
                    {
                        Console.WriteLine("Snake eyes!");
                    }

                    if (sum % 2 == 0)
                    {
                        Console.WriteLine("Even Sum!");
                    }

                    if (die1.Roll - die2.Roll == 1 || die2.Roll - die1.Roll == 1)

                    {
                        Console.WriteLine("Sequential!");

                    }

                    if (die1.Roll > die2.Roll)
                    {
                        Console.WriteLine("Roll 1 was greater!");
                    }

                    if (die2.Roll > die1.Roll)
                    {
                        Console.WriteLine("Roll 2 was greater!");
                    }

                    Console.WriteLine();

                }
            }



        }

    }
}
    

