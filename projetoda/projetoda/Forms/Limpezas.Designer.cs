namespace ProjetoDA.Forms
{
    partial class Limpezas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Limpezas));
            this.listBox_servicos = new System.Windows.Forms.ListBox();
            this.listBox_limpezas = new System.Windows.Forms.ListBox();
            this.bt_emitir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_criar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.nud_quantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label_valor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_casa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_servicos
            // 
            this.listBox_servicos.FormattingEnabled = true;
            this.listBox_servicos.Location = new System.Drawing.Point(16, 86);
            this.listBox_servicos.Name = "listBox_servicos";
            this.listBox_servicos.Size = new System.Drawing.Size(439, 329);
            this.listBox_servicos.TabIndex = 0;
            this.listBox_servicos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // listBox_limpezas
            // 
            this.listBox_limpezas.FormattingEnabled = true;
            this.listBox_limpezas.Location = new System.Drawing.Point(12, 117);
            this.listBox_limpezas.Name = "listBox_limpezas";
            this.listBox_limpezas.Size = new System.Drawing.Size(252, 342);
            this.listBox_limpezas.TabIndex = 1;
            this.listBox_limpezas.Click += new System.EventHandler(this.listBox2_Click);
            // 
            // bt_emitir
            // 
            this.bt_emitir.Location = new System.Drawing.Point(12, 475);
            this.bt_emitir.Name = "bt_emitir";
            this.bt_emitir.Size = new System.Drawing.Size(252, 23);
            this.bt_emitir.TabIndex = 2;
            this.bt_emitir.Text = "Emitir Fatura";
            this.bt_emitir.UseVisualStyleBackColor = true;
            this.bt_emitir.Click += new System.EventHandler(this.bt_emitir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 506);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // bt_criar
            // 
            this.bt_criar.Location = new System.Drawing.Point(178, 503);
            this.bt_criar.Name = "bt_criar";
            this.bt_criar.Size = new System.Drawing.Size(86, 23);
            this.bt_criar.TabIndex = 4;
            this.bt_criar.Text = "Criar";
            this.bt_criar.UseVisualStyleBackColor = true;
            this.bt_criar.Click += new System.EventHandler(this.bt_criar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_inserir);
            this.groupBox1.Controls.Add(this.nud_quantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_valor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.listBox_servicos);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(278, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 434);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da Limpeza";
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(389, 22);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(75, 23);
            this.bt_inserir.TabIndex = 6;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // nud_quantidade
            // 
            this.nud_quantidade.Location = new System.Drawing.Point(285, 25);
            this.nud_quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantidade.Name = "nud_quantidade";
            this.nud_quantidade.Size = new System.Drawing.Size(87, 20);
            this.nud_quantidade.TabIndex = 5;
            this.nud_quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade:";
            // 
            // label_valor
            // 
            this.label_valor.AutoSize = true;
            this.label_valor.Location = new System.Drawing.Point(104, 58);
            this.label_valor.Name = "label_valor";
            this.label_valor.Size = new System.Drawing.Size(0, 13);
            this.label_valor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Unitário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serviço:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Area inferior 20m2 1h",
            "Area entre 20m2 e 40m2  1h",
            "Area Superior a 40m2 1h"});
            this.comboBox1.Location = new System.Drawing.Point(77, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label_casa
            // 
            this.label_casa.AutoSize = true;
            this.label_casa.Location = new System.Drawing.Point(22, 23);
            this.label_casa.Name = "label_casa";
            this.label_casa.Size = new System.Drawing.Size(31, 13);
            this.label_casa.TabIndex = 6;
            this.label_casa.Text = "Casa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Limpezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_casa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_criar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_emitir);
            this.Controls.Add(this.listBox_limpezas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Limpezas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limpezas";
            this.Load += new System.EventHandler(this.Limpezas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_servicos;
        private System.Windows.Forms.ListBox listBox_limpezas;
        private System.Windows.Forms.Button bt_emitir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_criar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nud_quantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Label label_casa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}