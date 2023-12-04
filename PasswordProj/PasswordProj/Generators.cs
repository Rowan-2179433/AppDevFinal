using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordProj
{
    internal class Generators
    {
        //TODO:
        //Come up with serilization method 
        //Make password generator 

        public string generatePassword(int length, bool numbers, bool specialCharacters)
        {
            const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbersChars = "0123456789";
            const string specialChars = "!@#$%^&*()_+[]{}|;:,.<>?";

            string allChars = lowercaseLetters + uppercaseLetters;
            if (numbers)
            {
                allChars += numbersChars;
            }
            if (specialCharacters)
            {
                allChars += specialChars;
            }

            if (allChars.Length == 0)
            {
                // No character set selected
                return "No character set selected";
            }

            Random random = new Random();
            StringBuilder passwordBuilder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, allChars.Length);
                passwordBuilder.Append(allChars[randomIndex]);
            }

            updateFile(); // You can call this function here if needed.

            return passwordBuilder.ToString();
        }


        public static void updateFile()
        {
            



        }



    }
}
