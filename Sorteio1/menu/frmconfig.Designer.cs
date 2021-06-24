namespace menu
{
    partial class frmconfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.down1 = new System.Windows.Forms.NumericUpDown();
            this.down2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbrepetir = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.down1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down2)).BeginInit();
            this.SuspendLayout();
            // 
            // down1
            // 
            this.down1.Location = new System.Drawing.Point(128, 62);
            this.down1.Name = "down1";
            this.down1.Size = new System.Drawing.Size(76, 20);
            this.down1.TabIndex = 0;
            // 
            // down2
            // 
            this.down2.Location = new System.Drawing.Point(128, 92);
            this.down2.Name = "down2";
            this.down2.Size = new System.Drawing.Size(76, 20);
            this.down2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Configurações para Sorteio";
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnsalvar.FlatAppearance.BorderSize = 4;
            this.btnsalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.btnsalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(213, 59);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(87, 53);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zerar contadores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ckbrepetir
            // 
            this.ckbrepetir.AutoSize = true;
            this.ckbrepetir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbrepetir.Location = new System.Drawing.Point(17, 118);
            this.ckbrepetir.Name = "ckbrepetir";
            this.ckbrepetir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbrepetir.Size = new System.Drawing.Size(131, 24);
            this.ckbrepetir.TabIndex = 7;
            this.ckbrepetir.Text = "Repetir números";
            this.ckbrepetir.UseVisualStyleBackColor = true;
            // 
            // frmconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 187);
            this.Controls.Add(this.ckbrepetir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.down2);
            this.Controls.Add(this.down1);
            this.Name = "frmconfig";
            this.Text = "Configuração do sorteio";
            ((System.ComponentModel.ISupportInitialize)(this.down1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown down1;
        private System.Windows.Forms.NumericUpDown down2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox ckbrepetir;

    }
}