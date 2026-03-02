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

            //3
            //var SortedByDesc = ProductList.OrderByDescending(P=> P.UnitsInStock);
            //PrintList(SortedByDesc);

            //4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
            //var result =  Arr.OrderBy(Name => Name.Length)
            //                 .ThenBy(Name => Name);
            //PrintList(result);

            ////5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =words.OrderBy(W => W.Length)
            //                 .ThenBy(W =>W, StringComparer.OrdinalIgnoreCase);
            //PrintList(result);

            //6
            //var result =ProductList.OrderBy(P => P.Category)
            //                       .ThenByDescending(P => P.UnitPrice);
            //PrintList(result);
            #endregion

            #region Five

            #endregion

        }

        public static void PrintList<T> (IEnumerable<T> List) {
        
           foreach(var item in List) Console.WriteLine(item);
        }
    }
}
