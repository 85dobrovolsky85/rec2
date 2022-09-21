using System;
 
string[] array =
{
 "hello", "2", "world", ":-)",
 "1234", "1567", "2", "computer science",
 "Russia", "Denmark", "Kazan"
};
 
var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
 if (value.Length <= 3)
 {
 result[realSize] = value;
 realSize++;
 }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));