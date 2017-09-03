using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTools
{
    public class Common
    {
        static Common()
        {
            Document = new Model.DocumentModel();
        }

        #region CodeModel
        /// <summary>
        /// Code模型
        /// </summary>
        public static Model.CodeModel Code { get; set; }


        /// <summary>
        /// 添加命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static bool CmdAdd(Model.CommandModel cmd)
        {
            if (Code.CommandList.Contains(cmd))
                return false;

            Code.CommandList.Add(cmd);
            return true;
        }

        /// <summary>
        /// 删除命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static bool CmdDel(Model.CommandModel cmd)
        {
            if (Code.CommandList.Contains(cmd))
                Code.CommandList.Remove(cmd);
            return true;
        }



        /// <summary>
        /// 加载命令
        /// </summary>
        public static void LoadCodeMode()
        {
            if (System.IO.File.Exists(Config.CodeMode))
            {
                Common.Code = Tools.ReadByXML<Model.CodeModel>(Config.CodeMode);
            }
            else
            {
                Common.Code = new Model.CodeModel();
            }
        }


        /// <summary>
        /// 保存结构
        /// </summary>
        public static void SaveCodeMode()
        {
            Common.Code.VerDateTime = DateTime.Now.ToLocalTime().ToString();
            Tools.WriteByXML<Model.CodeModel>(Common.Code, Config.CodeMode);
        }

        /// <summary>
        /// 通过字符串查找命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static Model.CommandModel GetCommandByName(string cmd)
        {
            foreach (var item in Common.Code.CommandList)
            {
                if (item.Name == cmd.ToLower())
                {
                    return item;

                }
            }
            return null;
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        public static void BuidCode()
        {
            System.IO.File.WriteAllText(Config.ScriptPath, Common.Code.ToString());
        }
        #endregion


        #region DocModel
        /// <summary>
        /// 文档模型
        /// </summary>
        public static Model.DocumentModel Document;

        public static void Log()
        {
            string name = DateTime.Now.ToLocalTime().ToString("yyyyMMddHHmmss") + ".xml";
            Tools.WriteByXML<Model.DocumentModel>(Document, System.IO.Path.Combine(Config.LogDir, name));
        }

        #endregion
    }
}
