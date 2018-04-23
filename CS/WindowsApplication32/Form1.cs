using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;

namespace WindowsApplication32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (Object.ReferenceEquals(e.SelectedControl, propertyGridControl1))
            {
                VGridHitInfo hitInfo = propertyGridControl1.CalcHitInfo(e.ControlMousePosition);
                if (hitInfo.Row != null)
                {
                    PropertyDescriptor pd = propertyGridControl1.GetPropertyDescriptor(hitInfo.Row);
                    if (pd != null )
                    {
                        object o = pd;
                        string description = string.Empty;
                        if (string.IsNullOrEmpty (pd.Description) )
                            description = "No description available";
                        else
                            description = pd.Description;
                        e.Info = new DevExpress.Utils.ToolTipControlInfo(o, description);
                    }
                }
            }
        }

    }
}