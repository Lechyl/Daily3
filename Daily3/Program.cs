using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Daily3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "92118532132159";
            for(int i = 0; i<Text.Length; i++)
            {
                try { 
                if (Text[i] == '9' && Text[i + 1] == '2')
                {
                    WriteLine(" 92:2 92:2");
                }
                else if (Text[i] == '3' && Text[i + 1] == '2' && Text[i + 2] == '1')
                {
                    WriteLine(" 321:2 321:2");
                }
                else if (Text[i] == '9' && Text[i + 1] == '9' && Text[i + 2] == '9')
                {
                    WriteLine(" 999:3 999:3 999:3");
                }
                else if (Text[i] == '5')
                {
                    WriteLine(" 5:1");
                }
                else if (Text[i] == '5' && Text[i + 1] == '9')
                {
                    WriteLine(" 59:2 59:2");
                }
                }
                catch
                {

                }
            }
            ReadLine();
        }
    }
}
