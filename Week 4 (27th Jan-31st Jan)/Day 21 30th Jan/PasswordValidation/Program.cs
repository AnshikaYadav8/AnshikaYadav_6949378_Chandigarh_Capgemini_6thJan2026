namespace PasswordValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string pwd = Console.ReadLine();

            if (pwd.Length < 8 ||
                char.IsDigit(pwd[0]) ||
                !char.IsLetterOrDigit(pwd[pwd.Length - 1]) ||
                !pwd.Any(c => "@#_".Contains(c)) ||
                !pwd.Any(char.IsLetter) ||
                !pwd.Any(char.IsDigit))
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
