using Mission01;

internal class Program
{
    private static void Main(string[] args)
    {
        string strnumrolls = "";
        int numrolls = 0;
        int[] sumList = new int[numrolls];
        int partOfTotal = 0;
        float percentOfTotal = 0;
        int roundedPercent = 0;

        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
            "How many dice rolls would you like to simulate? ");

        strnumrolls = System.Console.ReadLine();
        numrolls = int.Parse(strnumrolls);

        sumList = RollDice.Rolling(numrolls);


        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n" +
            "Each \"*\" represents 1% of the total number of rolls.\n" +
            "Total number of rolls = " + numrolls + ". ");
       

        for (int i = 2; i < 13; i++)
        {

            partOfTotal = 0;

            foreach (int sum in sumList)
            {
                if (sum == i)
                {
                    partOfTotal++;
                }
            
                              
            }
            percentOfTotal = (float)partOfTotal / numrolls;
            percentOfTotal = percentOfTotal * 100;

            roundedPercent = (int)Math.Round(percentOfTotal);

            System.Console.WriteLine(i + ":" + new string('*', roundedPercent));

        }
        System.Console.WriteLine("\nThank you for using the dice roll simulator. Goodbye!");





    }
}