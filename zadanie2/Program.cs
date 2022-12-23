//Написать программу, которая на вход принимает 2 числа и выдает, какое из них больше
int a = -9,b=-3;
int max=a;
if (a>b) max=a;
if (b>max) max=b;

Console.Write("max=");
Console.WriteLine(max);