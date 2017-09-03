using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTools.Model
{
    /// <summary>
    /// 命令使用文档模型
    /// </summary>
    [Serializable]
    public class DocumentModel
    {
        public string Title { get; set; } = "StringTools 使用记录与说明";

        public string Author { get; set; } = "墨云软件";

        public string CreateTime { get; set; } = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");

        public List<RunModel> RecoderList { get; set; } = new List<RunModel>();
    }
}
