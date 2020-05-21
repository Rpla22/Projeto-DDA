namespace ProjetoDA.Forms
{
    partial class Casas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Casas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_limpezas = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_venda_ver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_comissao_venda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_valor_venda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_arrendamento_ver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_comissao_arrendamento = new System.Windows.Forms.TextBox();
            this.tb_valor_arrendamento = new System.Windows.Forms.TextBox();
            this.cb_vendavel = new System.Windows.Forms.CheckBox();
            this.cb_arrendavel = new System.Windows.Forms.CheckBox();
            this.cb_proprietario = new System.Windows.Forms.ComboBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.nud_pisos = new System.Windows.Forms.NumericUpDown();
            this.nud_wc = new System.Windows.Forms.NumericUpDown();
            this.nud_assoalhadas = new System.Windows.Forms.NumericUpDown();
            this.nud_area = new System.Windows.Forms.NumericUpDown();
            this.tb_andar = new System.Windows.Forms.TextBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.tb_rua = new System.Windows.Forms.TextBox();
            this.tb_localidade = new System.Windows.Forms.TextBox();
            this.bt_nova = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_apagar = new System.Windows.Forms.Button();
            this.imo_DADataSet = new ProjetoDA.imo_DADataSet();
            this.casaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaSetTableAdapter = new ProjetoDA.imo_DADataSetTableAdapters.CasaSetTableAdapter();
            this.tableAdapterManager = new ProjetoDA.imo_DADataSetTableAdapters.TableAdapterManager();
            this.casaSetDataGridView = new System.Windows.Forms.DataGridView();
            this.IdCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_assoalhadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_area)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imo_DADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaSetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lb_id);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.bt_limpezas);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cb_vendavel);
            this.groupBox1.Controls.Add(this.cb_arrendavel);
            this.groupBox1.Controls.Add(this.cb_proprietario);
            this.groupBox1.Controls.Add(this.cb_tipo);
            this.groupBox1.Controls.Add(this.nud_pisos);
            this.groupBox1.Controls.Add(this.nud_wc);
            this.groupBox1.Controls.Add(this.nud_assoalhadas);
            this.groupBox1.Controls.Add(this.nud_area);
            this.groupBox1.Controls.Add(this.tb_andar);
            this.groupBox1.Controls.Add(this.tb_numero);
            this.groupBox1.Controls.Add(this.tb_rua);
            this.groupBox1.Controls.Add(this.tb_localidade);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(371, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 561);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(224, 157);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "M^2";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(94, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(18, 13);
            this.lb_id.TabIndex = 33;
            this.lb_id.Text = "ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 290);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Proprietário:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(60, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Tipo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Pisos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "WC\'s";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Assoalhadas:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Area:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Andar:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Numero:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Rua:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Localidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID:";
            // 
            // bt_limpezas
            // 
            this.bt_limpezas.Location = new System.Drawing.Point(13, 521);
            this.bt_limpezas.Name = "bt_limpezas";
            this.bt_limpezas.Size = new System.Drawing.Size(373, 28);
            this.bt_limpezas.TabIndex = 14;
            this.bt_limpezas.Text = "Gerir Limpezas (Total: 0)";
            this.bt_limpezas.UseVisualStyleBackColor = true;
            this.bt_limpezas.Click += new System.EventHandler(this.bt_limpezas_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_venda_ver);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_comissao_venda);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_valor_venda);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(202, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 164);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados de Venda";
            // 
            // bt_venda_ver
            // 
            this.bt_venda_ver.Location = new System.Drawing.Point(53, 127);
            this.bt_venda_ver.Name = "bt_venda_ver";
            this.bt_venda_ver.Size = new System.Drawing.Size(75, 23);
            this.bt_venda_ver.TabIndex = 19;
            this.bt_venda_ver.Text = "Ver ";
            this.bt_venda_ver.UseVisualStyleBackColor = true;
            this.bt_venda_ver.Click += new System.EventHandler(this.bt_venda_ver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Comissão base";
            // 
            // tb_comissao_venda
            // 
            this.tb_comissao_venda.Location = new System.Drawing.Point(25, 101);
            this.tb_comissao_venda.Name = "tb_comissao_venda";
            this.tb_comissao_venda.Size = new System.Drawing.Size(131, 20);
            this.tb_comissao_venda.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Valor Base Negociavel";
            // 
            // tb_valor_venda
            // 
            this.tb_valor_venda.Location = new System.Drawing.Point(25, 47);
            this.tb_valor_venda.Name = "tb_valor_venda";
            this.tb_valor_venda.Size = new System.Drawing.Size(131, 20);
            this.tb_valor_venda.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "€";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "€";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_arrendamento_ver);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_comissao_arrendamento);
            this.groupBox2.Controls.Add(this.tb_valor_arrendamento);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(10, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 164);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de Arrendamento";
            // 
            // bt_arrendamento_ver
            // 
            this.bt_arrendamento_ver.Location = new System.Drawing.Point(42, 127);
            this.bt_arrendamento_ver.Name = "bt_arrendamento_ver";
            this.bt_arrendamento_ver.Size = new System.Drawing.Size(75, 23);
            this.bt_arrendamento_ver.TabIndex = 14;
            this.bt_arrendamento_ver.Text = "Ver / Criar";
            this.bt_arrendamento_ver.UseVisualStyleBackColor = true;
            this.bt_arrendamento_ver.Click += new System.EventHandler(this.bt_arrendamento_ver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Comissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Valor Base (mês)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "€";
            // 
            // tb_comissao_arrendamento
            // 
            this.tb_comissao_arrendamento.Location = new System.Drawing.Point(19, 101);
            this.tb_comissao_arrendamento.Name = "tb_comissao_arrendamento";
            this.tb_comissao_arrendamento.Size = new System.Drawing.Size(131, 20);
            this.tb_comissao_arrendamento.TabIndex = 15;
            // 
            // tb_valor_arrendamento
            // 
            this.tb_valor_arrendamento.Location = new System.Drawing.Point(19, 47);
            this.tb_valor_arrendamento.Name = "tb_valor_arrendamento";
            this.tb_valor_arrendamento.Size = new System.Drawing.Size(131, 20);
            this.tb_valor_arrendamento.TabIndex = 14;
            // 
            // cb_vendavel
            // 
            this.cb_vendavel.AutoSize = true;
            this.cb_vendavel.Location = new System.Drawing.Point(183, 314);
            this.cb_vendavel.Name = "cb_vendavel";
            this.cb_vendavel.Size = new System.Drawing.Size(71, 17);
            this.cb_vendavel.TabIndex = 11;
            this.cb_vendavel.Text = "Vendável";
            this.cb_vendavel.UseVisualStyleBackColor = true;
            this.cb_vendavel.Click += new System.EventHandler(this.cb_vendavel_Click);
            // 
            // cb_arrendavel
            // 
            this.cb_arrendavel.AutoSize = true;
            this.cb_arrendavel.Location = new System.Drawing.Point(97, 314);
            this.cb_arrendavel.Name = "cb_arrendavel";
            this.cb_arrendavel.Size = new System.Drawing.Size(77, 17);
            this.cb_arrendavel.TabIndex = 10;
            this.cb_arrendavel.Text = "Arrendável";
            this.cb_arrendavel.UseVisualStyleBackColor = true;
            this.cb_arrendavel.Click += new System.EventHandler(this.cb_arrendavel_Click);
            // 
            // cb_proprietario
            // 
            this.cb_proprietario.FormattingEnabled = true;
            this.cb_proprietario.Location = new System.Drawing.Point(97, 287);
            this.cb_proprietario.Name = "cb_proprietario";
            this.cb_proprietario.Size = new System.Drawing.Size(294, 21);
            this.cb_proprietario.TabIndex = 9;
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Moradia Germinada",
            "Moradia",
            "Apartamento",
            "Barraco"});
            this.cb_tipo.Location = new System.Drawing.Point(97, 260);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(294, 21);
            this.cb_tipo.TabIndex = 8;
            // 
            // nud_pisos
            // 
            this.nud_pisos.Location = new System.Drawing.Point(97, 234);
            this.nud_pisos.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.nud_pisos.Name = "nud_pisos";
            this.nud_pisos.Size = new System.Drawing.Size(120, 20);
            this.nud_pisos.TabIndex = 7;
            // 
            // nud_wc
            // 
            this.nud_wc.Location = new System.Drawing.Point(97, 208);
            this.nud_wc.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.nud_wc.Name = "nud_wc";
            this.nud_wc.Size = new System.Drawing.Size(120, 20);
            this.nud_wc.TabIndex = 6;
            // 
            // nud_assoalhadas
            // 
            this.nud_assoalhadas.Location = new System.Drawing.Point(97, 182);
            this.nud_assoalhadas.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nud_assoalhadas.Name = "nud_assoalhadas";
            this.nud_assoalhadas.Size = new System.Drawing.Size(120, 20);
            this.nud_assoalhadas.TabIndex = 5;
            // 
            // nud_area
            // 
            this.nud_area.Location = new System.Drawing.Point(97, 156);
            this.nud_area.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nud_area.Name = "nud_area";
            this.nud_area.Size = new System.Drawing.Size(120, 20);
            this.nud_area.TabIndex = 4;
            // 
            // tb_andar
            // 
            this.tb_andar.Location = new System.Drawing.Point(97, 130);
            this.tb_andar.Name = "tb_andar";
            this.tb_andar.Size = new System.Drawing.Size(294, 20);
            this.tb_andar.TabIndex = 3;
            this.tb_andar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_andar_KeyPress);
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(97, 104);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(294, 20);
            this.tb_numero.TabIndex = 2;
            this.tb_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numero_KeyPress);
            // 
            // tb_rua
            // 
            this.tb_rua.Location = new System.Drawing.Point(97, 78);
            this.tb_rua.Name = "tb_rua";
            this.tb_rua.Size = new System.Drawing.Size(294, 20);
            this.tb_rua.TabIndex = 1;
            // 
            // tb_localidade
            // 
            this.tb_localidade.Location = new System.Drawing.Point(97, 52);
            this.tb_localidade.Name = "tb_localidade";
            this.tb_localidade.Size = new System.Drawing.Size(294, 20);
            this.tb_localidade.TabIndex = 0;
            // 
            // bt_nova
            // 
            this.bt_nova.Location = new System.Drawing.Point(635, 658);
            this.bt_nova.Name = "bt_nova";
            this.bt_nova.Size = new System.Drawing.Size(75, 23);
            this.bt_nova.TabIndex = 20;
            this.bt_nova.Text = "Nova";
            this.bt_nova.UseVisualStyleBackColor = true;
            this.bt_nova.Click += new System.EventHandler(this.bt_nova_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Enabled = false;
            this.bt_guardar.Location = new System.Drawing.Point(408, 658);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 23);
            this.bt_guardar.TabIndex = 19;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_apagar
            // 
            this.bt_apagar.Location = new System.Drawing.Point(3, 629);
            this.bt_apagar.Name = "bt_apagar";
            this.bt_apagar.Size = new System.Drawing.Size(362, 29);
            this.bt_apagar.TabIndex = 3;
            this.bt_apagar.Text = "Apagar";
            this.bt_apagar.UseVisualStyleBackColor = true;
            this.bt_apagar.Click += new System.EventHandler(this.bt_apagar_Click);
            // 
            // imo_DADataSet
            // 
            this.imo_DADataSet.DataSetName = "imo_DADataSet";
            this.imo_DADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casaSetBindingSource
            // 
            this.casaSetBindingSource.DataMember = "CasaSet";
            this.casaSetBindingSource.DataSource = this.imo_DADataSet;
            // 
            // casaSetTableAdapter
            // 
            this.casaSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArrendamentoSetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasaSet_CasaArrendavelTableAdapter = null;
            this.tableAdapterManager.CasaSet_CasaVendavelTableAdapter = null;
            this.tableAdapterManager.CasaSetTableAdapter = this.casaSetTableAdapter;
            this.tableAdapterManager.ClienteSetTableAdapter = null;
            this.tableAdapterManager.LimpezaSetTableAdapter = null;
            this.tableAdapterManager.ServicoSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoDA.imo_DADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendaSetTableAdapter = null;
            // 
            // casaSetDataGridView
            // 
            this.casaSetDataGridView.AllowUserToAddRows = false;
            this.casaSetDataGridView.AllowUserToDeleteRows = false;
            this.casaSetDataGridView.AllowUserToResizeRows = false;
            this.casaSetDataGridView.AutoGenerateColumns = false;
            this.casaSetDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.casaSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casaSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCasa,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.casaSetDataGridView.DataSource = this.casaSetBindingSource;
            this.casaSetDataGridView.Location = new System.Drawing.Point(3, 91);
            this.casaSetDataGridView.MultiSelect = false;
            this.casaSetDataGridView.Name = "casaSetDataGridView";
            this.casaSetDataGridView.ReadOnly = true;
            this.casaSetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.casaSetDataGridView.Size = new System.Drawing.Size(355, 532);
            this.casaSetDataGridView.TabIndex = 4;
            this.casaSetDataGridView.Click += new System.EventHandler(this.casaSetDataGridView_Click);
            // 
            // IdCasa
            // 
            this.IdCasa.DataPropertyName = "IdCasa";
            this.IdCasa.HeaderText = "IdCasa";
            this.IdCasa.Name = "IdCasa";
            this.IdCasa.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Localidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Localidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rua";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rua";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Casas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.casaSetDataGridView);
            this.Controls.Add(this.bt_apagar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_nova);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Casas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_assoalhadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_area)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imo_DADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaSetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_nova;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_limpezas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_venda_ver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_comissao_venda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_valor_venda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_arrendamento_ver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_comissao_arrendamento;
        private System.Windows.Forms.TextBox tb_valor_arrendamento;
        private System.Windows.Forms.ComboBox cb_proprietario;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.NumericUpDown nud_pisos;
        private System.Windows.Forms.NumericUpDown nud_wc;
        private System.Windows.Forms.NumericUpDown nud_assoalhadas;
        private System.Windows.Forms.NumericUpDown nud_area;
        private System.Windows.Forms.TextBox tb_andar;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.TextBox tb_rua;
        private System.Windows.Forms.TextBox tb_localidade;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bt_apagar;
        private System.Windows.Forms.CheckBox cb_vendavel;
        private System.Windows.Forms.CheckBox cb_arrendavel;
        private imo_DADataSet imo_DADataSet;
        private System.Windows.Forms.BindingSource casaSetBindingSource;
        private imo_DADataSetTableAdapters.CasaSetTableAdapter casaSetTableAdapter;
        private imo_DADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView casaSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
    }
}