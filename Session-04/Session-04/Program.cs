using Session_04;


//1***************************************************
string name = "Giannis Polychroniadis";
Class1 a = new Class1();
Console.WriteLine("Askhsh 1");

Console.WriteLine(a.ReverseString(name));

//2***************************************************
Console.WriteLine("Askhsh 2");

string input = string.Empty;
int n = -1;
int choice = -1;


do {

    //n = Convert.ToInt32(Console.ReadLine()); de mporesa me ayton ton tropo na leisw t thema lathos input

    Console.WriteLine("Please provide an integer > 0");
    Int32.TryParse(Console.ReadLine(), out n);

} while (n<=0);


do {
    Console.WriteLine("Press 1: Sum or 2: Product");
    Int32.TryParse(Console.ReadLine(), out choice);

} while (choice < 1 || choice > 2);

Class2 b = new Class2();

Console.WriteLine(b.ExecuteChoice(choice, n));



//3***************************************************
Console.WriteLine("Askhsh 3");
int x = -1;
do {

    Console.WriteLine("Please provide an integer > 0");
    Int32.TryParse(Console.ReadLine(), out x);

} while (x <= 0);

Class3 c = new Class3();
Console.WriteLine(c.GetPrimeNumbers(x));


//4***************************************************
Console.WriteLine("Askhsh 4");
int[] ar1 = {2, 4, 9, 12};
int[] ar2 = {1, 3, 7, 10};

Class4 d = new Class4();
Console.WriteLine(d.MultiplyArrays(ar1, ar2));