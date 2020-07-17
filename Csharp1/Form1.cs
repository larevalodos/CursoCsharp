using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listNames= new List<string>();    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listNames.Add(textBox1.Text);


            listBox1.DataSource = null;
            listBox1.DataSource = listNames;

            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show();
                listNames.Remove(listBox1.SelectedItem.ToString());
                listBox1.DataSource = null;
                listBox1.DataSource = listNames;


                label4.Text = listBox1.Items.Count.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe estar seleccionado un campo");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                //button1.Focus();   Quitamos este focus
                //Mejor pongamos otra cosa
                listNames.Add(textBox1.Text);

                listBox1.DataSource = null;
                listBox1.DataSource = listNames;

                textBox1.Clear();
                textBox1.Focus();

                label4.Text= listBox1.Items.Count.ToString();
            }
        }
    }
}
