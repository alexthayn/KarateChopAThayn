using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_AThayn
{
    public class Chop
    {
        //I tested this class using the unit tests I wrote for each method located in the BinarySearchTests project

        //Iterative approach
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

        //Using recursion
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

        //Cheater way using built-in binary search function
        public int ChopChopChopChop(int target, List<int> sortedArray)
        {
            var answer = sortedArray.BinarySearch(target);
            if (answer < 0)
                return -1;
            return answer;
        }

        //Different Recursion Implementation
        public int ChopRecursionDifferently(int target, List<int> sortedArray)
        {
            return ChopRecursionDifferently(target, sortedArray, sortedArray.Count - 1, 0);
        }

        public int ChopRecursionDifferently(int target, List<int> sortedArray, int top, int bottom)
        {
            while(bottom <= top && sortedArray.Count > 0)
            {
                var middle = (top - bottom) / 2 + bottom;
                switch(sortedArray[middle] == target)
                {
                    case true:
                        return middle;
                    case false:
                        if (top == bottom)
                            return -1;
                        if (sortedArray[middle] > target)
                            return ChopRecursionDifferently(target, sortedArray, bottom, middle - 1);
                        return ChopRecursionDifferently(target, sortedArray, top, middle + 1);
                }
            }
            return -1;
        }
    }
}
