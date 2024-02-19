namespace modules_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = InputArray();
            ShowArray(arr, true);
        }

        static int[] InputArray()
        {
            int[] tempArray = new int[10];
            for (int i = 0; i < tempArray.Length; i++) 
            {
                Console.WriteLine($"Введите элемент массива с индексом {i}");
                tempArray[i]= Convert.ToInt32( Console.ReadLine());
            }
            return tempArray;
        }
        static int[] SortArray(int[]array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }

                }
            }
            return array;
        }
        static void ShowArray(int[] array, bool Sorting = false)
        {
            if (Sorting == true)
            {
                array = SortArray(array);
              
            }

            for (int i = 0;i < array.Length;i++)
            {
                Console.Write(array[i]+" ");

            }
        }
    }
}
