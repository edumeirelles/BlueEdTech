using System;
using System.Linq;

Random r = new Random();
var array = new int[4][];
array[0] = new int[1] { r.Next(1, 9) };
array[1] = new int[2] { r.Next(1, 9), r.Next(1, 9) };
array[2] = new int[3] { r.Next(1, 9), r.Next(1, 9), r.Next(1, 9) };
array[3] = new int[4] { r.Next(1, 9), r.Next(1, 9), r.Next(1, 9), r.Next(1, 9) };


var result = array[0][0] + array[1].Max() + Math.Max(array[2][array[1].ToList().IndexOf(array[1].Max())], array[2][array[1].ToList().IndexOf(array[1].Max()) + 1]) 
    + Math.Max(array[3][array[2].ToList().IndexOf(Math.Max(array[2][array[1].ToList().IndexOf(array[1].Max())], array[2][array[1].ToList().IndexOf(array[1].Max()) + 1]))], 
    array[3][array[2].ToList().IndexOf(Math.Max(array[2][array[1].ToList().IndexOf(array[1].Max())], array[2][array[1].ToList().IndexOf(array[1].Max()) + 1])) + 1]);


Console.WriteLine($"{array[0][0]}");
Console.WriteLine($"{array[1][0]}, {array[1][1]}");
Console.WriteLine($"{array[2][0]}, {array[2][1]}, {array[2][2]}");
Console.WriteLine($"{array[3][0]}, {array[3][1]}, {array[3][2]}, {array[3][3]}");



Console.WriteLine(result);



