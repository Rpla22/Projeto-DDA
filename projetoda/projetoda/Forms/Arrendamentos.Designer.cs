namespace ProjetoDA.Forms
{
    partial class Arrendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrendamentos));
            this.listBox_arrendamentos = new System.Windows.Forms.ListBox();
            this.bt_remover = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_casa = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_localidade = new System.Windows.Forms.Label();
            this.label_proprietario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_inserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_arrendamentos
            // 
            this.listBox_arrendamentos.FormattingEnabled = true;
            this.listBox_arrendamentos.Location = new System.Drawing.Point(15, 96);
            this.listBox_arrendamentos.Name = "listBox_arrendamentos";
            this.listBox_arrendamentos.Size = new System.Drawing.Size(377, 277);
            this.listBox_arrendamentos.TabIndex = 0;
            this.listBox_arrendamentos.Click += new System.EventHandler(this.listBox_arrendamentos_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Location = new System.Drawing.Point(12, 379);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(377, 23);
            this.bt_remover.TabIndex = 1;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(407, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(407, 174);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(215, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(407, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Renovável";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inicio do contrato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duração (meses):";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(407, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arrendatário:";
            // 
            // label_casa
            // 
            this.label_casa.AutoSize = true;
            this.label_casa.Location = new System.Drawing.Point(12, 12);
            this.label_casa.Name = "label_casa";
            this.label_casa.Size = new System.Drawing.Size(34, 13);
            this.label_casa.TabIndex = 10;
            this.label_casa.Text = "Casa:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(53, 29);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(35, 13);
            this.label_id.TabIndex = 11;
            this.label_id.Text = "label5";
            // 
            // label_localidade
            // 
            this.label_localidade.AutoSize = true;
            this.label_localidade.Location = new System.Drawing.Point(53, 57);
            this.label_localidade.Name = "label_localidade";
            this.label_localidade.Size = new System.Drawing.Size(35, 13);
            this.label_localidade.TabIndex = 12;
            this.label_localidade.Text = "label6";
            // 
            // label_proprietario
            // 
            this.label_proprietario.AutoSize = true;
            this.label_proprietario.Location = new System.Drawing.Point(53, 80);
            this.label_proprietario.Name = "label_proprietario";
            this.label_proprietario.Size = new System.Drawing.Size(35, 13);
            this.label_proprietario.TabIndex = 13;
            this.label_proprietario.Text = "label7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(551, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bt_inserir
            // 
            this.bt_inserir.Location = new System.Drawing.Point(406, 262);
            this.bt_inserir.Margin = new System.Windows.Forms.Padding(2);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(220, 20);
            this.bt_inserir.TabIndex = 16;
            this.bt_inserir.Text = "inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // Arrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 413);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_proprietario);
            this.Controls.Add(this.label_localidade);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_casa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.listBox_arrendamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Arrendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrendamentos";
            this.Load += new System.EventHandler(this.Arrendamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_arrendamentos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_casa;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_localidade;
        private System.Windows.Forms.Label label_proprietario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_inserir;
    }
}