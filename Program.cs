using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list = new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");

            int sum = 0;
            foreach (var value in list)
            {
                Console.WriteLine(value.ToString());

                if (value is int)
                {
                    sum += (int)value;
                }
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
