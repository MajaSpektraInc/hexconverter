//// See https://aka.ms/new-console-template for more information
using testConsole;

//Console.WriteLine("Enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//if (age<18)
//{
//    Console.WriteLine("You can't drink legally.");
//}
//else if (age < 21)
//{
//    Console.WriteLine("You can't drink legally in America.");
//}
//else
//{
//    HexConverter.PrintHello();
//}

//Console.WriteLine("Enter a number: ");
//float a = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter another number: ");
//float b = float.Parse(Console.ReadLine());
//float n = HexConverter.AddNumbers(a, b);
//Console.WriteLine(n);

//Console.WriteLine("Enter a Hex");
//String hexcode = Console.ReadLine();
//char[] codes = hexcode.ToCharArray();

//foreach(char c in codes)
//{
//    Console.WriteLine(c);
//}


Console.WriteLine("Enter a HEX");
string hexcode = Console.ReadLine();

Console.WriteLine(HexConverter.HextoInt(hexcode));