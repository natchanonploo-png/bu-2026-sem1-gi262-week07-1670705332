using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            // Your code here ...
            // ...


            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            // Your code here ...
            // ...

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            // Your code here ...
            // ...

            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            if (array == null || array.Length == 0) return new int[] { -1 };

            int first = -1;
            int last = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (first == -1)
                    {
                        first = i;
                    }
                    last = i;
                }
            }

            if (first == -1)
            {
                return new int[] { -1 };
            }

            return new int[] { first, last };
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            if (array == null || array.Length == 0) return -1;

            bool found = false;
            int maxVal = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target)
                {
                    if (!found || array[i] > maxVal)
                    {
                        maxVal = array[i];
                        found = true;
                    }
                }
            }

            return found ? maxVal : -1;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            if (array == null || array.Length == 0 || min > max) return new int[0];

            List<int> result = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    result.Add(array[i]);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            if (enemyHPs == null || enemyHPs.Length == 0 || mana <= 0) return new int[0];

            int[] sortedHPs = (int[])enemyHPs.Clone();
            Array.Sort(sortedHPs);

            List<int> selected = new List<int>();
            int currentManaSum = 0;

            foreach (int hp in sortedHPs)
            {
                if (currentManaSum + hp <= mana)
                {
                    selected.Add(hp);
                    currentManaSum += hp;
                }
                else
                {
                    break;
                }
            }

            return selected.ToArray();
        }
        #endregion
    }
}
