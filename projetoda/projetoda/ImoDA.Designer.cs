﻿namespace ProjetoDA
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
            this.bt_casas = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_casas
            // 
            this.bt_casas.Location = new System.Drawing.Point(213, 183);
            this.bt_casas.Name = "bt_casas";
            this.bt_casas.Size = new System.Drawing.Size(140, 81);
            this.bt_casas.TabIndex = 3;
            this.bt_casas.Text = "Casas";
            this.bt_casas.UseVisualStyleBackColor = true;
            this.bt_casas.Click += new System.EventHandler(this.bt_casas_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.Location = new System.Drawing.Point(67, 183);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(140, 81);
            this.bt_clientes.TabIndex = 2;
            this.bt_clientes.Text = "Clientes";
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // ImoDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 336);
            this.Controls.Add(this.bt_casas);
            this.Controls.Add(this.bt_clientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImoDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImoDA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_casas;
        private System.Windows.Forms.Button bt_clientes;
    }
}

