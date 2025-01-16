using Mission01;

internal class Program
{
    private static void Main(string[] args)
    {
        //initialize variables
        string strnumrolls = "";
        int numrolls = 0;
        int[] sumList = new int[numrolls];
        int partOfTotal = 0;
        float percentOfTotal = 0;
        int roundedPercent = 0;

        //welcome message
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
            "How many dice rolls would you like to simulate? ");

        //read the string and change it into an integer
        strnumrolls = System.Console.ReadLine();
        numrolls = int.Parse(strnumrolls);

        //create a list for the results of the Rolling method to be passed into
        sumList = RollDice.Rolling(numrolls);

        //write intro to results
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n" +
            "Each \"*\" represents 1% of the total number of rolls.\n" +
            "Total number of rolls = " + numrolls + ". ");
       
        //loop through numbers 2-12
        for (int i = 2; i < 13; i++)
        {
            //reset the value to 0 
            partOfTotal = 0;

            //calculate how many times you rolled a particular number
            foreach (int sum in sumList)
            {
                if (sum == i)
                {
                    partOfTotal++;
                }
            
                              
            }
            //calculate percentage and multiply it by 100
            percentOfTotal = (float)partOfTotal / numrolls;
            percentOfTotal = percentOfTotal * 100;

            //round it 
            roundedPercent = (int)Math.Round(percentOfTotal);

            //write an asterisk for every 1 (representing 1%)
            System.Console.WriteLine(i + ":" + new string('*', roundedPercent));

        }
        //farewell message
        System.Console.WriteLine("\nThank you for using the dice roll simulator. Goodbye!");





    }
}