using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTools.Model
{
    [Serializable]
    public class RunModel
    {

        public string CmdName { get; set; }

        public string CommandLine { get; set; }

        public CommandModel Cmd { get; set; }

        public List<IOList> CmdLogList { get; set; } = new List<IOList>();
    }

    [Serializable]
    public class IOList
    {
        public IOType Type { get; set; }

        public string Content { get; set; }
    }
}
