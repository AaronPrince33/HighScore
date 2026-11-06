int[] scores = { 30, 30, 20, 10, 10 };

float total = 0, average;

for (int i = 0; i < scores.Length; i++)
{
    //Player 1: ...
    Console.WriteLine($"Player {i+1}: {scores[i]}");

    total += scores[i];
}

average = total / scores.Length;

Console.WriteLine($"Average score: {average}");