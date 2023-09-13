var highScore = -1;

ulong counter = 1;

var die = new Random();

var total = 0;

while (total <= 722 && counter <= ulong.MaxValue)
{
    var roll = 0;

    total = 0;

    do
    {
        total += roll;
        roll = die.Next(1, 7);
    }
    while (roll != 1);

    if (total > highScore)
    {
        Console.WriteLine($"New high score of {total} on game {counter:N0}!");
        highScore = total;
    }

    if (counter % 1000000000000000000 == 0)
    {
        Console.WriteLine($"Just played game {counter/1000000000000000000} quintillion!");
    }

    if (total > 722)
    {
        Console.WriteLine("You win!");
        return;
    }

    counter++;
}

Console.WriteLine("Game over. Ran out of numbers in ulong!");