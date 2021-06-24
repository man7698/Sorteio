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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        int quantnum = 0;

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconfig novoform = new frmconfig();
            novoform.Show();
        }

        private void sortearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbsorteados.Visible = true;

        }

        private void btnsorteio_Click(object sender, EventArgs e)
        {


            #region código inicial

            int num1 = classeconfig.n1, num2 = classeconfig.n2 + 1;
            if (classeconfig.repetir == 1)
            {
                Random aleatorio = new Random();

                int i = aleatorio.Next(num1, num2);

                lstsorteio.Items.Add(i.ToString());
            }
            else
            {

                int continuar = 0;
                do
                {

                    Random aleatorio = new Random();

                    int i = aleatorio.Next(num1, num2);
                    if (lstsorteio.Items.Contains(i.ToString()))
                    {
                    }
                    else
                    {
                        lstsorteio.Items.Add(i.ToString());
                        continuar = 1;
                        quantnum++;
                        break;
                    }
                    if (quantnum == num2)
                    {
                        MessageBox.Show("A quantidade máxima de números já foi sorteada!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                }
                while (continuar == 0);

            }
            #endregion

        }


    }
      
    }

