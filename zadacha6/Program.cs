//Написать прогрмму, которая на вход принимает число и выдает, является ли число "четным" или "Нечетным" 
// Четное - делится на 2 без остатка
    int num1, rez1;
  
    Console.Write("Введите число : ");
    num1= Convert.ToInt32(Console.ReadLine()); 
    rez1 = num1 % 2;
    if (rez1 == 0)
 Console.WriteLine("{0} это четное число\n",num1);
    else
 Console.WriteLine("{0} это нечетное число\n",num1);

