using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_4
{
    internal class TaskExamples
    {
        public Task DoWorkAsync()
        {
            return Task.Delay(1000);
        }

        public Task<int> CalculateAsync(int x, int y)
        {
            return Task.FromResult(x+y);
        }

        Dictionary<int, string> students = new Dictionary<int, string>()
       {
           {101,"Yahia" },
           {102,"Ahmed" },
           {103,"Hamza" }
       };

       public ValueTask<string> GetCashedValue(int id)
       {
            if(students.TryGetValue(id,out string name))
            {
                return new ValueTask<string>(name);
            }
            return new ValueTask<string>(GetNameFromSource(id));

       }
        public async Task<string> GetNameFromSource(int id)
        {
            await Task.Delay(500);
            return $"Name Of Id :{id}";

        }

    }
}
