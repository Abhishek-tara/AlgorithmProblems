namespace AlgorithmProblems
{
    class Porgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Function to Sort the array of string using Onserrtion sort..\n");

            string[] arr = { "Abhi", "am", "I" };
            int n = arr.Length;

            InsertionSort array = new InsertionSort();
            array.sort(arr, n);
            array.printArraystring(arr, n);
        }
    }
}