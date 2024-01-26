using ExercicioFixacaoExceptions.Entities;
using ExercicioFixacaoExceptions.Entities.Exceptions;
using System.Globalization;


    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw Limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(number, holder, balance, withdrawLimit);

    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
try
{
    account.WithDraw(amount);
}
catch (DomainException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}
