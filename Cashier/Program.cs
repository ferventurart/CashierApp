using Cashier;

MenuExtension.WelcomeScreen();

Console.Write("Please, introduce your name: ");
var name = Console.ReadLine();

Console.WriteLine();

MenuExtension.ShowOptions();

Console.Write("Select the operation (1 to withdraw money, 2 to deposit money): ");
var option = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Enter the amount of money: ");
var amount = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

MenuExtension.ProcessOperation(name, option, amount);