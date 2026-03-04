using day10_G01;
using System;
using System.Collections.Generic;
using System.Linq;
using static day10_G01.ListGenerators;
namespace LinqDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Restriction Operatror
            // 1
            //var OutOfStockProducts = ProductList.Where(P => P.UnitsInStock == 0);
            //PrintList(OutOfStockProducts);

            // 2
            //var WantedProducts = ProductList.Where(P => P.UnitsInStock != 0 && P.UnitPrice > 3);
            //PrintList(WantedProducts);

            // 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var ResultDigits = Arr.Where((Name, Index) => Name.Length > Index).ToList();
            //PrintList(ResultDigits);
            #endregion

            #region Element Operator
            // 1
            //var FirstOutOfStockProduct = ProductList.Where((P, I) => P.UnitsInStock == 0 ).FirstOrDefault();
            //Console.WriteLine(FirstOutOfStockProduct);

            // 2
            //var NotExisted = ProductList.FirstOrDefault(P => P.UnitPrice>1000 );
            //Console.WriteLine(NotExisted);

            // 3 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var SecondPlace = Arr.Where(I => I > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(SecondPlace);
            #endregion

            #region Aggregate Operator
            // 1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var odd =Arr.Count(I => I%2 != 0 );
            //Console.WriteLine(odd);

            //2
            //var customerList = CustomerList.Select(C => new {Name = C.Name, OrderCount= C.Orders.Count() });
            //PrintList(customerList);

            //3
            //var CategoryList = ProductList.GroupBy(P => P.Category)
            //                               .Select(P => new { P.Key, Product = P.Count() }); 
            //PrintList(CategoryList);

            //4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var total = Arr.Count();
            //Console.WriteLine(total);


            #endregion

            #region Order Operator
            // 1
            //var sortedByName = ProductList.OrderBy(P => P.ProductName)
            //                              .ThenBy(P => P.ProductID );
            //PrintList(sortedByName);

            // 3
            //var SortedByDesc = ProductList.OrderByDescending(P=> P.UnitsInStock);
            //PrintList(SortedByDesc);

            // 4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
            //var result =  Arr.OrderBy(Name => Name.Length)
            //                 .ThenBy(Name => Name);
            //PrintList(result);

            // 5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =words.OrderBy(W => W.Length)
            //                 .ThenBy(W =>W, StringComparer.OrdinalIgnoreCase);
            //PrintList(result);

            // 6
            //var result =ProductList.OrderBy(P => P.Category)
            //                       .ThenByDescending(P => P.UnitPrice);
            //PrintList(result);

            // 7
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(word => word.Length > 1 && word[1] == 'i')
            //                .Reverse();
            //PrintList(result);



            #endregion

            #region Transformation Operator
            // 1
            //var ProductNames = ProductList.Select(P => new { P.ProductName });
            //PrintList(ProductNames);

            // 2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var LowerCaseProducts = words.Select(P => new { Lower = P.ProductName.ToLower() });
            //var UpperCaseProducts = words.Select(P => new { Upper = P.ProductName.ToUpper() });

            // 3
            //var FewerInforamation = ProductList.Select(P => new { ID = P.ProductID , Name = P.ProductName , Price = P.UnitPrice  });
            //PrintList(FewerInforamation);

            // 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var InPostion = Arr.Select((Number, Index) => Number == Index);
            //PrintList(InPostion);

            // 5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b })
            //        .Where(pair => pair.a < pair.b);

            // 6
            //var lessThan500 = CustomerList.Where(C => C.Orders!=null)
            //                              .SelectMany(C => C.Orders)
            //                              .Where(C => C.Total < 500);
            //PrintList(lessThan500);

            // 7
            //var Before1998 = CustomerList.SelectMany(x => x.Orders)
            //                             .Where(C => C.OrderDate.Year < 1998);
            //PrintList(Before1998);
            #endregion

            #region Aggregate Operators 
            // 1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var numOfOdds = Arr.Count(N => N%2 !=0);
            //Console.WriteLine(numOfOdds);

            // 2
            //var OrdersOfCustomer = CustomerList.Where(C => C.Orders.Any());
            //PrintList(OrdersOfCustomer);

            // 3
            //var numOfProductPerCategory =ProductList.Select
            //                            (P => new { Categorey = P.Category,Products = P.Category.Count() });
            //PrintList(numOfProductPerCategory);

            // 4
            //var totalNum = Arr.Count();
            //Console.WriteLine(totalNum);

            // 6
            //var categoryStock = ProductList.GroupBy(p => p.Category)
            //                    .Select(group => new
            //                    {
            //                        Category = group.Key,
            //                        TotalStock = group.Sum(p => p.UnitsInStock)
            //                    });
            //PrintList(categoryStock);


            // 8 
            //var CheapestProducts = ProductList.GroupBy(P => P.Category)
            //    .Select(P => new {
            //        Category = P.Key,
            //        ProductName = P.Where(U => U.UnitPrice == P.Min(min => min.UnitPrice))
            //                       .Select(U => U.ProductName).FirstOrDefault(),
            //        MinPrice = P.Min(P => P.UnitPrice)
            //    });
            //PrintList(CheapestProducts);

            // 9
            //var cheapestProducts = from P in ProductList
            //                       group P by P.Category into G
            //                       let minPrice = G.Min(V => V.UnitPrice)
            //                       select new
            //                       {
            //                           Category = G.Key,
            //                           ProductName = G.FirstOrDefault(X => X.UnitPrice == minPrice).ProductName,
            //                           Price = minPrice,
            //                       };
            //PrintList(cheapestProducts);

            // 10
            //var MostExpensiveProducts = from P in ProductList
            //                            group P by P.Category into G
            //                            let MaxPrice = G.Max(V => V.UnitPrice)
            //                            select new
            //                            {
            //                                Category = G.Key,
            //                                MostExpensive = G.Where(X => X.UnitPrice == MaxPrice),
            //                                Price = MaxPrice,
            //                            };


            // 11
            //var averagePrices = ProductList.GroupBy(G => G.Category)
            //                               .Select(P => new {
            //                                   Category = P.Key ,
            //                                   AveragePrice = P.Average(U => U.UnitPrice)
            //                               }); 

            //PrintList(averagePrices);
            #endregion

            #region Partionting Operators 
            // 1
            //var WashingtonCustomers = CustomerList.Where(C => C.City == "Washington")
            //                                      .Select(C => new
            //                                      {
            //                                          CustomerName = C.Name,
            //                                          First3Order = C.Orders.Take(3)
            //                                      });
            //PrintList(WashingtonCustomers);


            // 2 
            //var WashingtonCustomers = CustomerList.Where(C => C.City == "Washington")
            //                                .Select(C => new
            //                                {
            //                                    CustomerName = C.Name,
            //                                    First3Order = C.Orders.Skip(3)
            //                                });
            //PrintList(WashingtonCustomers);


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // 3
            //var task3 = numbers.TakeWhile((n, index) => n >= index);
            //PrintList(task3);

            // 4 
            //var task4 = numbers.SkipWhile(n => n % 3 != 0);
            //PrintList(task4);

            // 5
            //var task5 = numbers.SkipWhile((n, index) => n >= index);
            //PrintList(task5);
            #endregion

            #region Quantifier Operators
            // 2
            //var hasOut = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0));
            //PrintList(hasOut);

            // 3
            //var allIn = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0));
            //PrintList(allIn);
            #endregion
        }

        public static void PrintList<T> (IEnumerable<T> List) {
        
           foreach(var item in List) Console.WriteLine(item);
        }
    }
}
