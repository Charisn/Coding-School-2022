using Session_04;
//***************************************************************************************
//1

Console.WriteLine("What is your name?: ");
string name = Console.ReadLine();
string reversedName = Askhsh1.ReversedName(name);
Console.WriteLine(reversedName);

//***************************************************************************************
//2

Console.WriteLine("Give me a number so i can give you Sum and Product: ");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);
var c2 = new SumAndProduct();
Console.WriteLine("The sum is " + c2.GetSum(n));
Console.WriteLine("the Product is : " + c2.GetProduct(n));

//***************************************************************************************
//3

PrimeNumbers.PrintPrime(args);

//***************************************************************************************
//4

Multiply.MultiplicationArray();
