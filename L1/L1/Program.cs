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

            #region Q2
            var results02 = Source.ProductList.Select(p => p.ProductName);
            foreach (var result in results02)
            {
                Console.WriteLine(result);
            }
            #endregion
        }
    }
}
