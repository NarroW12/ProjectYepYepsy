using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YepYeps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2Gra form2= new Form2Gra();
            form2.ShowDialog();
            this.Hide();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Form3Helper helper = new Form3Helper();
            helper.ShowDialog();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
