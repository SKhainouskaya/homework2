// Напишите программу, которая принимает на//
//вход цифру, обозначающую день недели, и проверяет,///
//является ли этот день выходным.///

Console.WriteLine ("введите число " );
int n = int.Parse(Console.ReadLine());
if (n==1 || n==2 ||n==3 || n==4 || n==5)
{
    Console.WriteLine ("будний день");
}
else if (n==6 || n==7)
{
    Console.WriteLine ("выходной день");
}
else if (n<1 || n>7)
{
  Console.WriteLine ("ошибка");  
}

//Напишите программу, которая принимает на
///вход трёхзначное число и на выходе показывает вторую
///цифру этого числа.///

int n = new Random().Next(99, 1000);
int C1 = (n%100)/10;
Console.WriteLine(n);
Console.WriteLine(C1);
