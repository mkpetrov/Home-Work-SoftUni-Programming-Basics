﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_is_the_password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string b = "s3cr3t!P@ssw0rd";
            if (password==b)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
