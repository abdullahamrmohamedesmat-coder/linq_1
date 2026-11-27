using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Advanced03
{
    internal class Helper
    {
        public static void PrintCollection<T>(string nameOfCollection,IEnumerable<T> Collection)
        {

            Console.WriteLine($" {nameOfCollection}:{string.Join(',',Collection)}");
        }

    }
}
