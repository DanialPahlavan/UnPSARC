﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace UnPSARC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uncharted 4 PC Extractor");
            Console.WriteLine("By NoobInCoding");
            if (args.Length < 1)
            {
                Console.WriteLine("Usage:");
                Console.WriteLine("Unpsarc.exe <psarc path> [destination folder]");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Exporting...");
                string folder = Path.GetDirectoryName(args[0]);
                if(args.Length >= 2) folder = args[1];
                Stream R = File.OpenRead(args[0]);
                Archive.Unpack(R, folder);
                R.Close();
            }

            
        }
    }
}
