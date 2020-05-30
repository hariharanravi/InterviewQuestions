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
	//Time Complexity : O(n) . Space Complexity : O(1)

    /*
     * Complete the 'minX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    public static int MinSum = 1;
    public static int ArbitaryValue=0;
    public static int minX(List<int> arr)
    {
        int sum=0;
        for(int i=0;i<arr.Count;i++)
        {
            if((sum + arr[i]) < MinSum )
            {
                int value=((sum+arr[i])*-1)+1;
                sum+=value+arr[i];
                ArbitaryValue+=value;
            }
            else
            {
                sum+=arr[i];
            }
            Console.WriteLine("Sum = "+sum+" ArbitaryValue =  "+ArbitaryValue);
        }
        return ArbitaryValue;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < arrCount; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.minX(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
