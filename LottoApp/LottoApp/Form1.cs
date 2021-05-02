using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lottoTicketsDataSet.WinningNumbers' table. You can move, or remove it, as needed.
            this.winningNumbersTableAdapter.Fill(this.lottoTicketsDataSet.WinningNumbers);
            label2.Text="DKK: "+AppStrings.balance.ToString();
            if(AppStrings.IsLoggedIn == false)
            {
                label1.Visible = false;
                label2.Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public void RowGen(int amount)
        {
            Random Winningrnd = new Random();
            Random Starrnd = new Random();
            int number = 0;
            for (int i = 0; i < amount; i++)
            {
                number++;                               
                string win = Winningrnd.Next(10000000, 99999999).ToString();
                string star = Starrnd.Next(9, 100).ToString();
                dataGridView2.Rows.Add(number.ToString(), win, star);
            }
            

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            RowGen(Int32.Parse(comboBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            RowGen(Int32.Parse(comboBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
