namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[6];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            string value = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(value) || !int.TryParse(value, out numbers[i]))
            {
                Console.WriteLine("Некорректное значение");
                value = Console.ReadLine();
            }
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("После сортировки:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}
