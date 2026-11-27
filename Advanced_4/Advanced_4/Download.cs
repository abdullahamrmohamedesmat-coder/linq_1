using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_4
{
    internal class Download
    {
        public static async Task<string> DownloadFileAsync(string url, CancellationToken ct)
        {
            for (int i = 0; i <= 100; i += 20)
            {
                ct.ThrowIfCancellationRequested();
                Console.WriteLine($"Downloading{i}%");
                await Task.Delay(500);

            }
            return $"Downloaded {url}";
        }

        public static async Task<string> DownloadWithTimeout(string url, int delayMS)
        { 
           CancellationTokenSource ct = new CancellationTokenSource(delayMS);
            try
            {
                return await DownloadFileAsync(url, ct.Token);

            }
            catch
            {
                return "Timeut";
            }

        
        
        
        }
    }
}
