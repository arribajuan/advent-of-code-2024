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