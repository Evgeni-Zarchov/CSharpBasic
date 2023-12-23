namespace _04_PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have to write a program to login with the given password s3cr3t!P@ssw0rd and to show Welcome
            // if the password doesnt match the given password Wrong password!

            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
