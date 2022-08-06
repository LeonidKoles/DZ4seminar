//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
//и выводит отсортированный по модулю массив.
void zadacha29 ()
{
    int size = 8;
    int [] array = new int[size];

    Random randome = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = randome.Next(-10 , 10);
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
     for (int i = array.Length - 1; i > 0; i--)
    {
         for (int j = 0; j < i; j++)
        {
            if (Math.Abs(array [j]) > Math.Abs(array[j+1]))
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
     for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();


}
zadacha29 ();