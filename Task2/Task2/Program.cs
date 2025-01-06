namespace Task2;

internal class Program
{
    static void Main(string[] args)
    {
        int[,] numbers = new int[3, 3]
        {
            {1, 4, 7},
            {2, 5, 8},
            {3, 6, 9}
        };

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int max = numbers[i, 0];
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[i, j] > max)
                {
                    max = numbers[i, j]; 
                }
            }
            Console.WriteLine($"Максимальный элемент в строке {i + 1}: {max}");
        }
    }
}
