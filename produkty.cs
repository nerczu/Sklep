using Sklep.ServiceReference1;
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
    public partial class produkty : Form
    {
        public produkty()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produkt prod = new produkt();
            prod.ID = Convert.ToInt32(txtID.Text);
            prod.Nazwa = txtNazwa.Text;
            prod.Netto = Convert.ToSingle(txtNetto.Text);
            prod.Vat = Convert.ToInt32(txtVat.Text);
            prod.Brutto = Convert.ToSingle(txtBrutto.Text);
            prod.Ilosc = Convert.ToSingle(txtIlosc.Text);
            prod.Kat = comboBox1.Text;


            Service1Client service = new Service1Client();

            if (service.Dodajprodukt(prod) == 1)
            {
                MessageBox.Show("Produkt dodany pomyślnie");
            } 
        }
    }
}
