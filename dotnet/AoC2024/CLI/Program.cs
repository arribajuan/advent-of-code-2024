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

#region Day 2

var d02Star1 = Stars.Day02.Day02.CountSafeReports(Stars.Day02.Day02.GetFilePath(Stars.Day02.Day02.FileType.ChallengeData));
var d02Star2 = Stars.Day02.Day02.CountSafeAndDampenedReports(Stars.Day02.Day02.GetFilePath(Stars.Day02.Day02.FileType.ChallengeData));

Console.WriteLine("Day 2");
Console.WriteLine($" Star 1 - Total safe reports = {d02Star1}");
Console.WriteLine($" Star 2 - Total safe reports plus dampening = {d02Star2}");
Console.WriteLine("-----------------------------");

#endregion

#region Day 3

var d03Star1 = Stars.Day03.Day03.AddMultiplications(Stars.Day03.Day03.GetFilePath(Stars.Day03.Day03.FileType.ChallengeData));
var d03Star2 = Stars.Day03.Day03.AddMultiplicationsWithConditionals(Stars.Day03.Day03.GetFilePath(Stars.Day03.Day03.FileType.ChallengeData));

Console.WriteLine("Day 3");
Console.WriteLine($" Star 1 - Add multiplications= {d03Star1}");
Console.WriteLine($" Star 2 - Add multiplicationswithconditionals= {d03Star2}");
Console.WriteLine("-----------------------------");

#endregion

#region Day 4

var d04Star1 = Stars.Day04.Day04.CountXMAS(Stars.Day04.Day04.GetFilePath(Stars.Day04.Day04.FileType.ChallengeData));
var d04Star2 = Stars.Day04.Day04.CountX_MAS(Stars.Day04.Day04.GetFilePath(Stars.Day04.Day04.FileType.ChallengeData));

Console.WriteLine("Day 4");
Console.WriteLine($" Star 1 - Count XMAS = {d04Star1}");
Console.WriteLine($" Star 2 - Count X_MAS = {d04Star2}");
Console.WriteLine("-----------------------------");

#endregion

