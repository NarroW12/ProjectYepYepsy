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
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, "pictures", "form3", "Jak_Działa_gra.txt");
            //var fileText = File.ReadAllText(filePath);
            //labelHelper.Text = fileText;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    labelHelper.Text = line;
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(currentDirectory, "pictures", "form3", "Jak_Działa_gra.txt");
            //var fileText = File.ReadAllText(filePath);
            //labelHelper.Text = fileText;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    labelHelper.Text = line;
                }
            }
        }
    }
}
