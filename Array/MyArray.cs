namespace Data_Structures.Array
{
    public class MyArray
    {
        public MyArray()
        {
            int[] arr;
            arr = new int[5];
            arr[0] = 5;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}