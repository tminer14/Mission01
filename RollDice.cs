using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission01
{
    internal class RollDice
    {
        public static int[] Rolling(int numrolls)
        {
            // Create an instance of the Random class
            Random rand = new Random();
            //initialize other variables
            int randomInt1 = 0;
            int randomInt2 = 0;
            int rollSum = 0;
            int[] sumList = new int[numrolls];

            for (int i = 0; i < numrolls; i++)
            { // Generate a random integer between 1 and 6 (inclusive)
                randomInt1 = rand.Next(1, 7);
                randomInt2 = rand.Next(1, 7);

                //add the two rolls together
                rollSum = randomInt1 + randomInt2;

                //add sum to an array
                sumList[i] = rollSum;
            }

            //return the array to be used in the other class
            return sumList;
        }
    }
}
