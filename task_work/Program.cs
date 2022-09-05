// Напишите программу, которая принимает на вход 2 часла и проверяет,
// является ли одно число квадратом другого


Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2){
    Console.Write($"Число {number2} - квадрат числа {number1} ");
}

else if(number2 * number2 == number1){
    Console.Write($"Число {number1} - квадрат числа {number2} ");
}

else Console.Write("НОУ");