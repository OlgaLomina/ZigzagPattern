using System;
using System.Collections.Generic;
using System.Text;
/*The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);
Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:

P     I    N
A   L S  I G
Y A   H R
P     I
 * */
namespace List2
{
    class Program
    {
        public static string Convert(string s, int numRows)
        {

            Dictionary<int, StringBuilder> dict = new Dictionary<int, StringBuilder>();

            int n = 0;
            bool down = false;
            StringBuilder sb;
            for (int i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(n, out sb))
                    dict[n] = sb.Append(s[i]);
                else
                {
                    sb = new StringBuilder();
                    sb = sb.Append(s[i].ToString());
                    dict.Add(n, sb);
                }

                if (n == numRows - 1 || n == 0)
                    down = !down;

                if (down)
                    n++;
                else
                    n--;            
            }

            string str = "";
            for (int i = 0; i < dict.Count; i++)
            {
                str = str + dict[i];
            }
            Console.WriteLine(str);
            return s;
        }


        static void Main(string[] args)
        {
            String str = "PAYPALISHIRING";
            int n = 4;
            str = Convert(str, n);
        }
    }
}
