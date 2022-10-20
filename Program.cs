int firstTest = 0;
int secondTest = 0;
double prozent = 0;
int maxPoints = 60;
int homework = 0;
int speakingExam = 0;


Console.Write("Have you written the exam yes or no?");
string answer = Console.ReadLine()!;

if (answer == "yes")

{
    Console.WriteLine("How many points have you reached from 0-20?");
    firstTest = int.Parse(Console.ReadLine()!);
}
else { maxPoints = 20; }

Console.Write("Have you written the 2nd exam yes or no?");
string answer2 = Console.ReadLine()!;


if (answer == "yes")
{
    Console.WriteLine("How many points have you reached from 0-20?");
    secondTest = int.Parse(Console.ReadLine()!);
}
else { maxPoints = 20; }

Console.WriteLine("How many point did u got at your homework");
homework = int.Parse(Console.ReadLine()!);

Console.Write("Have you written an speaking exam?");
string answer3 = Console.ReadLine()!;

if (answer == "yes")

{
    Console.WriteLine("How many points did you get on your speaking exam");
    speakingExam = int.Parse(Console.ReadLine()!);
}

prozent = 100d * (firstTest + homework + speakingExam + secondTest) / maxPoints;
System.Console.WriteLine($"you got {prozent} % right");


if (prozent >= 89)
{
    Console.WriteLine("Your grade is a 1");
}
else if (prozent >= 76)
{
    Console.WriteLine("Your grade is a 2");
}

else if (prozent >= 63)
{
    Console.WriteLine("Your grade is a 3");
}
else if (prozent >= 50)
{
    Console.WriteLine("Your grade is a 4");
}
else if (prozent < 50)
{
    Console.WriteLine("Your grade is a a 5");
}

