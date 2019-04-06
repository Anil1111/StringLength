using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
             string str = "HelloWorld";
                // char ch;
                int i = 0;

                foreach (char ch in str)
                {
                    i = i + 1;

                }
                Console.WriteLine("String Length   is  " + i.ToString());
            }
        }
    }

