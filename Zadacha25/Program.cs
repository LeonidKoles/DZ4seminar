//Задача 25: Используя определение степени числа, напишите цикл,
//который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
void zadacha25 ()
{
    Console.WriteLine ("Введите число а и нажмите 'Enter' ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите число b и нажмите 'Enter'");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = a;

    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}
 zadacha25 ();