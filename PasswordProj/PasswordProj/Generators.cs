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

            return passwordBuilder.ToString();
        }
        public string CheckPasswordStrength(string password)
        {
            int score = 0;

            if (password.Length < 8)
                return "Weak"; // Too short
            else
                score++;

            if (password.Any(char.IsUpper)) //if there's at least one uppercase letter
                score++;

            if (password.Any(char.IsLower)) //if there's at least one lowercase letter
                score++;

            if (password.Any(char.IsDigit)) //if there's at least one digit
                score++;

            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    score++;
                    break; //exit the loop as soon as a non-letter, non-digit character is found.
                }
            }

            if (score == 5 || score == 4)
            {
                return "Strong";
            }
            else if (score == 3)
            {
                return "Moderate";
            }
            else
            {
                return "Weak";
            }

        }
    }
}
    
