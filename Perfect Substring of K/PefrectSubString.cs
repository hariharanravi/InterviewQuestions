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
     * Complete the 'perfectSubstring' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static int counter=0;
    public static int perfectSubstring(string s, int k)
    {        
        for(int i=0;i<s.Length;i++)
        {
            string substr = s.Substring(i);
            FindPerfectSubStr(substr,k);
        }
        return counter;
    }

    public static void FindPerfectSubStr(string substr, int k)
    {
		Dictionary<int, int> tempDic = new Dictionary<int, int>();
		for(int j=0;j<substr.Length;j++)
		{
			int parsedKey = int.Parse(substr[j].ToString());
			if(tempDic.ContainsKey(parsedKey))
			{
				tempDic[parsedKey]=tempDic[parsedKey]+1;
			}
			else
			{
				tempDic.Add(parsedKey, 1);   
			}
			int temp=0;
			int[] key = tempDic.Keys.ToArray();
			for(int i=0;i<key.Length;i++)
			{
				if(tempDic[key[i]] == k)
				{
					temp++;
				}
			}
			if(temp==key.Length)
			{
				Console.WriteLine("Perfect Substr :: " + new string(substr.Take(j+1).ToArray()));
				counter++;
			}
            }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.perfectSubstring(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}