using System;

class Program
{
    public static void Main(string[] args)
    {
        bool exitProgram = false;

        while (!exitProgram)
        {
            DisplayMotto();
            DisplayMenu();

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                CalculateRevenue();
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                exitProgram = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter '1' or '2'.");
            }
        }
    }

    static void DisplayMotto()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }

    static void CalculateRevenue()
    {
        int lastYearContestants = GetValidContestants("number of contestants last year: ");
        int thisYearContestants = GetValidContestants("number of contestants this year: ");

        int ticketCost = 25;
        int revenue = thisYearContestants * ticketCost;

        Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
        Console.WriteLine($"Revenue expected this year is ${revenue}");

        if (thisYearContestants > 2 * lastYearContestants)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        Console.WriteLine();
    }

    static int GetValidContestants(string message)
    {
        int contestants;
        while (true)
        {
            Console.Write(message);
            contestants = Convert.ToInt32(Console.ReadLine());
            if (contestants >= 0 && contestants <= 30)
            {
                return contestants;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
            }
        }
    }
}