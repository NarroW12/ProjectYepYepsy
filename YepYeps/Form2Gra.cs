using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YepYeps
{
    public partial class Form2Gra : Form
    {
        private int[] liczby = new int[1000];
        Random random = new Random();
        private bool graRozpoczeta = false;
        SoundPlayer player;
        private int ile = 0;
        private int licznik =0;
        private void Liczby_wygenerowane()
        {
            for (int i = 0; i < 1000; i++)
            {
                liczby[i] = random.Next(1, 6);
            }
        }
        void sekwencja() 
        {
            Liczby_wygenerowane();
            Application.DoEvents();
            Thread.Sleep(1000);
            string currentDirectory = Directory.GetCurrentDirectory();


            string fileName1 = "p1.png";
            string path1 = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName1);
            z1.Image = Image.FromFile(path1);

            string fileName2 = "p2.png";
            string path2 = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName2);
            z2.Image = Image.FromFile(path2);

            string fileName3 = "p3.png";
            string path3 = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName3);
            z3.Image = Image.FromFile(path3);

            string fileName4 = "p4.png";
            string path4 = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName4);
            z4.Image = Image.FromFile(path4);

            string fileName5 = "p5.png";
            string path5 = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName5);
            z5.Image = Image.FromFile(path5);


            z1.Enabled = false;
            z2.Enabled = false;
            z3.Enabled = false;
            z4.Enabled = false;
            z5.Enabled = false;
            label1.Text = "Następna runda za: 2";
            Application.DoEvents();
            Thread.Sleep(1000);
            label1.Text = "Następna runda za: 1";
            Application.DoEvents();
            Thread.Sleep(1000);
            label1.Text = "Zapamietaj sekwencje";
            ile++;
            for (int i=0; i<ile;i++) 
            {
                switch (liczby[i]) 
                {
                    case 1:
                        string fileName = "d1.wav";
                        string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                        player = new SoundPlayer(relativePath);
                        player.Play();
                        z1a.Visible = true;
                        break;
                    case 2:
                        fileName = "d2.wav";
                        relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                        player = new SoundPlayer(relativePath);
                        player.Play();
                        z2a.Visible = true;
                        break;
                    case 3:
                        fileName = "d3.wav";
                        relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                        player = new SoundPlayer(relativePath);
                        player.Play();
                        z3a.Visible = true;
                        break;
                    case 4:
                        fileName = "d4.wav";
                        relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                        player = new SoundPlayer(relativePath);
                        player.Play();
                        z4a.Visible = true;
                        break;
                    case 5:
                        fileName = "d5.wav";
                        relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                        player = new SoundPlayer(relativePath);
                        player.Play();
                        z5a.Visible = true;
                        break;
                }
                Application.DoEvents();
                Thread.Sleep(1200);
                z1a.Visible = false; 
                z2a.Visible = false; 
                z3a.Visible = false;
                z4a.Visible = false;
                z5a.Visible = false;
                Application.DoEvents();
                Thread.Sleep(100);
            }
            z1.Enabled = true;
            z2.Enabled = true;
            z3.Enabled = true;
            z4.Enabled = true;
            z5.Enabled = true;
            label1.Text = "Powtorz sekwencję";
            licznik = 0;
        }

        public Form2Gra()
        {
            InitializeComponent();
        }

        private void Z1_Click(object sender, EventArgs e)
        {
            if (graRozpoczeta == true) 
            {
                licznik++;
                if (liczby[licznik - 1] != 1) 
                {
                    ile--;
                    label1.Text = "Skucha. Twoj wynik to:" + ile.ToString();
                    string currentDirectory = Directory.GetCurrentDirectory();

                    string fileName = "koniec.wav";
                    string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                    player = new SoundPlayer(relativePath);
                    player.Play();
                    graRozpoczeta = false;
                }
                if (licznik == ile) 
                {
                    label1.Text = "DOSKONALE!";
                    sekwencja();                
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (graRozpoczeta==false) 
            { 
                graRozpoczeta = true;
                string currentDirectory = Directory.GetCurrentDirectory();
                string fileName = "start.wav";
                string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                player = new SoundPlayer(relativePath);
                player.Play();
                sekwencja();
            }
        }

        private void z1a_Click(object sender, EventArgs e)
        {

        }

        private void z2_Click(object sender, EventArgs e)
        {
            licznik++;
            if (liczby[licznik - 1] != 2)
            {
                ile--;
                label1.Text = "Skucha. Twoj wynik to:" + ile.ToString();
                string currentDirectory = Directory.GetCurrentDirectory();

                string fileName = "koniec.wav";
                string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                player = new SoundPlayer(relativePath);
                player.Play();
                graRozpoczeta = false;
            }
            if (licznik == ile)
            {
                label1.Text = "DOSKONALE!";
                sekwencja();
            }
        }

        private void z3_Click(object sender, EventArgs e)
        {
            licznik++;
            if (liczby[licznik - 1] != 3)
            {
                ile--;
                label1.Text = "Skucha. Twoj wynik to:" + ile.ToString();
                string currentDirectory = Directory.GetCurrentDirectory();

                string fileName = "koniec.wav";
                string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                player = new SoundPlayer(relativePath);
                player.Play();
                graRozpoczeta = false;
            }
            if (licznik == ile)
            {
                label1.Text = "DOSKONALE!";
                sekwencja();
            }
        }

        private void z4_Click(object sender, EventArgs e)
        {
            licznik++;
            if (liczby[licznik - 1] != 4)
            {
                ile--;
                label1.Text = "Skucha. Twoj wynik to:" + ile.ToString();
                string currentDirectory = Directory.GetCurrentDirectory();

                string fileName = "koniec.wav";
                string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                player = new SoundPlayer(relativePath);
                player.Play();
                graRozpoczeta = false;
            }
            if (licznik == ile)
            {
                label1.Text = "DOSKONALE!";
                sekwencja();
            }
        }

        private void z5_Click(object sender, EventArgs e)
        {
            licznik++;
            if (liczby[licznik - 1] != 5)
            {
                ile--;
                label1.Text = "Skucha. Twoj wynik to:" + ile.ToString();
                string currentDirectory = Directory.GetCurrentDirectory();

                string fileName = "koniec.wav";
                string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileName);
                player = new SoundPlayer(relativePath);
                player.Play();
                graRozpoczeta = false;
            }
            if (licznik == ile)
            {
                label1.Text = "DOSKONALE!";
                sekwencja();
            }
        }

        private void z1_MouseDown(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p1a.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z1.Image = Image.FromFile(path);

            string fileNameSound = "d1.wav";
            string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileNameSound);
            player = new SoundPlayer(relativePath);
            player.Play();
        }

        private void z1_MouseUp(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p1.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z1.Image = Image.FromFile(path);
        }

        private void z2_MouseDown(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p2a.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z2.Image = Image.FromFile(path);

            string fileNameSound = "d2.wav";
            string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileNameSound);
            player = new SoundPlayer(relativePath);
            player.Play();
        }

        private void z2_MouseUp(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p2.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z2.Image = Image.FromFile(path);
        }

        private void z3_MouseDown(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p3a.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z3.Image = Image.FromFile(path);

            string fileNameSound = "d3.wav";
            string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileNameSound);
            player = new SoundPlayer(relativePath);
            player.Play();
        }

        private void z3_MouseUp(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p3.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z3.Image = Image.FromFile(path);
        }

        private void z4_MouseDown(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p4a.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z4.Image = Image.FromFile(path);

            string fileNameSound = "d4.wav";
            string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileNameSound);
            player = new SoundPlayer(relativePath);
            player.Play();
        }

        private void z4_MouseUp(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p4.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z4.Image = Image.FromFile(path);
        }

        private void z5_MouseDown(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p5a.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z5.Image = Image.FromFile(path);

            string fileNameSound = "d5.wav";
            string relativePath = Path.Combine(currentDirectory, "pictures\\form2\\snd", fileNameSound);
            player = new SoundPlayer(relativePath);
            player.Play();
        }

        private void z5_MouseUp(object sender, MouseEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fileName = "p5.png";
            string path = Path.Combine(Directory.GetCurrentDirectory(), "pictures\\form2\\img\\nowe zarowki", fileName);
            z5.Image = Image.FromFile(path);
        }
    }
}
