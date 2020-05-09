namespace ProjetoDA.Forms
{
    partial class Clientes
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
            this.components = new System.ComponentModel.Container();
            this.imo_DADataSet1 = new ProjetoDA.imo_DADataSet1();
            this.clienteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteSetTableAdapter = new ProjetoDA.imo_DADataSet1TableAdapters.ClienteSetTableAdapter();
            this.tableAdapterManager = new ProjetoDA.imo_DADataSet1TableAdapters.TableAdapterManager();
            this.clienteSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_contacto = new System.Windows.Forms.TextBox();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.tb_nif = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imo_DADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imo_DADataSet1
            // 
            this.imo_DADataSet1.DataSetName = "imo_DADataSet1";
            this.imo_DADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteSetBindingSource
            // 
            this.clienteSetBindingSource.DataMember = "ClienteSet";
            this.clienteSetBindingSource.DataSource = this.imo_DADataSet1;
            // 
            // clienteSetTableAdapter
            // 
            this.clienteSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArrendamentoSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasaSet_CasaArrendavelTableAdapter = null;
            this.tableAdapterManager.CasaSet_CasaVendavelTableAdapter = null;
            this.tableAdapterManager.CasaSetTableAdapter = null;
            this.tableAdapterManager.ClienteSetTableAdapter = this.clienteSetTableAdapter;
            this.tableAdapterManager.LimpezaSetTableAdapter = null;
            this.tableAdapterManager.ServicoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoDA.imo_DADataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaSetTableAdapter = null;
            // 
            // clienteSetDataGridView
            // 
            this.clienteSetDataGridView.AutoGenerateColumns = false;
            this.clienteSetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.clienteSetDataGridView.DataSource = this.clienteSetBindingSource;
            this.clienteSetDataGridView.Location = new System.Drawing.Point(12, 121);
            this.clienteSetDataGridView.Name = "clienteSetDataGridView";
            this.clienteSetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteSetDataGridView.Size = new System.Drawing.Size(375, 528);
            this.clienteSetDataGridView.TabIndex = 1;
            this.clienteSetDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clienteSetDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn3.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.bt_novo);
            this.groupBox1.Controls.Add(this.bt_guardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_contacto);
            this.groupBox1.Controls.Add(this.tb_morada);
            this.groupBox1.Controls.Add(this.tb_nif);
            this.groupBox1.Controls.Add(this.tb_nome);
            this.groupBox1.Location = new System.Drawing.Point(393, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 528);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Aquisições:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(6, 433);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(294, 82);
            this.listBox3.TabIndex = 15;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 319);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(294, 82);
            this.listBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Arrendamentos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Casas:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 82);
            this.listBox1.TabIndex = 10;
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(188, 140);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(90, 23);
            this.bt_novo.TabIndex = 9;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(71, 140);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(90, 23);
            this.bt_guardar.TabIndex = 8;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contacto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Morada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NIF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // tb_contacto
            // 
            this.tb_contacto.Location = new System.Drawing.Point(71, 102);
            this.tb_contacto.MaxLength = 12;
            this.tb_contacto.Name = "tb_contacto";
            this.tb_contacto.Size = new System.Drawing.Size(207, 20);
            this.tb_contacto.TabIndex = 3;
            this.tb_contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contacto_KeyPress);
            // 
            // tb_morada
            // 
            this.tb_morada.Location = new System.Drawing.Point(71, 76);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(207, 20);
            this.tb_morada.TabIndex = 2;
            // 
            // tb_nif
            // 
            this.tb_nif.Location = new System.Drawing.Point(71, 50);
            this.tb_nif.MaxLength = 9;
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(207, 20);
            this.tb_nif.TabIndex = 1;
            this.tb_nif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nif_KeyPress);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(71, 24);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(207, 20);
            this.tb_nome.TabIndex = 0;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clienteSetDataGridView);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.imo_DADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteSetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private imo_DADataSet1 imo_DADataSet1;
        private System.Windows.Forms.BindingSource clienteSetBindingSource;
        private imo_DADataSet1TableAdapters.ClienteSetTableAdapter clienteSetTableAdapter;
        private imo_DADataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clienteSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_contacto;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.TextBox tb_nif;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_guardar;
    }
}