using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cipher1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orgtext = text.Text;
            string newkey = key.Text;
            int cipherkey = int.Parse(newkey);
            string cipher = "";
            for(int i = 0; i < orgtext.Length; i++)
            {
                cipher += (char)(orgtext[i] + cipherkey);
            }
            ciphertext.Text = cipher;
            text.Text = "";
            key.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string orgtext = cipherorg.Text;
            string newkey = deckey.Text;
            
            int cipherkey = int.Parse(newkey);
            string org = "";
            for (int i = 0; i < orgtext.Length; i++)
            {
                org += (char)(orgtext[i] - cipherkey);
            }
            textorg.Text = org;
            cipherorg.Text = "";
            deckey.Text = "";
        }

        private void deckey_TextChanged(object sender, EventArgs e)
        {

        }

        private void cipherorg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cipherorg.Text = "";
            deckey.Text = "";
            text.Text = "";
            key.Text = "";
            textorg.Text = "";
            ciphertext.Text = "";
        }
    }
}