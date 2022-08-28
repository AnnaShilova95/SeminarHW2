/*
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Задаем метод и ищем вторую цифру введеного числа

void SecondNum (int num){
    int snum = num/10;
    int result = snum %10;
    Console.WriteLine("Ответик: " + result);
}

// Пользовательский ввод данных
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

// Вызов метода
SecondNum(num);


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Задаем метод
void ThirdNum(int num){
 // Проверяем, есть ли в числе третья цифра

    if (num/100 == 0){
    Console.WriteLine("Третьей цифры нет");
    }
    // Ищем третью цифру
    else{
        int result = num %10;
        Console.WriteLine("Результат - " + result);
    }
}
// Пользовательский ввод
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
// Вызов метода
ThirdNum(num);


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Задаем метод
int Day(int num){
    if (num >= 1 && num <= 7){
        return num;
    }
        else{
            Console.WriteLine("Цифра не соответсвует дню недели, введите цифру от 1 до 7");
            return 0;
            }
    }
// Пользовательский ввод данных

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
// Вызов метода
int number = Day(num);

// Определяем вид дня
if  (number >= 6 && number !=0){
Console.WriteLine("Можно отдохнуть");
}
else if (number <6 && number !=0 ){
    Console.WriteLine("Иди работать");
}


*/






