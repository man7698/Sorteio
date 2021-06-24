namespace menu
{
    partial class frmprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbsorteados = new System.Windows.Forms.GroupBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsorteio = new System.Windows.Forms.Button();
            this.lstsorteio = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.gpbsorteados.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sortearToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.abrirToolStripMenuItem.Text = "Configurar";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // sortearToolStripMenuItem
            // 
            this.sortearToolStripMenuItem.Name = "sortearToolStripMenuItem";
            this.sortearToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sortearToolStripMenuItem.Text = "Sortear";
            this.sortearToolStripMenuItem.Click += new System.EventHandler(this.sortearToolStripMenuItem_Click);
            // 
            // gpbsorteados
            // 
            this.gpbsorteados.Controls.Add(this.btnlimpar);
            this.gpbsorteados.Controls.Add(this.btnsorteio);
            this.gpbsorteados.Controls.Add(this.lstsorteio);
            this.gpbsorteados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbsorteados.Location = new System.Drawing.Point(76, 27);
            this.gpbsorteados.Name = "gpbsorteados";
            this.gpbsorteados.Size = new System.Drawing.Size(261, 228);
            this.gpbsorteados.TabIndex = 1;
            this.gpbsorteados.TabStop = false;
            this.gpbsorteados.Text = "Números Sorteados";
            this.gpbsorteados.Visible = false;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(166, 94);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(85, 65);
            this.btnlimpar.TabIndex = 6;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnsorteio
            // 
            this.btnsorteio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsorteio.Location = new System.Drawing.Point(166, 19);
            this.btnsorteio.Name = "btnsorteio";
            this.btnsorteio.Size = new System.Drawing.Size(85, 69);
            this.btnsorteio.TabIndex = 5;
            this.btnsorteio.Text = "Sorteio";
            this.btnsorteio.UseVisualStyleBackColor = true;
            this.btnsorteio.Click += new System.EventHandler(this.btnsorteio_Click);
            // 
            // lstsorteio
            // 
            this.lstsorteio.FormattingEnabled = true;
            this.lstsorteio.ItemHeight = 16;
            this.lstsorteio.Location = new System.Drawing.Point(8, 22);
            this.lstsorteio.Name = "lstsorteio";
            this.lstsorteio.Size = new System.Drawing.Size(154, 196);
            this.lstsorteio.TabIndex = 4;
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 256);
            this.Controls.Add(this.gpbsorteados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipal";
            this.Text = "Programa de Sorteio";
      
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbsorteados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortearToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbsorteados;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsorteio;
        private System.Windows.Forms.ListBox lstsorteio;
    }
}

