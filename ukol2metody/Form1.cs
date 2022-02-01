using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol2metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool JePrvocislo(int cislo)
        {
         
            if (cislo <= 1 || cislo % 2 == 0) { return false; }
            for (int i = 2; i <= cislo / 2; i++)
            {
                if (cislo % i == 0) { return false; }
            }
            return true;
        }
        public void prepis(TextBox textbox, ListBox listbox)
        {
            int vstuptext = int.Parse(textBox1.Text);
            Random rng = new Random();
            int[] rnd = new int[(vstuptext)];
            for (int i = 0; i < vstuptext; i++){ 

                rnd[i] = (rng.Next(2, 16));
                if (JePrvocislo(rnd[i]))
                {
                    listBox1.Items.Add(rnd[i].ToString());
                }
            }   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            prepis(textBox1,listBox1);
        }
    }
}
