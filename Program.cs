namespace Topic_5._5___Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1;
            die1 = new Die(ConsoleColor.Red);
            die1.Color = ConsoleColor.Green;


            die1.DrawRoll();
            die1.RollDie();
            die1.DrawRoll();
        }
    }
}
