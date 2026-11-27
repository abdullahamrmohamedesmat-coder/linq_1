using static L1.Source;
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

            #region Q3
            var results03 = ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var result in results03)
            {
                Console.WriteLine(result);
            }
            #endregion

            #region Q4

            var results04 = ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);
            foreach (var result in results04)
            {
                Console.WriteLine(result);
            }
            #endregion

            #region Q5
            var results05 = ProductList.Where(p => p.Category == "Spices & Condiments" && p.UnitsInStock > 0);

            foreach (var result in results05)
            {
                Console.WriteLine(result);
            }
            #endregion

        }
    }
}
