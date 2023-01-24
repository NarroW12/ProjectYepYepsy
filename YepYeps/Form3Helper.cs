using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YepYeps
{
    public partial class Form3Helper : Form
    {
        public Form3Helper()
        {
            InitializeComponent();
            labelHelper.AutoEllipsis = true;
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                var filePath = Path.Combine(currentDirectory, "pictures", "form3", "Jak_Działa_gra.txt");
                var fileText = File.ReadAllText(filePath);
                labelHelper.Text = fileText;
              
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void test_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
