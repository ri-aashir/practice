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

    public static void plusMinus(List<int> arr, int arr_size)
    {
        decimal p_ratio = arr.Select(n => n > 0).ToList().Count / arr_size;
        decimal n_ratio = arr.Select(n => n < 0).ToList().Count / arr_size;
        decimal zeros = arr.Select(n => n == 0).ToList().Count / arr_size;

        Console.Write($"{p_ratio}\n{n_ratio}\n{zeros}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr, n);
    }
}
