using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Rota : " + comboBox1.Text + "  -  " + comboBox2.Text 
                + " Tarih : " + dateTimePicker1.Text 
                + " Saat : " + maskedTextBox1.Text + "\t"
                + " Yolcu Bilgileri : " + textBox1.Text
                + " TC : " + maskedTextBox2.Text 
                + " Telefon : " + maskedTextBox3.Text );

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
