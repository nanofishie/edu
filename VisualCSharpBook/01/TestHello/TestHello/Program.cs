using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("{0}Hello World!{0}{0}Please enter your name:  ",System.Environment.NewLine);
            string userName = Console.ReadLine();
            DateTime dt = System.DateTime.Today;
            Console.WriteLine(String.Format("{2}Hello, {0}! Today is {1:MM/dd/yyyy}.{2}{2}Press enter to exit", userName, dt.Date, System.Environment.NewLine));
            Console.ReadLine();
        }
    }
}
