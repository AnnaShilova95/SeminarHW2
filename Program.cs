// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondNum (){
    int num = new Random().Next(100,1000);
    Console.WriteLine("Наше число - " + num);
    int snum = num/10;
    int result = snum %10;
    Console.WriteLine("Ответик: " + result);
}

SecondNum();

