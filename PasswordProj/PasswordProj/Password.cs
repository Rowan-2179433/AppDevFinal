using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProj
{
    internal class Password
    {
        private string id; 
        private string text;
        
        public Password(string id, string text)
        {
            this.id = id; 
            this.text = text;
        }

        public string Id      {
            get { return id; }
            set { id = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
}
