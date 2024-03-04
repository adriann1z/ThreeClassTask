using System;
using Three_Class_Task;

namespace Three_Dice_Task
{
    class Program
    {

        static void Main(string[] args)
        {
            Game game = new Game();
            game.RollDices();

            Console.WriteLine("Rolling three dices");
            game.RollThree();
            Console.WriteLine();


            Console.Write("Enter the number of continuous rolls: ");
            int numberOfRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Rolling the dice continuously for {numberOfRolls} times:");
            game.ContinousDice(numberOfRolls);
        }
    }
}