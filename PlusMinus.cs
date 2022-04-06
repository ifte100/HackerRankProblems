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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double positiveSum = 0;
        double negativeSum = 0;
        double zeroSum = 0;
        
        for(int i = 0; i < arr.Count; i++)
        {
            if(arr[i] > 0)
            {
                positiveSum++;
            }
            else if(arr[i] < 0)
            {
                negativeSum++;
            }
            else if(arr[i] == 0)
            {
                zeroSum++;
            }
        }
        
        Console.WriteLine(positiveSum/arr.Count);
        Console.WriteLine(negativeSum/arr.Count);
        Console.WriteLine(zeroSum/arr.Count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
