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

            #region Q9

            //var result = from c in Source.CustomerList
            //             group c by c.Country into x
            //             select new { country = x.Key, count = x.Count(), total = x.Sum(cus => cus.Orders.Sum(s => s.Total)) };

            #endregion

            #region Q10

            //var result = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(result);

            #endregion

            #region Q11

            //var expensive = Source.ProductList.Max(p => p.UnitPrice);
            //var cheap = Source.ProductList.Min(p => p.UnitPrice);
            //Console.WriteLine(expensive);
            //Console.WriteLine(cheap);

            #endregion

            #region Q12

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);

            #endregion

            #region Q14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var res = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            #endregion

            #region Q15

            //var dict = Source.ProductList.ToDictionary(p => p.ProductID);
            //    var p = dict[18];

            #endregion
        }
    }
}
