using System.Numerics;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] rollTotals = new int[13];
        int die1 = 0;
        int die2 = 0;
        int total = 0;

        string num;

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice would yo like to roll?");
        num = System.Console.ReadLine();

        if(int.TryParse(num, out int numberOfDice))
        {
    //Console.WriteLine("You entered:" + num);
            for(int i=1; i <= numberOfDice; i++)
            {
                die1 = RollDice();
                die2 = RollDice();
                total = die1 + die2;

                rollTotals[total]++;
            }
            for(int i=2; i <= 12; i++)
            {
                double percentage = ((double)rollTotals[i] / numberOfDice) * 100;
                int roundedpercentage = (int)Math.Round(percentage);
                string asterisks = new string('*', roundedpercentage);
                Console.WriteLine(i + " : " + asterisks);
            }
        }
        else
        {
            Console.WriteLine("Invalid Input. Please enter a valid integer");
        }
    }
    private static Random random = new Random();

    private static int RollDice()
    {
        return random.Next(1, 7);
    }
}