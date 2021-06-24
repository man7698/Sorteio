using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace menu
{
    public partial class frmconfig : Form
    {
        public frmconfig()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
           
             classeconfig.n1 = Convert.ToInt16  (down1.Value);
             classeconfig.n2 = Convert.ToInt16(down2.Value);
             if (ckbrepetir.Checked == true)
             {
                 classeconfig.repetir  = 1;
             }
            
        }
    }
}
