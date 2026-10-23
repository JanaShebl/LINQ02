namespace LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //var result = Source.ProductList.OrderByDescending(p=>p.UnitPrice).Take(3);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q2

            //var result = Source.ProductList.Skip(5).Take(5);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q3

            var result = Source.ProductList.TakeWhile(p => p.UnitPrice < 25);
            foreach (var product in result)
            {
                Console.WriteLine(product);
            }

            #endregion
        }
    }
}
