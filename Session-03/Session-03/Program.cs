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


Grade grd = new();
prof.SetGrade(std.PersonID, uni.Courses[0].CourseID, grd, 9);
Console.WriteLine(grd.StudentID);
Console.WriteLine(grd.GradeID);
Console.WriteLine(grd.CourseID);
Console.WriteLine(grd.ActualGrade);


/*
DateTime date = DateTime.Now;
Console.WriteLine(date.ToString("d-MMM-yy"));

DateTime date2 = DateTime.Parse("10-3-2012 11:30 pm");
Console.WriteLine(date2);

*/


////////    TODO lush askshs !

////////    Pet myPet = new Pet();
////////    myPet.birthAge = 2016;
////////    DateTime currentDate = DateTime.Now; 
////////    Console.WriteLine(currentDate.Year - myPet.birthAge);



