using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


int randomNumber = Random.Shared.Next(0, 10);
string guess = "";
int guessNumber;


while (guess != randomNumber.ToString())
{
    Console.WriteLine("Guess the number 1-10");
    guess = Console.ReadLine();

    int.TryParse(guess, out guessNumber);
    if (guessNumber > randomNumber)
    {
        Console.WriteLine("Lower!");
    }
    if (guessNumber < randomNumber)
    {
        Console.WriteLine("Higher!");
    }
    else if (guessNumber == randomNumber)
    {
        Console.WriteLine("Congrats you got it right!");
        Console.ReadLine();
    }
}
