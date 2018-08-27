using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_AThayn
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private int Chop(int target, List<int> sortedArray)
        {
            List<int> tempArray = sortedArray;

            for(int i = 0; i < Math.Ceiling(Math.Log(sortedArray.Count, 2)); i++)
            {
                int middleIndex = (tempArray.Count / 2);
                if (tempArray[middleIndex] == target)
                    return middleIndex;
                if (tempArray[middleIndex] < target)
                    tempArray = tempArray.GetRange(middleIndex + 1, tempArray.Count - 1);
                else
                    tempArray = tempArray.GetRange(0, middleIndex - 1);
            }
            return -1;
        }

        private int Chop1(int target, List<int> sortedArray)
        {
            return -1;
        }
    }
}
