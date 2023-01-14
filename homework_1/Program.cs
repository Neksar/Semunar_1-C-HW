// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: "); //Вводим первое число
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: "); // Вводим второе число
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2){ // Если первое число больше второго
    Console.WriteLine($"Большее число: {number_1}");
    System.Console.WriteLine($"Меньшее число: {number_2}");
}
else if (number_1 == number_2){ // Если числа равны
    System.Console.WriteLine("Введенные числа между собой равны!");
}
else{ // Если второе число больше первого
    System.Console.WriteLine($"Большее число: {number_2}");
    System.Console.WriteLine($"Меньшее число: {number_1}");
}