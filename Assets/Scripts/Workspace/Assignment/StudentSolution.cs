using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment

{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int i = 0; i < sortedNumbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < sortedNumbers.Length; j++)
                {
                    if (sortedNumbers[j] < sortedNumbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = sortedNumbers[i];
                sortedNumbers[i] = sortedNumbers[minIndex];
                sortedNumbers[minIndex] = temp;

            }
            return sortedNumbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)

        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int i = 0; i < sortedNumbers.Length - 1; i++)
            {
                for (int j = 0; j < sortedNumbers.Length - i - 1; j++)

                {

                    if (sortedNumbers[j] > sortedNumbers[j + 1])
                    {
                        int temp = sortedNumbers[j];
                        sortedNumbers[j] = sortedNumbers[j + 1];
                        sortedNumbers[j + 1] = temp;
                    }
                }
            }
            return sortedNumbers;
        }
        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int i = 1; i < sortedNumbers.Length; i++)
            {
                int key = sortedNumbers[i];
                int j = i - 1;
                while (j >= 0 && sortedNumbers[j] > key)
                {
                    sortedNumbers[j + 1] = sortedNumbers[j];
                    j--;
                }
                sortedNumbers[j + 1] = key;
            }
            return sortedNumbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int i = 0; i < sortedNumbers.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < sortedNumbers.Length; j++)
                {
                    if (sortedNumbers[j] > sortedNumbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = sortedNumbers[i];
                sortedNumbers[i] = sortedNumbers[maxIndex];
                sortedNumbers[maxIndex] = temp;
            }

            return sortedNumbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int i = 0; i < sortedNumbers.Length - 1; i++)
            {
                for (int j = 0; j < sortedNumbers.Length - i - 1; j++)
                {
                    if (sortedNumbers[j] < sortedNumbers[j + 1])
                    {
                        int temp = sortedNumbers[j];
                        sortedNumbers[j] = sortedNumbers[j + 1];
                        sortedNumbers[j + 1] = temp;
                    }
                }
            }

            return sortedNumbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] sortedNumbers = (int[])numbers.Clone();

            for (int i = 1; i < sortedNumbers.Length; i++)
            {
                int key = sortedNumbers[i];
                int j = i - 1;

                while (j >= 0 && sortedNumbers[j] < key)
                {
                    sortedNumbers[j + 1] = sortedNumbers[j];
                    j--;
                }

                sortedNumbers[j + 1] = key;
            }

            return sortedNumbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return 0;
            }

            int[] sortedNumbers = (int[])numbers.Clone();
            System.Array.Sort(sortedNumbers);

            int largestNumber = sortedNumbers[sortedNumbers.Length - 1];
            for (int i = sortedNumbers.Length - 2; i >= 0; i--)
            {
                if (sortedNumbers[i] < largestNumber)
                {
                    return sortedNumbers[i];
                }
            }

            return 0;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            int[] sortedNumbers = (int[])numbers.Clone();
            System.Array.Sort(sortedNumbers);

            int currentLength = 1;
            int longestLength = 1;

            for (int i = 1; i < sortedNumbers.Length; i++)
            {
                if (sortedNumbers[i] == sortedNumbers[i - 1])
                {
                    continue;
                }

                if ((long)sortedNumbers[i] == (long)sortedNumbers[i - 1] + 1)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                }
            }

            Debug.Log("The longest consecutive sequence is: " + longestLength);
            return longestLength;
        }

        #endregion
    }
}
