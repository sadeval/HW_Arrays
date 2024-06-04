namespace HW_Arrays
{
    internal class Zmeyka
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[size, size];
            int value = 1;

            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0) 
                {
                    for (int j = 0; j < size; j++)
                    {
                        array[i, j] = value++;
                    }
                }
                else 
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        array[i, j] = value++;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0, 4}", array[i, j]);
                }
                Console.WriteLine();
            }
        }
  
    }
}
