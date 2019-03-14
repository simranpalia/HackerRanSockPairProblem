using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        List<int> parsed = new List<int>();
        List<int> pairCount = new List<int>();

        for (int i = 0; i < ar.Length; i++)
        {
            if (!parsed.Any(x => x == ar[i]))
            {
                parsed.Add(ar[i]);
                pairCount.Add(ar.Where(x => x == ar[i]).Count());
            }
        }

        int totalPairs = 0;
        foreach (var sock in pairCount)
        {
            totalPairs = totalPairs + (sock / 2);
        }

        return totalPairs;
    }

    static void Main(string[] args)
    {
        sockMerchant(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 });
    }
}
