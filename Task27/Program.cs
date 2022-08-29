/*
Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());

  int SumNum(int numA)
  {
    
    int count = Convert.ToString(numA).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = numA - numA % 10;
      result = result + (numA - advance);
      numA = numA / 10;
    }
   return result;
  }

int sumNum = SumNum(numA);
Console.WriteLine("Сумма цифр: " + sumNum);