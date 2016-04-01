using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTools
{
	/// <summary>
	/// 扩展方法
	/// </summary>
    public static class StringExtension
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="srcString"></param>
		/// <param name="spChar"></param>
		/// <returns></returns>
        public static string SplitForRow(this string srcString, char[] spChar)
		{
			StringBuilder sbr = new StringBuilder();
			string[] arry = srcString.Split(spChar, StringSplitOptions.RemoveEmptyEntries);
			foreach (var a in arry)
			{
				sbr.AppendLine(a);
			}

			return sbr.ToString();
		}

		public static string SplitWithOp(this string srcString, char[] spChar, string PStr, string LStr, string SStr)
		{
			StringBuilder sbr = new StringBuilder();
			string[] arry = srcString.Split(spChar, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < arry.Length; i++)
			{
				if (i == arry.Length - 1)
				{
					sbr.AppendFormat("{0}{1}{2}", PStr, arry[i], LStr);
				}
				else
				{
                    if (arry[i].StartsWith("\n") || arry[i].StartsWith("\r\n"))
					{

                        sbr.AppendFormat("\n{0}{1}{2}{3}", PStr, arry[i].TrimStart('\r','\n'), LStr, SStr);
					}
					else
					{
					   sbr.AppendFormat("{0}{1}{2}{3}", PStr, arry[i], LStr, SStr);
				   }
				}
			}

			return sbr.ToString();
		}

		public static string ToStringBuilder(this string srcString)
		{
			StringBuilder sbr = new StringBuilder();
			string[] arry = srcString.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			sbr.AppendLine("StringBuilder sbr = new StringBuilder();");
            foreach (var a in arry)
            {
                sbr.AppendFormat("sbr.AppendLine(\"{0}\");\r\n",a.Replace("\"","\\\""));
            }

            return sbr.ToString();
        }

    }
}
