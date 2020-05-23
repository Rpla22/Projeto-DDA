namespace ProjetoDA
{
    partial class ImoDA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImoDA));
            this.bt_casas = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_casas
            // 
            this.bt_casas.Image = ((System.Drawing.Image)(resources.GetObject("bt_casas.Image")));
            this.bt_casas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_casas.Location = new System.Drawing.Point(139, 137);
            this.bt_casas.Name = "bt_casas";
            this.bt_casas.Size = new System.Drawing.Size(121, 112);
            this.bt_casas.TabIndex = 3;
            this.bt_casas.Text = "Casas";
            this.bt_casas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_casas.UseVisualStyleBackColor = true;
            this.bt_casas.Click += new System.EventHandler(this.bt_casas_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.Image = ((System.Drawing.Image)(resources.GetObject("bt_clientes.Image")));
            this.bt_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_clientes.Location = new System.Drawing.Point(12, 137);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(121, 112);
            this.bt_clientes.TabIndex = 2;
            this.bt_clientes.Text = "Clientes";
            this.bt_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imo DA";
            // 
            // ImoDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(270, 259);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_casas);
            this.Controls.Add(this.bt_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImoDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImoDA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_casas;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

