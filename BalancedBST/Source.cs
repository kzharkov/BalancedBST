using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures2
{
    public static class BalancedBST
    {
        public static int[] GenerateBBSTArray(int[] a)
        {
            var tree = new int[a.Length];

            Array.Sort(a);

            return GenerateBBSTArrayHelper(a, tree, 0);
        }

        private static int[] GenerateBBSTArrayHelper(int[] a, int[] tree, int index)
        {
            var middle = a.Length / 2;

            tree[index] = a[middle];

            if (a.Length == 1) return tree;

            var temp = new int[middle];
            Array.Copy(a, 0, temp, 0, middle);
            tree = GenerateBBSTArrayHelper(temp, tree, index * 2 + 1);
            Array.Copy(a, middle + 1, temp, 0, middle);
            tree = GenerateBBSTArrayHelper(temp, tree, index * 2 + 2);

            return tree;
        }
    }
}