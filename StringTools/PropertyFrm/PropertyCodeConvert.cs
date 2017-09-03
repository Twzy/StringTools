using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace StringTools.PropertyFrm
{
    class PropertyCodeConvert : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;

        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService edSvc = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
            if (edSvc != null)
            {
                FrmCode stbForm = new FrmCode();
                stbForm.LoadCode(value as string);
                if (stbForm.ShowDialog() == DialogResult.OK)
                {
                    return stbForm.GetCode();
                }
            }
            return value;
        }
    }
}
