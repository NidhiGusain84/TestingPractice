using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordVerifierKata
{
    public static class PasswordVerifier
    {
       public static bool CheckLength(string input)
        {
            if (input.Length <= 8)
            {
                Console.WriteLine("Password should be larger than 8 chars.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckNullOrEmpty(string input)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Password can not be empty");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckLower(string input)
        {
            if (!input.Any(char.IsLower))
            {
                Console.WriteLine("Password should have one lowercase letter at least.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckUpper(string input)
        {
            if (!input.Any(char.IsUpper))
            {
                Console.WriteLine("Password should have one uppercase letter at least.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckNumber(string input)
        {
            if (!input.Any(char.IsDigit))
            {
                Console.WriteLine("Password should have one number at least.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool PasswordOk(string input)
        {
            int validCondition = 0;
            
            if(CheckLength(input))
            {
                validCondition++;
            }
            if (CheckNullOrEmpty(input))
            {
                validCondition++;
            }
            if (CheckLower(input))
            {
                validCondition++;
            }
            if (CheckUpper(input))
            {
                validCondition++;
            }
            if (CheckNumber(input))
            {
                validCondition++;
            }
            if (validCondition >= 3 && input.Any(char.IsLower) == true)
            {
                Console.WriteLine("Password is good.");
                return true;
            }
            else
            {
                Console.WriteLine("Password is not ok.");
                return false;
            }
        }


        //public static bool Verify(string input)
        //{
        //    int validCondition = 0;           
            
        //    if (input.Length <= 8)
        //    {                
        //        throw new Exception("Password should be larger than 8 chars.");                              
        //    }
        //    else
        //    {                
        //        validCondition++;
        //    }

        //    if (string.IsNullOrEmpty(input))
        //    {               
        //        throw new Exception("Password can not be empty.");
        //    }
        //    else
        //    {                
        //        validCondition++;
        //    }

        //    if (!input.Any(char.IsUpper))
        //    {                
        //        throw new Exception("Password should have one uppercase letter at least.");
        //    }
        //    else
        //    {
        //        validCondition++;
        //    }

        //    if (!input.Any(char.IsLower))
        //    {
        //        throw new Exception("Password should have one lowercase letter at least.");                
        //    }
        //    else
        //    {
        //        validCondition++;
        //    }

        //    if (!input.Any(char.IsDigit))
        //    {
        //        throw new Exception("Password should have one number at least.");
        //    }
        //    else
        //    {
        //        validCondition++;
        //    }

        //    if (validCondition >= 3 && input.Any(char.IsLower) == true)
        //    {               
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }           
           
        //}




    }
}
