using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace StringTools.PropertyFrm
{
    class PropertyCodeText : UITypeEditor
    {
        public PropertyCodeText()
        {

            txtArea.BorderStyle = BorderStyle.None;
           // txtArea.IsReadOnly = true;
            txtArea.Dock = DockStyle.Fill;
            txtArea.SetHighlighting("C#");
            txtArea.Size = new System.Drawing.Size(260, 200);

        }
        private ICSharpCode.TextEditor.TextEditorControl txtArea = new ICSharpCode.TextEditor.TextEditorControl();

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            try
            {
                IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                if (edSvc != null)
                {
                    txtArea.Text = value as string;
                    edSvc.DropDownControl(txtArea);
                    return txtArea.Text;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return base.EditValue(context, provider, value);
        }
    }
}
