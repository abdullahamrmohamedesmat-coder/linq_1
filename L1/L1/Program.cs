namespace L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            var results01 = Source.ProductList.Where(p => p.Category == "Seafood").Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var result in results01)
            {
                Console.WriteLine(result);
            }
            #endregion
        }
    }
}
