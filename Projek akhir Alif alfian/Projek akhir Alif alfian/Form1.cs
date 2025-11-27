namespace Projek_akhir_Alif_alfian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Dewasa", "10.000");
            dataGridView1.Rows.Add("Anak-anak", "20.000");
            dataGridView1.Rows.Add("Remaja", "25.000");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iblPesan_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kriteria = comboBox1.SelectedItem?.ToString();
            string harga_tiket = comboBox2.SelectedItem?.ToString();
            string jumlah_tiket = comboBox3.SelectedItem?.ToString();
            string total_harga = $"{Convert.ToInt32(harga_tiket) * Convert.ToInt32(jumlah_tiket)}";
            dataGridView2.Rows.Add(kriteria, harga_tiket, jumlah_tiket, total_harga);

            txtTotal.Text = total_harga.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            else
                MessageBox.Show("Pilih baris pesanan yang ingin di hapus");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {


        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {

            //Menghitung kembalian
            if (!string.IsNullOrEmpty(txtBayar.Text))
            {
                if (Convert.ToDouble(txtBayar.Text) < Convert.ToDouble(txtTotal.Text))
                {
                    MessageBox.Show("Uang Kurang mbak/mas");
                    return;
                }

                double kembalian = Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtTotal.Text);
                lblkembalian.Text = $"{kembalian.ToString("N0")}";
            }
            else MessageBox.Show("Total bayar dapat terdefinisikan");
            return;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBayar.Text))
            {
                if (Convert.ToDouble(txtBayar.Text) < Convert.ToDouble(txtTotal.Text))
                {
                    MessageBox.Show("Uang kurang");

                   
                }
                double kembalian = Convert.ToDouble(txtBayar.Text) - Convert.ToDouble(txtTotal.Text);
                lblkembalian.Text = $"{kembalian}";
            }
            else MessageBox.Show("Error");
            return;
        }
    }
}
