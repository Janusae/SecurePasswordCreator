using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Classes
{
    internal class SPassword
    {
        public static void Create(int Number)
        {
            var count = 0;
            var password = string.Empty;
            Random random = new Random();
            List<object> mainlist = new List<object>
        {
            "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+",
            "-", "=", "{", "}", "[", "]", "|", ":", ";", "'", "\"",
            "<", ">", ",", ".", "?", "/"
        };
            for (int i = 0; i < 10; i++)
            {
                mainlist.Add(i.ToString());
            }
            for (char c = 'a'; c <= 'z'; c++)
            {
                mainlist.Add(c.ToString());
            }
            for (char a = 'A'; a <= 'Z'; a++)
            {
                mainlist.Add(a.ToString());
            }

            while (count < Number)
            {
                count++;
                password += mainlist[random.Next(mainlist.Count)];

            }
            Console.WriteLine(password);

        }
    }
}
