using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ1
{
    public class SSource
    {




        public static List<string> Customers = new()
        {
            "أحمد محمد",
            "سارة محمود",
            "كريم علي",
            "منى حسن"
          };
        public static List<Products> Product = new() { new Products { Id = 1, Name = "لابتوب ديل", Price = 28500m, UnitStock = 12 },
            new Products{ Id = 2, Name = "موبايل سامسونج", Price = 15200m, UnitStock = 25 },
            new Products { Id = 3, Name = "سماعة بلوتوث", Price = 1150m, UnitStock = 40 },
            new Products { Id = 4, Name = "شاشة 24 بوصة", Price = 6400m, UnitStock = 8 }
        };



    }
}

