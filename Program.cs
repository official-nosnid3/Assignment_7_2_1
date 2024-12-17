namespace Assignment_7_2_1
{
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 11, 21, 13, 14, 78, 54 };

            PrintArray(ints, "ints: ");
            ShellSortInts(ints);
            PrintArray(ints, "\n\nShell sorted ints: ");

            Console.WriteLine();
        }

        static void ShellSortInts(int[] Ints_)
        {
            int n = Ints_.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int j = i;
                    int temp = Ints_[i];

                    while (j >= gap && Ints_[j - gap] > temp)
                    {
                        Ints_[j] = Ints_[j - gap];
                        j -= gap;
                    }

                    Ints_[j] = temp;
                }
            }
        }

        static void PrintArray(int[] Ints_, string text)
        {
            Console.Write(text);
            for (int i = 0; i < Ints_.Length; i++)
                Console.Write($"{Ints_[i]} ");
        }
    }
}
