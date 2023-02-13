using System;

//Number Generator
Random rnd = new Random();
int number = rnd.Next(3,10);

//Main

string answer = "";
int exit = 1;

Console.WriteLine("Enter 1 to display full triangle");
Console.WriteLine("Enter 2 to display partial triangle");
Console.WriteLine("Enter 3 to exit");
answer = Console.ReadLine();
while (exit == 1)
{
    if (answer == "1")
    {
        GetFull(number);
        exit = 2;
    }
    else if (answer == "2")
    {
       GetPartial(number);
       exit = 2;
    }
    else if (answer == "3")
    {
        Console.WriteLine("Exiting");
        exit = 2;
    }
    else
    {
        System.Console.WriteLine("Invalid answer please try again");
        answer = Console.ReadLine();
    }
}


//Full Triangle

static void GetFull(int number)
{
for (int i = 0; i <= number; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("0 ");
    }
    Console.Write("\n");
}
Console.Read();
}



//Partial Triangle

static void GetPartial(int number)
{
for (int i = 0; i <= number; i++)
{
    for (int j = 0; j <= i; j++)
    {
        var random = new Random();
        var list = new List<string>{ "0 ","0 ","0 ","  ","  "};
        int broken = random.Next(list.Count);
        Console.Write(list[broken]);
    }
    Console.Write("\n");
}
Console.Read();
}


