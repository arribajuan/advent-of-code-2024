// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello there!");
Console.WriteLine("-----------------------------");

#region Day 1

var d01Star1 = Stars.Day01.Day01.SumTotalDistance(Stars.Day01.Day01.GetFilePath(Stars.Day01.Day01.FileType.ChallengeData));
var d01Star2 = Stars.Day01.Day01.CalculateSimilarityScore(Stars.Day01.Day01.GetFilePath(Stars.Day01.Day01.FileType.ChallengeData));

Console.WriteLine("Day 1");
Console.WriteLine($" Star 1 - Total distance = {d01Star1}");
Console.WriteLine($" Star 2 - Similarity score = {d01Star2}");
Console.WriteLine("-----------------------------");

#endregion