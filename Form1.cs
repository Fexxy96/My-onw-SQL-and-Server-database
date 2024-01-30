using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_onw_SQL__and_Server_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fEXXY_FUELSDataSet.FUEL_RECON' table. You can move, or remove it, as needed.
            this.fUEL_RECONTableAdapter.Fill(this.fEXXY_FUELSDataSet.FUEL_RECON);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fUELRECONBindingSource.AddNew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fUELRECONBindingSource.EndEdit();
            fUEL_RECONTableAdapter.Update(fEXXY_FUELSDataSet.FUEL_RECON);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fUELRECONBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
fUELRECONBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fUELRECONBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fUELRECONBindingSource.MovePrevious();  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fUELRECONBindingSource.MoveNext();
        }
    }
}
