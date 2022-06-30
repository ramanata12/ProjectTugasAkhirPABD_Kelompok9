namespace TokoPunakawan1
{
    partial class Pemesanan
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
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Jenis_Menu = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Harga = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Nama_Makanan = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Kasir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Id_Pemesanan = new System.Windows.Forms.TextBox();
            this.cb_Menu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toko_Punakawan2DataSet = new TokoPunakawan1.Toko_Punakawan2DataSet();
            this.menuMakananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu_MakananTableAdapter = new TokoPunakawan1.Toko_Punakawan2DataSetTableAdapters.Menu_MakananTableAdapter();
            this.pemesanananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesanananTableAdapter = new TokoPunakawan1.Toko_Punakawan2DataSetTableAdapters.PemesanananTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Kasir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_Punakawan2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMakananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 51;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Jenis_Menu);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Harga);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Nama_Makanan);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cb_Kasir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Id_Pemesanan);
            this.panel1.Controls.Add(this.cb_Menu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(14, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 367);
            this.panel1.TabIndex = 50;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 22);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // Jenis_Menu
            // 
            this.Jenis_Menu.Location = new System.Drawing.Point(211, 180);
            this.Jenis_Menu.Name = "Jenis_Menu";
            this.Jenis_Menu.Size = new System.Drawing.Size(166, 22);
            this.Jenis_Menu.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 36);
            this.button3.TabIndex = 46;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Harga
            // 
            this.Harga.Location = new System.Drawing.Point(211, 225);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(166, 22);
            this.Harga.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 45;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nama_Makanan
            // 
            this.Nama_Makanan.Location = new System.Drawing.Point(211, 146);
            this.Nama_Makanan.Name = "Nama_Makanan";
            this.Nama_Makanan.Size = new System.Drawing.Size(166, 22);
            this.Nama_Makanan.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 36);
            this.button4.TabIndex = 40;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cb_Kasir
            // 
            this.cb_Kasir.FormattingEnabled = true;
            this.cb_Kasir.Location = new System.Drawing.Point(211, 64);
            this.cb_Kasir.Name = "cb_Kasir";
            this.cb_Kasir.Size = new System.Drawing.Size(166, 24);
            this.cb_Kasir.TabIndex = 44;
            this.cb_Kasir.SelectedIndexChanged += new System.EventHandler(this.cb_Kasir_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "ID Kasir";
            // 
            // Id_Pemesanan
            // 
            this.Id_Pemesanan.Location = new System.Drawing.Point(211, 31);
            this.Id_Pemesanan.Name = "Id_Pemesanan";
            this.Id_Pemesanan.Size = new System.Drawing.Size(166, 22);
            this.Id_Pemesanan.TabIndex = 32;
            // 
            // cb_Menu
            // 
            this.cb_Menu.FormattingEnabled = true;
            this.cb_Menu.Location = new System.Drawing.Point(211, 104);
            this.cb_Menu.Name = "cb_Menu";
            this.cb_Menu.Size = new System.Drawing.Size(166, 24);
            this.cb_Menu.TabIndex = 42;
            this.cb_Menu.SelectedIndexChanged += new System.EventHandler(this.cb_Menu_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nama Makanan / Minuman";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID Pemesanan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Jenis Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Harga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Id_Kasir,
            this.Id_Menu,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Waktu});
            this.dataGridView1.DataSource = this.pemesanananBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(428, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 367);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // toko_Punakawan2DataSet
            // 
            this.toko_Punakawan2DataSet.DataSetName = "Toko_Punakawan2DataSet";
            this.toko_Punakawan2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuMakananBindingSource
            // 
            this.menuMakananBindingSource.DataMember = "Menu_Makanan";
            this.menuMakananBindingSource.DataSource = this.toko_Punakawan2DataSet;
            // 
            // menu_MakananTableAdapter
            // 
            this.menu_MakananTableAdapter.ClearBeforeFill = true;
            // 
            // pemesanananBindingSource
            // 
            this.pemesanananBindingSource.DataMember = "Pemesananan";
            this.pemesanananBindingSource.DataSource = this.toko_Punakawan2DataSet;
            // 
            // pemesanananTableAdapter
            // 
            this.pemesanananTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Pemesanan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Pemesanan";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Id_Kasir
            // 
            this.Id_Kasir.DataPropertyName = "Id_Kasir";
            this.Id_Kasir.HeaderText = "Id_Kasir";
            this.Id_Kasir.MinimumWidth = 6;
            this.Id_Kasir.Name = "Id_Kasir";
            // 
            // Id_Menu
            // 
            this.Id_Menu.DataPropertyName = "Id_Menu";
            this.Id_Menu.HeaderText = "Id_Menu";
            this.Id_Menu.MinimumWidth = 6;
            this.Id_Menu.Name = "Id_Menu";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama_Makanan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama_Makanan";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Jenis_Menu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Jenis_Menu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Harga";
            this.dataGridViewTextBoxColumn4.HeaderText = "Harga";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Waktu
            // 
            this.Waktu.DataPropertyName = "Waktu";
            this.Waktu.HeaderText = "Waktu";
            this.Waktu.MinimumWidth = 6;
            this.Waktu.Name = "Waktu";
            // 
            // Pemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1390, 487);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pemesanan";
            this.Text = "Pemesanan";
            this.Load += new System.EventHandler(this.Pemesanan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_Punakawan2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuMakananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesanananBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Jenis_Menu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Harga;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Nama_Makanan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Kasir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id_Pemesanan;
        private System.Windows.Forms.ComboBox cb_Menu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Toko_Punakawan2DataSet toko_Punakawan2DataSet;
        private System.Windows.Forms.BindingSource menuMakananBindingSource;
        private Toko_Punakawan2DataSetTableAdapters.Menu_MakananTableAdapter menu_MakananTableAdapter;
        private System.Windows.Forms.BindingSource pemesanananBindingSource;
        private Toko_Punakawan2DataSetTableAdapters.PemesanananTableAdapter pemesanananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Kasir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waktu;
    }
}