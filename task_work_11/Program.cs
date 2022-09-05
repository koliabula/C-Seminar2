// Напишите программу, которая выводит случайное трёхзначное число и 
// удаляет вторую цифру этого числа

Console.Write("Трёхзначное число: ");
int number = new Random().Next(100, 1000);
Console.WriteLine( number);
Console.Write("Удаляем вторую цифру: ");
int number2 = number/100*10+number%10;
Console.Write(number2);
