﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace MyCustomExtensions
{
    public static class MyExtensions
    {
        
        public static void Display<T>(T t) => Console.WriteLine(t);
        
        public static void ProcessItems<T>(this IEnumerable<T> items)
        {
            switch (items)
            {
                case IEnumerable<int> ints:
                    SumAllPositiveIntegers();
                    break;
                case IEnumerable<string> strings:
                    StringDivider();
                    break;
                default:
                    Display("Sorry, this was built only for types of integers or strings.");
                    break;
            }


            void SumAllPositiveIntegers()
            {
                var positiveNumbers = items.OfType<int>().Where(x => x > 0);

                if (positiveNumbers.Any())
                {
                    var sum = positiveNumbers.Sum();

                    Display(sum);
                }
                else
                {
                    Display("No positive integers found!");
                }
            }

            void StringDivider()
            {
                foreach (var item in items)
                {
                    Display(item);
                }
            }

        }
    }
}
