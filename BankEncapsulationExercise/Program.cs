// See https://aka.ms/new-console-template for more information
using BankEncapsulationExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount();

        Console.WriteLine("Write how much you are depositing");

        if(double.TryParse(Console.ReadLine(), out double d))
        {
            bankAccount.Deposit(d);
        }
        else
        {
            Console.WriteLine("You did not enter a double, restart program to deposit");
        }

        Console.WriteLine("Do you want to retrieve your balance? Y for yes, N for no");

        string doTheyWantToDeposit = Console.ReadLine();
        
        if(doTheyWantToDeposit == "y" || doTheyWantToDeposit == "Y")
        {
            Console.WriteLine($"{bankAccount.GetBalance()}");
        }
        else if (doTheyWantToDeposit == "N" || doTheyWantToDeposit == "n")
        {
            Console.WriteLine("Okay, have a nice day!");
        }
        else
        {
            Console.WriteLine("You did not put a y or an n, restart to retrieve balance");
        }
    }
}