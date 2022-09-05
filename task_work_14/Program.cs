// Напишите программу, которая принимает на вход число и проверает, 
// кратно ли оно одновременно 7 и 23

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 & number % 23 == 0){
    Console.Write($"Число {number} ДЕЛИТСЯ одновременно на 7 и 23 ");
}
else{
    Console.Write($"Число {number} НЕ ДЕЛИТСЯ одновременно на 7 и 23 ");
}