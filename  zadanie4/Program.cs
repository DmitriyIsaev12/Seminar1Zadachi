//Написать программу, которая на вход принимает 3 числа и выдает, какое из них больше
int a = 44,b=100, c=78;
int max=a;
if (a>b) max=a;
if (b>max) max=b;
if (c>max) max=c;

Console.Write("max=");
Console.WriteLine(max);