using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Three_Class_Task
{
    class Game
    {
        Dice[] dices = new Dice[3];

        public void RollDices()
        {
            for (int i = 0; i < 3; i++)
            {
                dices[i] = new Dice(); //Creates three dice objects and stores them in the dices array at positions 0, 1 and 2
            }
        }

        public void RollThree()
        {
            int totalSum = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int rollResult = dices[i].Roll(); //Calls the Roll method on each dice object
                Console.WriteLine($"Dice {i + 1}: {rollResult}");
                totalSum += rollResult;
            }

            Console.WriteLine($"Total Sum: {totalSum}");
        }

        public void ContinousDice(int numberOfRolls)
        {
            int x = 0;
            while (x < numberOfRolls)
            {
                RollThree();
                Console.WriteLine();
                x++;
            }
        }

    }
}
