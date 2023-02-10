// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//-------------------------------------------------------------------------------------------------------------
// Console.Write("Input a 5-digit number: ");
// string number = Console.ReadLine();
// void PalindromeCheck(string number)
// {
//     if (number[0] == number[4] & number[1] == number[3])
//     {
//     Console.WriteLine($"Your number: {number} is a palinrome");
//     }

//     else Console.WriteLine($"Your number: {number} is not a palindrome");

// }

// if (number.Length == 5)
// {
//   PalindromeCheck(number);
// }
// else Console.WriteLine("Please input correct number");
//-------------------------------------------------------------------------------------------------------------
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//-------------------------------------------------------------------------------------------------------------

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Input coordinate {coorName} of a point {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");


// double Distance(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double DistanceLength =  Math.Round (Distance(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Distance between the points is {DistanceLength}");
//---------------------------------------------------------------------------------------------------------
//Задача 23  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//----------------------------------------------------------------------------------------------------------
// void CubicTablet (int Num)
// {
//     for (int i = 1; i <= Num; i++)
//     {
//         Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
//     }
// }
// Console.Write("Input your number to get the tablet of all number until yours cubed: ");
// CubicTablet(Convert.ToInt16(Console.ReadLine()));
