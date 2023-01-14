// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: "); //Вводим первое число
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: "); // Вводим второе число
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: "); // Вводим третье число
int num_3 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2 && num_1 > num_3){ // Если первое число больше второго и третьего
    Console.WriteLine($"Максимальное число: {num_1}");
}
else if (num_2 > num_1 && num_2 > num_3){ // Если второе число больше первого и третьего
    Console.WriteLine($"Максимальное число: {num_2}");
}
else if (num_3 > num_1 && num_3 > num_2){ // Если третье число больше первого и второго
    Console.WriteLine($"Максимальное число: {num_3}");
}
else { // Если числа равны
   System.Console.WriteLine("Введенные числа между собой равны!");
}