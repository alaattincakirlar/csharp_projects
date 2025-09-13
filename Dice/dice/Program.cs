Random dice = new Random();

int i = 0, j = 0;
int summary = 0;
int dice_value = 0;

for (i = 0; i < 2; i++)
{
    dice_value = dice.Next(1, 7);

    if (dice_value == summary)
    {
        j++;
    }

    summary = summary + dice_value;
}

if (j == 1)
{
    Console.WriteLine($"Dice roll of two: {summary} and **BINGO**");
}

else
{
    Console.WriteLine($"Dice roll of two: {summary}");
}
