﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo"); //() []
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To be or not to be");
            hash.frequencyOfWords("0");
        }
    }
}
