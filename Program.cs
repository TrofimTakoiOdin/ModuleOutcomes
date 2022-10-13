internal class Program
{
    private static void Main(string[] args)
    {
        string[] firstArray = new string[5] { "1212123", "233", ":')", "wOrlD", "Oops" };
        string[] secondArray = new string[firstArray.Length];
        ResultArray(firstArray, secondArray);
        PrintArray(secondArray);
    }
    static void ResultArray(string[] arrayFirst, string[] array2)
        {
            int index = 0;
            for (int i = 0; i < arrayFirst.Length; i++)
            {
                if (arrayFirst[i].Length <= 3)
                {
                    array2[index] = arrayFirst[i];
                    index++;
                }
            }
        }
    static void PrintArray(string[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

}