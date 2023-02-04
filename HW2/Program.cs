// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// -----------------------------------------------------------------
// int ReturnSecond(int number)
// {
//     int EdRem = number / 10;
//     int SecNum = EdRem % 10;
//     return SecNum;
// }
// Console.Write("Input 3-digit number: ");
// int ResNum = ReturnSecond(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine($"2nd digit of your number is {ResNum}");
//
// -----------------------------------------------------------------
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
// -----------------------------------------------------------------
// int ThirdDigit(int num)
// {
//     int result = -1;
//     if (num >= 100)
//     {
//         string numText = Convert.ToString(num);
//         string SemiResult = Convert.ToString(numText[2]);
//         result = Convert.ToInt32(SemiResult);
//     }
//     return result;
// }

// Console.Write("Input your number: ");
// int ResNum = ThirdDigit(Convert.ToInt32(Console.ReadLine()));
// Console.WriteLine($"Third digit of your number is {ResNum}");

// -------------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// -------------------------------------------------------------------------
// void DayOfTheWeekChecking (int dayNumber) 
// {
//   if (dayNumber == 6 || dayNumber == 7) 
//   {
//   Console.WriteLine("That's a weekend, my friend");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) 
//   {
//     Console.WriteLine("It's not a number of a day in a week");
//   }
//   else if (dayNumber == 3)
//   {
//     Console.WriteLine("It's Wednesday, my dudes");
//   }
//   else 
//   Console.WriteLine("Sad, but it's a weekday :(");
// }

// Console.Write("Input number of the day in week: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// DayOfTheWeekChecking(dayNumber);
// **********************************************
// Надеюсь, пасхалка будет узнана))
// **********************************************