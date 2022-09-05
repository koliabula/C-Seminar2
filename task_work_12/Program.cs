// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// и выводит остаток от деления


Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0){
    Console.Write($"Число {number2} кратно числу {number1} ");
}
else{
    Console.Write($"Число {number2} НЕ кратно числу {number1}; остаток {number1 % number2}");
}
