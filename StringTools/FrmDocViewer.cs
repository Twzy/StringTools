using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringTools
{
    public partial class FrmDocViewer : Form
    {
        public FrmDocViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 通过文件名称加载
        /// </summary>
        /// <param name="file"></param>
        public void LoadDoc(string file)
        {
            try
            {
                Model.DocumentModel docment = Tools.ReadByXML<Model.DocumentModel>(file);
                LoadDoc(docment);
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误：" + ex.Message);
            }
        }


        /// <summary>
        /// 通过模型加载
        /// </summary>
        /// <param name="document"></param>
        public void LoadDoc(Model.DocumentModel document)
        {
            StringBuilder sbr = new StringBuilder();
            foreach (var r in document.RecoderList)
            {
                string content = "";

                int step = 1;

                //读取输入内容
                foreach (var i in r.CmdLogList)
                {
                    switch (i.Type)
                    {
                        case IOType.TxtIn_R:
                            content += Properties.Resources.IOContent.Replace("$OT$", step.ToString() + ".输入内容：").Replace("$OP$", System.Web.HttpUtility.HtmlEncode(i.Content));
                            step++;
                            break;

                        case IOType.TxtOut_R:
                            content += Properties.Resources.IOContent.Replace("$OT$", step.ToString() + ".从输出获取内容：").Replace("$OP$", System.Web.HttpUtility.HtmlEncode(i.Content));
                            step++;
                            break;
                    }
                }

                //命令内容
                string tmpContent = "->" + r.CommandLine;
                foreach (var i in r.CmdLogList)
                {
                    if (i.Type == IOType.Cmd)
                    {
                        tmpContent += "\r\n" + i.Content;
                    }
                }
                content += Properties.Resources.CmdContent.Replace("$CT$", step.ToString() + ".执行命令信息").Replace("$CMD$", System.Web.HttpUtility.HtmlEncode(tmpContent));
                step++;

                //输出内容
                foreach (var i in r.CmdLogList)
                {
                    switch (i.Type)
                    {
                        case IOType.TxtIn_W:
                            content += Properties.Resources.IOContent.Replace("$OT$", step.ToString() + ".向输入文本框添加：").Replace("$OP$", System.Web.HttpUtility.HtmlEncode(i.Content));
                            step++;
                            break;

                        case IOType.TxtOut_W:
                            content += Properties.Resources.IOContent.Replace("$OT$", step.ToString() + ".输出结果：").Replace("$OP$", System.Web.HttpUtility.HtmlEncode(i.Content));
                            step++;
                            break;
                    }
                }


                string cmdInfo = "";
                if (r.Cmd != null)
                {
                    cmdInfo = r.Cmd.Descption + "<br/>";

                    if (r.Cmd.ParamList.Count > 0)
                    {
                        cmdInfo += "参数说明：<br/>";
                    }
                    for (int i = 0; i < r.Cmd.ParamList.Count; i++)
                    {
                        cmdInfo += "&nbsp;&nbsp;[" + (i + 1).ToString() + "]" + r.Cmd.ParamList[i] + "<br/>";
                    }
                }
                else
                {
                    cmdInfo = "未知的命令";
                }



                string run = Properties.Resources.RunContent
                    .Replace("$CMD$", r.CmdName)
                    .Replace("$DSC$", cmdInfo)
                    .Replace("$CNT$", content);

                sbr.Append(run);

            }




            string finalStr = Properties.Resources.MainContent.Replace("$TIT$", document.Title)
                                                              .Replace("$CNT$", document.Author + "<br/>" + document.CreateTime)
                                                              .Replace("$RUN$", sbr.ToString());

            webBrowser1.DocumentText = finalStr;
        }

        private void FrmDocViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Common.Log();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog sp = new OpenFileDialog();
            sp.Filter = "xml文件|*.xml";
            if (sp.ShowDialog() == DialogResult.OK)
            {
                LoadDoc(sp.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sp = new SaveFileDialog();
            sp.Filter = "html文件|*.html";
            if (sp.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sp.FileName, webBrowser1.DocumentText);
            }
        }
    }
}
