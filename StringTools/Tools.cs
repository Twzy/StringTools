using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace StringTools
{
    public class Tools
    {
        public static void WriteByXML<T>(T p, string path)
        {
            Stream stream = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));

                stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
                xs.Serialize(stream, p);
                stream.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }
        public static T ReadByXML<T>(string path)
        {
            Stream stream = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                XmlTextReader xmlread = new XmlTextReader(stream);
                xmlread.Normalization = false;
                T p = (T)xs.Deserialize(xmlread);
                stream.Close();
                return p;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        /// <summary>
        /// 获取命令实现的代码内容
        /// </summary>
        /// <param name="commandCode"></param>
        /// <returns></returns>
        public static string GetInnerCode(string commandCode)
        {
            string regexp = @"\r\n\s*public\s+void\s+\w+\([\w,\s\[\]]*\)\s*\r\n\s*{(?<content>.*)}";
            var m = Regex.Match(commandCode, regexp, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            if (m.Success)
            {
                return m.Groups["content"].Value;
            }
            return "";
        }

        /// <summary>
        /// 转义替换
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string[] RepEscape(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {

                args[i] = args[i].Replace("\\s", " ").Replace("\\t", "\t")
                               .Replace("\\d", "").Replace("\\n", "\n")
                               .Replace("\\r", "\r");
            }
            return args;
        }



        /// <summary>
        /// 转义替换
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string RepEscape(string a)
        {

            a = a.Replace("\\s", " ").Replace("\\t", "\t")
                           .Replace("\\d", "").Replace("\\n", "\n")
                           .Replace("\\r", "\r");

            return a;
        }

        public static string StrShort(string s, int length = 40)
        {
            return s.Substring(0, s.Length > length ? 40 : s.Length).Replace("\r", "").Replace("\n", " ").Replace("\t", " ") + " ... ";
        }

        /// <summary>
        /// 参数合并
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string ArgsCombin(string[] args)
        {
            StringBuilder sbr = new StringBuilder();
            foreach (var item in args)
            {
                sbr.Append(item + " ");
            }
            return sbr.ToString();
        }

        /// <summary>
        /// 通过命令行获取除名另外其他的参数
        /// </summary>
        /// <param name="cmdline"></param>
        /// <returns></returns>
        public static string getContent(string cmdline)
        {
            cmdline = cmdline.TrimStart();
            cmdline = cmdline.Substring(cmdline.IndexOf(' ')).TrimStart();
            return cmdline;
        }
    }
}
