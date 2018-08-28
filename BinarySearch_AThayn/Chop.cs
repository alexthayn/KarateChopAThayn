using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_AThayn
{
    public class Chop
    {

        public int ChopLoop(int target, List<int> sortedArray)
        {
            int top = sortedArray.Count - 1;
            int bottom = 0;

            if (sortedArray.Count == 0)
                return -1;

            while(true)
            {                
                int middleIndex = (top - bottom) / 2 + bottom;
                if (sortedArray[middleIndex] == target)
                    return middleIndex;
                if (top <= bottom)
                    return -1;
                if (sortedArray[middleIndex] < target)
                    bottom = middleIndex + 1;
                else
                    top = middleIndex - 1;
            }
        }

        public int ChopRecursion(int target, List<int> sortedArray)
        {
            return ChopChopRecursion(target, sortedArray, 0, sortedArray.Count - 1);
        }

        private int ChopChopRecursion(int target, List<int> array, int bottom, int top)
        {
            if (array.Count == 0)
                return - 1;

            int middleIndex = (top - bottom) / 2 + bottom;

            if (array[middleIndex] == target)
                return middleIndex;

            if (top <= bottom)
                return -1;
            
            if (target < array[middleIndex])
                return ChopChopRecursion(target, array, bottom, middleIndex - 1);
            else
                return ChopChopRecursion(target, array, middleIndex + 1, array.Count - 1);
        }
    }
}
