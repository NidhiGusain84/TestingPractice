
using System;
using System.Linq;

namespace PasswordVerifierKata
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();


            PasswordVerifier.PasswordOk(password);

        }
    }
}
