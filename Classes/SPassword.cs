using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.Classes
{
    internal class SPassword
    {
        public static void Create()
        {
            Console.WriteLine("Enter the lengh of your password : ");
            try
            {
                var lenghpassword = Convert.ToInt32(Console.ReadLine());
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

                while (count < lenghpassword)
                {
                    count++;
                    password += mainlist[random.Next(mainlist.Count)];

                }
                Console.BackgroundColor = ConsoleColor.Green; 
                Console.WriteLine(password);
                Console.ResetColor();
            }
            catch(Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red; 
                Console.WriteLine(e.Message);

            }


            Console.ReadKey();
            }
        }
    
}
