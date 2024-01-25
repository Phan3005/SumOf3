
Console.WriteLine("Write your first number!");
string firstNumberAsString = Console.ReadLine();

double firstNumber = Convert.ToDouble(firstNumberAsString);

Console.WriteLine("Write your second number!");
string secondNumberAsString = Console.ReadLine();

double secondNumber = Convert.ToDouble(secondNumberAsString);

Console.WriteLine("Write your third number!");
string thirdNumberAsString = Console.ReadLine();

double thirdNumber = Convert.ToDouble(thirdNumberAsString);

double sum = firstNumber + secondNumber + thirdNumber;

Console.WriteLine($"The total of your numbers is {sum.ToString("N3")}!");

const double tripleSeven = 7.777;

double final = sum * tripleSeven;
Console.WriteLine($"{sum.ToString("N3")} times {tripleSeven.ToString("N3")} is {final.ToString("N3")}!");

