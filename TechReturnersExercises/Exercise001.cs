using System;
using System.Collections.Generic;


namespace TechReturners.Exercises
{
    public class Exercise001
    {
        public static string CapitalizeWord(string word)
        {
            if (word.Length == 0)
            {
                return "";
            }
            
            return word.Substring(0,1).ToUpper()+word.Substring(1);
        }

        public static string GenerateInitials(string firstName, string lastName)
        {

            if (firstName.Length == 0 || lastName.Length == 0)
            {
                return "";
            } 
            
            string firstInitial = firstName[0]+".";
            char secondInitial = lastName[0];
            
            
            return firstInitial + secondInitial;
        }

        public static double AddVat(double originalPrice, double vatRate) 
        {
            throw new NotImplementedException();
        }

        public static String Reverse(String sentence) 
        {
            // Add your code here!
            throw new NotImplementedException();
        }

        public static int CountLinuxUsers(List<User> users) 
        {
            // Add your code here!
            throw new NotImplementedException();
        }
    }
}
