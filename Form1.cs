using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produkty produkty = new produkty();
            produkty.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pracownicy pracownicy = new pracownicy();
            pracownicy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faktury faktury = new faktury();
            faktury.Show();
        }
    }
}
