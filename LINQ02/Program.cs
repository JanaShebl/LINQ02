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

            //var result = Source.ProductList.TakeWhile(p => p.UnitPrice < 25);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Q4

            // var result = Source.ProductList.Where(p=>p.Category== "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(result);

            #endregion

            #region Q5

            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine(result);

            #endregion

            #region Q6

            //var result = Source.ProductList.GroupBy(p=>p.Category).Select(x=>new {category=x.Key, count=x.Count()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.category} has {item.count} products");
            //}

            #endregion

            #region Q7

            //var result = Source.ProductList.GroupBy(p => p.Category,p=>p.ProductName).Select(x => new {category=x.Key, products=x.ToList()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.category} has {item.products.Count} products");
            //    foreach (var product in item.products)
            //    {
            //        Console.WriteLine($"  {product}");
            //    }
            //    Console.WriteLine("=============================================================");
            //}

            #endregion

            #region Q8

            //var result = Source.ProductList.GroupBy(p => p.Category).Where(x => x.Count() > 3).Select(rs => rs.Key);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
