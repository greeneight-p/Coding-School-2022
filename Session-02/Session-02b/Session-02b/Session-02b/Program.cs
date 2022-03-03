//1.
Console.WriteLine("------------1");
Console.WriteLine("Hello, Giannis Polychroniadis.!\n");


//2.
int number1 = 5;
int number2 = 6;
Console.WriteLine("------------2");
Console.WriteLine(number1 + number2);
Console.WriteLine(number1 / (float)number2 + "\n");

//3.
Console.WriteLine("------------3");
Console.WriteLine(-1 + 5 * (float)6);
Console.WriteLine(38 + 5 % (float)7);
Console.WriteLine(14 + -3 * 6 / (float)7);
Console.WriteLine(2 + 13 / (float)6 * 6 + Math.Sqrt(7));
Console.WriteLine(Math.Pow(6, 4) + Math.Pow(5, 7) / (9 % 4) + "\n");

//4
string myName = "John";
int myAge = 27;
Console.WriteLine("------------4");
Console.WriteLine("You are " + myName + " and look younger than " + myAge + "\n");

//5
int seconds = 45678;
Console.WriteLine("------------5");
Console.WriteLine("45678 seconds are " + seconds / (float)60 + " minutes");
Console.WriteLine(seconds / (float)60 / 60 + " Hours");
Console.WriteLine(seconds / (float)60 / 60 / 24 + " Days");
Console.WriteLine(seconds / (float)60 / 60 / 24 / 365 + " Years\n");

//6
TimeSpan time = TimeSpan.FromSeconds(45678);
Console.WriteLine("------------6");
Console.WriteLine("45678 seconds are " + time.TotalMinutes + " minutes");
Console.WriteLine(time.TotalHours + " Hours");
Console.WriteLine(time.TotalDays + " Days");
Console.WriteLine(time.TotalDays / 365 + "Years\n");
//Console.WriteLine(time.);

//7
Console.WriteLine("------------7");
float celsius = 30;
Console.WriteLine("Temperature in celsius is: " + celsius);
float fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);

Console.ReadLine();