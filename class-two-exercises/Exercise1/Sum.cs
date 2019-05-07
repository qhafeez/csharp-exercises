using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    public class Sum
    {
        public static int SumOf(List<int> nums)
        {

            int total = 0;

            List<int> theList = nums;


            theList.ForEach((item) =>
            {

                if (item % 2 == 0)
                {
                    total += item;
                }

            });

            return total;


        }

    }
}
