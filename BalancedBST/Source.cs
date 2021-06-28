using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace AlgorithmsDataStructures2
{
    public static class BalancedBST
    {
        public static int[] GenerateBBSTArray(int[] a)
        {
            int[] tree = new int[a.Length];

            Array.Sort(a);

            return GenerateBBSTArrayHelper(a, tree, 0);
        }

        private static int[] GenerateBBSTArrayHelper(int[] a, int[] tree, int index)
        {
            var middle = a.Length / 2;

            tree[index] = a[middle];

            if (a.Length == 1) return tree;
            
            tree = GenerateBBSTArrayHelper(a[..middle], tree, index * 2 + 1);
            tree = GenerateBBSTArrayHelper(a[(middle+1)..], tree, index * 2 + 2);

            return tree;
        }
    }
}