namespace demoapp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GoogleBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MsnBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.msnlabel = new System.Windows.Forms.Label();
            this.lblComparativo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(13, 25);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(19, 13);
            this.resultado.TabIndex = 2;
            this.resultado.Text = "1: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GoogleBrowser);
            this.groupBox1.Location = new System.Drawing.Point(98, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Google";
            // 
            // GoogleBrowser
            // 
            this.GoogleBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoogleBrowser.Location = new System.Drawing.Point(3, 16);
            this.GoogleBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.GoogleBrowser.Name = "GoogleBrowser";
            this.GoogleBrowser.Size = new System.Drawing.Size(194, 88);
            this.GoogleBrowser.TabIndex = 0;
            this.GoogleBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.GoogleBrowser_DocumentCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MsnBrowser);
            this.groupBox2.Location = new System.Drawing.Point(319, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MSN";
            // 
            // MsnBrowser
            // 
            this.MsnBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MsnBrowser.Location = new System.Drawing.Point(3, 16);
            this.MsnBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MsnBrowser.Name = "MsnBrowser";
            this.MsnBrowser.Size = new System.Drawing.Size(194, 88);
            this.MsnBrowser.TabIndex = 0;
            this.MsnBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.MsnBrowser_DocumentCompleted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BuscarButton);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Location = new System.Drawing.Point(101, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(425, 75);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscador";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(274, 32);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 1;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // msnlabel
            // 
            this.msnlabel.AutoSize = true;
            this.msnlabel.Location = new System.Drawing.Point(13, 48);
            this.msnlabel.Name = "msnlabel";
            this.msnlabel.Size = new System.Drawing.Size(16, 13);
            this.msnlabel.TabIndex = 6;
            this.msnlabel.Text = "2:";
            this.msnlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblComparativo
            // 
            this.lblComparativo.AutoSize = true;
            this.lblComparativo.Location = new System.Drawing.Point(13, 74);
            this.lblComparativo.Name = "lblComparativo";
            this.lblComparativo.Size = new System.Drawing.Size(72, 13);
            this.lblComparativo.TabIndex = 7;
            this.lblComparativo.Text = "Comparativo: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultado);
            this.groupBox4.Controls.Add(this.lblComparativo);
            this.groupBox4.Controls.Add(this.msnlabel);
            this.groupBox4.Location = new System.Drawing.Point(202, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Search Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser GoogleBrowser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser MsnBrowser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label msnlabel;
        private System.Windows.Forms.Label lblComparativo;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

