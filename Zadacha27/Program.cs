//Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.


void zadacha27 ()
{
     Console.WriteLine ("Введите число и нажмите 'Enter' ");
    int numb = Convert.ToInt32(Console.ReadLine());

     int sum = 0;
     Console.Write("Сумма цифр числа " + numb);
    while (numb > 0)
    {
        sum += numb%10;
        numb /=10;
    }
    Console.WriteLine(" равна " + sum);
}
zadacha27 ();