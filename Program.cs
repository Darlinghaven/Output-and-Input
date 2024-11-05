// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Welcome to the CV creator");
Console.WriteLine("Question 1");
Console.WriteLine("What is your given/first name?");
string name = Console.ReadLine();
Console.WriteLine(name + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 2");
Console.WriteLine("What is your sur/family name?");
string nameTwo = Console.ReadLine();
Console.WriteLine(nameTwo + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 3");
Console.WriteLine("What year were you born?");
string age = Console.ReadLine();
Console.WriteLine(age + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 4");
Console.WriteLine("What is your personal e-mail?");
string email = Console.ReadLine();
Console.WriteLine(email + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 5");
Console.WriteLine("What educational background do you have? i.e. BSC/MSc in Software Design.");
string eduOne = Console.ReadLine();
Console.WriteLine(eduOne + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 6");
Console.WriteLine("Which school/university did you obstain your degree from? i.e. Aarhus University");
string eduTwo = Console.ReadLine();
Console.WriteLine(eduTwo + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 7");
Console.WriteLine("What was you most recent position at a firm?");
string position = Console.ReadLine();
Console.WriteLine(position + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 8");
Console.WriteLine("Which firm were you employed at for the position you just mentioned?");
string firm = Console.ReadLine();
Console.WriteLine(firm + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 9");
Console.WriteLine("What is your native language?");
string language = Console.ReadLine();
Console.WriteLine(language + " entered.");
Console.WriteLine("");

Console.WriteLine("Question 10");
Console.WriteLine("Is it ok for potential employers to reach out with job offers?");
string offers;
while (true)
{
    offers = Console.ReadLine();
    if (offers == "yes" || offers == "no")
    {
        if (offers == "yes")
        {
            Console.WriteLine("You would like job offers.");
        }
        else
        {
            Console.WriteLine("You would not like job offers.");
        }
        break;
    }
    else
    {
        Console.WriteLine("Only 'yes' or 'no'.");
    }
}
Console.WriteLine("");

Console.WriteLine("Generating CV...");
Console.WriteLine("Press any key to continue.");
Console.ReadKey();

Console.WriteLine("========== CV ==========");
Console.WriteLine("Personal Info");
Console.Write("Name: ");
Console.WriteLine($"{name} {nameTwo}");
Console.Write("Year of birth: ");
Console.WriteLine($"{age}");
Console.Write("Speaks: ");
Console.WriteLine($"{language}");
Console.Write("E-mail: ");
Console.WriteLine($"{email}");
Console.WriteLine("");
Console.WriteLine("Educational Level");
Console.WriteLine($"Attended {eduTwo} and obtained the degree {eduTwo}.");
Console.WriteLine("");
Console.WriteLine("Work Experience");
Console.WriteLine($"Worked as {position} at the firm {firm}.");
Console.WriteLine("");
Console.WriteLine($"Would like offers from potential employers?: {offers}");
Console.WriteLine("");
Console.WriteLine("========================");
Console.WriteLine("");