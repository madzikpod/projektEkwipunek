using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektEkwipunek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Gra.ListaPostaci[0].Ekwipunek.Add(Gra.ListaPrzedmiotow[0]);
            Gra.ListaPostaci[0].Zaloz(CzescCiala.Glowa, Gra.ListaPostaci[0].Ekwipunek[0]);

            ListaPostaci.DataSource = Gra.ListaPostaci;
            ListaPostaci.DisplayMember = "Imie";

        }

        private void ListaPostaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            var zaznaczonaPostac = ((sender as ComboBox).SelectedItem as Postac);
            OpisPostaci.Text = zaznaczonaPostac.Opis??zaznaczonaPostac.Klasa.Opis;
            level.Text = zaznaczonaPostac.Level.ToString();
            udzwig.Text = zaznaczonaPostac.Ekwipunek.Sum(przedmiot=>przedmiot.Waga)  + "/" + zaznaczonaPostac.Udzwig.ToString();
            string sumaMocy = (zaznaczonaPostac.Moc + zaznaczonaPostac.BonusMoc).ToString();
            moc.Text = zaznaczonaPostac.BonusMoc == 0 ? sumaMocy 
                : sumaMocy + $" ({zaznaczonaPostac.Moc} + {zaznaczonaPostac.BonusMoc})";
            string sumaObrony = (zaznaczonaPostac.Obrona + zaznaczonaPostac.BonusObrona).ToString();
            obrona.Text = zaznaczonaPostac.BonusObrona == 0 ? sumaObrony
                : sumaObrony + $" ({zaznaczonaPostac.Obrona} + {zaznaczonaPostac.BonusObrona})";
            string sumaInteligencji = (zaznaczonaPostac.BonusInteligencja + zaznaczonaPostac.Inteligencja).ToString();
            inteligencja.Text = zaznaczonaPostac.BonusInteligencja == 0 ? sumaInteligencji
                : sumaInteligencji + $" ({zaznaczonaPostac.Inteligencja} + {zaznaczonaPostac.BonusInteligencja})";

        }
    }
}
