// Напишите программу, которая Принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Какую задачу хотите решить? ");
Console.WriteLine("1 - Программа, которая Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа ");
Console.WriteLine("2 - Программа, которая выводит третью цифру заданного числа или сообщает что третей цифры нет");
Console.WriteLine("3 - Программа, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день - выходным");

Console.WriteLine("Введите номер задачи, которую хотите решить: 1, 2 или 3.");
int i = Convert.ToInt32(Console.ReadLine());
if (i > 0 & i < 4){
    if ( i == 1 ){// Напишите программу, которая Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
        Console.Write("Введите трёхзначное число: ");      
        int number = Convert.ToInt32(Console.ReadLine());
        if( (number > 99 & number < 1000) || (number < -99 & number > -1000)  ){

            Console.Write("Оставляем вторую цифру: " + number/10%10);
        }
        else Console.Write("Ввели не Трёхзначное число ");
    }

    if ( i == 2){ //Напишите программу, которая выводит третью цифру заданного числа или сообщает что третей цифры нет
    
        int SizeArray (int num)
        {
            int i = 0;
            while( num != 0 ) {
                    num = num / 10;
                    i++;
                }

            return i;
        }
        int Serch3Number (int num)
        {
            int[] array = new int [SizeArray (num)];
            int chet = num;
            int i = 0;
            while( chet != 0 ) {
                array[i] = chet % 10;
                chet = chet / 10;
                i += 1;
            }
            return array[i-3];
        }
        
        Console.Write("Введите число: ");      
        int number = Convert.ToInt32(Console.ReadLine());

        if(number / 100 == 0 ){
            Console.WriteLine("Третьей цифры нет :(");  
        }
        else {
            Console.WriteLine($" Цифра, стоящая на третьей позиции - {Serch3Number (number)}");     //выводим цифру стоящую на третьей позиции
        }

    }

    if ( i == 3){//Программа, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день - выходным"
        Console.Write("Введите номер дня недели: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0 & number < 8){
            if(number == 6 || number == 7){
                Console.WriteLine("УРА!!! Это выходной");
            }
            else {
                Console.WriteLine("Этот день не является выходным");
            }
        }
        else{
            Console.WriteLine("Введите цифру от 1 до 7");
        }
    }
}
else {
    Console.WriteLine("нужно ввести номер задачи от 1 до 3.");
}