namespace Projek_akhir_Alif_alfian
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iblPesan = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox3 = new ComboBox();
            dataGridView1 = new DataGridView();
            Kriteria = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Kriteria_is = new DataGridViewTextBoxColumn();
            Harga_is = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            txtTotal = new TextBox();
            txtBayar = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblkembalian = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // iblPesan
            // 
            iblPesan.AutoSize = true;
            iblPesan.BackColor = Color.Transparent;
            iblPesan.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iblPesan.ForeColor = SystemColors.ActiveCaptionText;
            iblPesan.Location = new Point(229, 10);
            iblPesan.Name = "iblPesan";
            iblPesan.Size = new Size(278, 37);
            iblPesan.TabIndex = 0;
            iblPesan.Text = "Kolam Berenang";
            iblPesan.TextAlign = ContentAlignment.MiddleCenter;
            iblPesan.Click += iblPesan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Kriteria :";
            label1.Click += label1_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dewasa", "Anak-Anak", "Remaja" });
            comboBox1.Location = new Point(144, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "10000", "20000", "25000" });
            comboBox2.Location = new Point(212, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 21;
            label2.Text = "Harga Tiket&kolam :";
            label2.Click += label2_Click_3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(14, 173);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 22;
            label3.Text = "Jumlah Tiket :";
            label3.Click += label3_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox3.Location = new Point(182, 169);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Kriteria, Harga });
            dataGridView1.Location = new Point(547, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(297, 144);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Kriteria
            // 
            Kriteria.HeaderText = "Kriteria";
            Kriteria.MinimumWidth = 6;
            Kriteria.Name = "Kriteria";
            Kriteria.ReadOnly = true;
            Kriteria.Width = 125;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga Tiket";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            Harga.ReadOnly = true;
            Harga.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Kriteria_is, Harga_is, Jumlah, Total });
            dataGridView2.Location = new Point(14, 251);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(529, 133);
            dataGridView2.TabIndex = 25;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Kriteria_is
            // 
            Kriteria_is.HeaderText = "Kriteria";
            Kriteria_is.MinimumWidth = 6;
            Kriteria_is.Name = "Kriteria_is";
            Kriteria_is.ReadOnly = true;
            Kriteria_is.Width = 125;
            // 
            // Harga_is
            // 
            Harga_is.HeaderText = "Harga Tiket";
            Harga_is.MinimumWidth = 6;
            Harga_is.Name = "Harga_is";
            Harga_is.ReadOnly = true;
            Harga_is.Width = 125;
            // 
            // Jumlah
            // 
            Jumlah.HeaderText = "Jumlah Tiket";
            Jumlah.MinimumWidth = 6;
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            Jumlah.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total Harga";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(58, 213);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 26;
            button1.Text = "PESAN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(249, 213);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 27;
            button2.Text = "BATAL PESANAN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(511, 390);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 28;
            // 
            // txtBayar
            // 
            txtBayar.Location = new Point(511, 424);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(125, 27);
            txtBayar.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(347, 394);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 30;
            label4.Text = "Total harga :";
            label4.Click += label4_Click_2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(347, 428);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 31;
            label5.Text = "Jumlah Uang :";
            label5.Click += label5_Click;
            // 
            // lblkembalian
            // 
            lblkembalian.AutoSize = true;
            lblkembalian.BackColor = Color.Black;
            lblkembalian.ForeColor = Color.Yellow;
            lblkembalian.Location = new Point(565, 475);
            lblkembalian.Name = "lblkembalian";
            lblkembalian.Size = new Size(132, 20);
            lblkembalian.TabIndex = 33;
            lblkembalian.Text = "Kembalian muncul";
            lblkembalian.Click += label6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 128);
            button3.Location = new Point(449, 475);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 34;
            button3.Text = "BAYAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kolam;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(856, 529);
            Controls.Add(button3);
            Controls.Add(lblkembalian);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBayar);
            Controls.Add(txtTotal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(iblPesan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label iblPesan;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Kriteria;
        private DataGridViewTextBoxColumn Harga;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Kriteria_is;
        private DataGridViewTextBoxColumn Harga_is;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Total;
        private Button button1;
        private Button button2;
        private TextBox txtTotal;
        private TextBox txtBayar;
        private Label label4;
        private Label label5;
        private Label lblkembalian;
        private Button button3;
    }
}
