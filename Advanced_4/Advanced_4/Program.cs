using System.Diagnostics;

namespace Advanced_4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region Async
            //AsyncDataService asyncDataService = new AsyncDataService();
            //var sw=Stopwatch.StartNew();
            //string result01 = await asyncDataService.DataFromDataBaseAsync();

            //string result02 = await asyncDataService.DataFromApiAsync();

            //string result03 = await asyncDataService.DataFromApiAsync();



            //sw.Stop();
            //Console.WriteLine($"Total Time: {sw.ElapsedMilliseconds} ms");
            //Console.Write("Results");
            //Console.WriteLine("--------------");
            //Console.WriteLine($"Result 01: {result01}");
            //Console.WriteLine($"Result 02: {result02}");
            //Console.WriteLine($"Result 03: {result03}");

            //AsyncDataService asyncDataService = new AsyncDataService();
            //var sw = Stopwatch.StartNew();
            //var task01 =  asyncDataService.DataFromDataBaseAsync();

            //var task02 =  asyncDataService.DataFromApiAsync();

            //var task03 = asyncDataService.DataFromApiAsync();

            // string[] results =await Task.WhenAll(task01, task02, task03);

            //sw.Stop();
            //Console.WriteLine($"Total Time: {sw.ElapsedMilliseconds} ms");
            //Console.Write("Results");
            //Console.WriteLine("--------------");
            //Console.WriteLine($"Result 01: {results[0]}");
            //Console.WriteLine($"Result 02: {results[1]}");
            //Console.WriteLine($"Result 03: {results[2]}");
            #endregion
            #region Task

            //TaskExamples taskExamples = new TaskExamples();
            //Console.WriteLine("Hello");
            //await  taskExamples.DoWorkAsync();

            //int sum=await taskExamples.CalculateAsync(4, 5);
            //Console.WriteLine($"sum:{sum}");

            //string name=await taskExamples.GetCashedValue(103);
            //Console.WriteLine($"Name:{name}");

            //name = await taskExamples.GetCashedValue(104);
            ////Console.WriteLine($"Name{name}");
            ////Console.WriteLine("------------Results------------");
            ////Console.WriteLine($"sum:{sum}");
            ////Console.WriteLine($"Name{name}");

            //Task<int> task = Task.Run(async () =>
            //{
            //    await Task.Delay(500);
            //    return 7;
            //});

            //Console.WriteLine(task.Status);
            //await task;
            //Console.WriteLine(task.Status);
            //Console.WriteLine(task.IsCompleted);
            //Console.WriteLine(task.IsCompletedSuccessfully);
            //Console.WriteLine(task.Result);

            #endregion
            #region await
            //Console.WriteLine(Environment.CurrentManagedThreadId);
            //var result = await GreetingAsync("Yahia");
            //Console.WriteLine(Environment.CurrentManagedThreadId);

            //Console.WriteLine(result);

            //Console.WriteLine(result.IsCompleted); 
            #endregion

            #region WhenAll&WhenAny
            //  AsyncDataService service = new AsyncDataService();
            //  var task01=service.DownloadFile("fast.com", 1000);
            //  var task02 = service.DownloadFile("medium.com", 1500);
            //  var task03 = service.DownloadFile("slow.com", 2000);

            ////var winner=await Task.WhenAny(task01,task02,task03);
            ////  Console.WriteLine(winner.Result);

            //  var largefile=service.DownloadFile("LargeFile", 1000);
            //  var timeout = Task.Delay(2000);

            //  var winner = await Task.WhenAny(largefile, timeout);
            //  if(winner== timeout)
            //  {
            //      Console.WriteLine("Request Timedout ");
            //  }
            //  else
            //  {
            //      Console.WriteLine(largefile.Result);
            //  } 
            #endregion
            //var task =  ThrowAsync();
            //try
            //{
            //    await task;
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            //var task = ThrowAsync();
            //try
            //{
            //    await task;
            //}
            //catch
            //{
            //    Console.WriteLine(task.IsFaulted);
            //    Console.WriteLine(task.Exception?.InnerException?.Message);
            //}

            //var task01 = Task.Run(() => throw new InvalidOperationException());
            //var task02 = Task.Run(() => throw new NullReferenceException());

            //var task = Task.WhenAll(task01, task02);

            //try
            //{
            //    await task;
            //}
            //catch
            //{
            //    Console.WriteLine(task.IsFaulted);
            //    Console.WriteLine(task.Exception?.InnerException?.Message);
            //    foreach(var ex in task.Exception.InnerExceptions)
            //    {
            //        Console.WriteLine(ex.Message);

            //    }
            //}
            //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            //var task = Download.DownloadFileAsync("C#", cancellationTokenSource.Token);
            //await Task.Delay(5000);
            //cancellationTokenSource.Cancel();

            //try
            //{
            //    await task;
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            var result =await  Download.DownloadWithTimeout("test", 1500);
            Console.WriteLine(result);

        }
        #region 
        //public static async Task<string> GreetingAsync(string name) {

        //   await Task.Delay(500);
        //    return name; 
        //}
        #endregion
        public static async Task ThrowAsync()
        {
            await Task.Delay(500);
            throw new InvalidOperationException();
        }





    }
}

