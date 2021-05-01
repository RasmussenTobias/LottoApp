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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RowGenerator.RowGen(Int32.Parse(comboBox1.Text));
        }
    }
}
