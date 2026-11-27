using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Advanced_4
{
    internal class AsyncDataService
    {
        public async Task<string> DataFromDataBaseAsync()
        {
            Console.WriteLine($"{Environment.CurrentManagedThreadId} Fetching data from DataBase");
            await Task.Delay(1000); 
            Console.WriteLine($"{Environment.CurrentManagedThreadId} Fetching data from DataBase");
            return "Data from DataBase";
            
        }

        public async Task<string> DataFromApiAsync()
        {
            Console.WriteLine($"{Environment.CurrentManagedThreadId} Fetching data from Api");
           await Task.Delay(2000);
            Console.WriteLine($"{Environment.CurrentManagedThreadId} Fetching data from Api");
            return "Data from Api";
            
        }

        public async Task<string> DataFromFileAsync()
        { 
            Console.WriteLine($"{Environment.CurrentManagedThreadId} Fetching data from File");
            await Task.Delay(2000);
            Console.WriteLine($"{Environment.CurrentManagedThreadId} Fetching data from File");
            return "Data from File";
            
        }
        public async Task<string> DownloadFile(string fileName,int delayms)
        {
            Console.WriteLine($"{ Environment.CurrentManagedThreadId} Downloading File" );
            await Task.Delay(delayms);
            return $"{fileName} Downloaded Successfuly";
        }

        
    }
}
