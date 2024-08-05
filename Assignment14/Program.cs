using System.Collections;
using static Assignment14.ListGenerator;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            //Question 1
            var outOfStock = ProductsList.Where(p => p.UnitsInStock == 0).ToList();
            PrintArr(outOfStock);

            //2
            var inStockMoreThan3 = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
            PrintArr(inStockMoreThan3);

            //3
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var nameShorterThanVal = Arr.Where((p, i) => p.Length < i).ToList();
            PrintArr(nameShorterThanVal);
            #endregion

            #region LINQ - Ordering Operators
            //1
            var products = ProductsList.OrderBy(p => p.ProductName).ToList();
            PrintArr(products);

            //2
            string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var Arr2Sorted = Arr2.OrderBy(item => item.ToLower()).ToList();
            PrintArr(Arr2Sorted);

            //3
            var sortByStock = ProductsList.OrderByDescending(p => p.UnitsInStock).ToList();
            PrintArr(sortByStock);

            //4
            string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Arr3Sorted = Arr3.OrderBy(item => item.Length).ThenBy(item => item).ToList();
            PrintArr(Arr3Sorted);

            //5
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var wordsSorted = words.OrderBy(item => item.Length).ThenBy(item => item.ToLower()).ToList();
            PrintArr(wordsSorted);

            //6
            var sortCategoryPriceDesc = ProductsList.OrderByDescending(p => p.Category)
                .ThenByDescending(p => p.UnitPrice).ToList();
            PrintArr(sortCategoryPriceDesc);

            //7
            string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var Arr4Sorted = Arr4.OrderByDescending(p => p.Length).ThenByDescending(p => p.ToLower());
            PrintArr(Arr4Sorted);

            //8
            string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Arr5Reversed = Arr5.Where(item => item[1].Equals('i')).Reverse();
            PrintArr(Arr5Reversed);
            #endregion
        }

        static void PrintArr(IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========================");
        }
    }
}
