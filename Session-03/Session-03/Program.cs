using Session_03;

Person person = new();
person.SetName("Person's Name");

Console.WriteLine(person.PersonID);
Console.WriteLine(person.GetName());


Professor prof = new();
prof.ProfessorName = "John";
//prof.SetName("John");
Console.WriteLine(prof.PersonID);
//Console.WriteLine(prof.GetName());
Console.WriteLine(prof.ProfessorName);

Student std = new();
std.SetName("Jim");
Console.WriteLine(std.PersonID);
Console.WriteLine(std.GetName());


University uni = new University();

Course course = new();
uni.Courses[0] = course;
Console.WriteLine(uni.Courses[0].CourseID);


Schedule schedule = new();
uni.ScheduleCourses[0] = schedule;
Console.WriteLine(uni.ScheduleCourses[0].ScheduleID);






////////    TODO lush askshs !

////////    Pet myPet = new Pet();
////////    myPet.birthAge = 2016;
////////    DateTime currentDate = DateTime.Now; 
////////    Console.WriteLine(currentDate.Year - myPet.birthAge);



