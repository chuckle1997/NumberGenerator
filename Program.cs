using System.Diagnostics.Metrics;

int userInput1 = 20;
int userInput2 = 25;
int userInput3 = 5;

for (int i = userInput1; i < userInput2; i++)
{
    Console.WriteLine(i);
}

for (int i = userInput3; i < userInput1; i += userInput3)
{
    Console.WriteLine(i);
}

string textInput = Console.ReadLine();
int textInput2 = 6;

for (int i = 0; i < textInput2; i++)
{
    Console.WriteLine($"{i}. {textInput}");
}


