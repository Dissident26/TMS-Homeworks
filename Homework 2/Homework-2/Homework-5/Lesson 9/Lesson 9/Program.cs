using Lesson_9;

var matrix = new DIagonalMatrix(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, });
var matrix2 = new DIagonalMatrix(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, });

Console.WriteLine(matrix.ToString());
Console.WriteLine("Is equal: {0}", matrix.Equals(matrix2));