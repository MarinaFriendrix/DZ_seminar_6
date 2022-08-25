// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Console.Write("Введите числа через пробел: ");
// string[] st = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

// Console.WriteLine($"[{String.Join(", ", st)}]");

//  int[] array = Array.ConvertAll(st, s => int.Parse(s));
//  Console.WriteLine($"[{String.Join(", ", array)}]");

// int count = 0;
// for (int i =0; i <array.Length; i++)
// {
    
//     if (array [i] > 0)
//     {
//         count = count + 1;
        
//     }
    
// }
// Console.Write(count);


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Console.Write("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());

// //Главный опеределитель

// double determ = k2 - k1;
// if (determ != 0)
// {
//     double x = (b1 - b2)/(k2 - k1);
//     double y = (k2*b1 - k1*b2)/ (k2 - k1);

//     Console.WriteLine(Math.Round(x, 2));
//     Console.WriteLine(Math.Round(y, 2));
// }
// else
// {
//     Console.WriteLine("Прямыe параллельны или совпадают");
// }