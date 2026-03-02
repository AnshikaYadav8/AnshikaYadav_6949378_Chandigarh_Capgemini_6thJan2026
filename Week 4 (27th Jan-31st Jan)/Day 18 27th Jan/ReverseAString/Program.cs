namespace ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            char[] arr = input.ToCharArray();
            int i = 0, j = input.Length-1;
            while (i < j)
            {
                char temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            arr.ToString();
            Console.WriteLine(arr);
        }
    }
}
