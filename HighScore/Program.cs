int[] scores = { 50, 40, 30, 20, 10 };

float total = 0, average;

int highestScore = 0;

for (int i = 0; i < scores.Length; i++)
{
    //Player 1: ...
    Console.WriteLine($"Player {i + 1}: {scores[i]}");

    total += scores[i];

    if (scores[i] > highestScore)
    {
        highestScore = scores[i];
    }
}

average = total / scores.Length;

Console.WriteLine($"Average score: {average}");
Console.WriteLine($"Highest score: {highestScore}");