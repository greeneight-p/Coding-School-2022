using Session_03;

Person person = new();
person.SetName("Person's Name");

Console.WriteLine(person.PersonID);
Console.WriteLine(person.GetName());


Professor prof = new();
prof.SetName("John");
Console.WriteLine(prof.PersonID);
Console.WriteLine(prof.GetName());

Student std = new();
std.SetName("Jim");
Console.WriteLine(std.PersonID);
Console.WriteLine(std.GetName());
