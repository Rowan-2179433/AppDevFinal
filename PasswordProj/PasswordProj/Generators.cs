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
            string password = "";

            if (numbers && specialCharacters)
            {

            }
            else if(specialCharacters && !numbers)
            {

            }
            else if (!specialCharacters && numbers)
            {

            } else { 
            }


            updateFile();

            return "Functional"; 
        }

        public static void updateFile()
        {
            



        }



    }
}
