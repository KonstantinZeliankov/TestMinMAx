namespace TestMinMAx
{
    internal class Program
    {
            static void PrintArrayToConsole(int[] array)
            {
                foreach (int element in array)
                {
                    Console.WriteLine(element);
                }
            }
            static void Main(string[] args)

            {
                int[] arraymaxmin = { 6, -5, 0, 9, 66, -86, 798, 6, 11, 10 };
                int max_value_index = 0;
                int min_value_index = 0;

                for (int i = 0; i < arraymaxmin.Length; i++)
                {
                    int value = arraymaxmin[i];
                    if (value < arraymaxmin[min_value_index]) { min_value_index = i; }
                    if (value > arraymaxmin[max_value_index]) { max_value_index = i; }

                }

                int temporary_value = arraymaxmin[min_value_index];
                arraymaxmin[min_value_index] = arraymaxmin[max_value_index];
                arraymaxmin[max_value_index] = temporary_value;

                PrintArrayToConsole(arraymaxmin);

            }
    }
}
