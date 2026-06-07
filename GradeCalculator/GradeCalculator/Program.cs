Console.WriteLine("=== Student Grade Calculator ===\n");

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("How many subjects do you have? ");
int subjectCount = int.Parse(Console.ReadLine());

double total = 0;

for(int i = 1; i <=subjectCount; i++)
{
    Console.Write($"Enter mark for Subject {i}: ");
    double mark = double.Parse(Console.ReadLine());
    total += mark;
}

double average = total / subjectCount;
string grade;

if (average >= 75)
    grade = "Distinction";
else if (average >= 60)
    grade = "Merit";
else if (average >= 50)
    grade = "Pass";
else
    grade = "Fail";

Console.WriteLine($"\n--- Results for {name}");
Console.WriteLine($"Average mark: {average:F2}%");
Console.WriteLine($"Grade: {grade}");
