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
            liczbaPrzedmiotow.Text = (zaznaczonaPostac.Ekwipunek.Count()).ToString();

            
            var dataTable = new DataTable();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;

            dataTable.Clear();
            dataTable .Columns.Add("Typ");
            dataTable.Columns.Add("Nazwa");
            dataTable.Columns.Add("Waga");
            dataTable.Columns.Add("Wymagania");
            dataTable.Columns.Add("Właściwości");
            dataTable.Columns.Add("Bonusy");

            foreach (var przedmiot in zaznaczonaPostac.Ekwipunek)
            {

                DataRow row = dataTable.NewRow();
                row["Typ"] = przedmiot.Typ;
                row["Nazwa"] = przedmiot.Nazwa;
                row["Waga"] = przedmiot.Waga;
                string wymog="";
                foreach (var item in przedmiot.Wymagania)
                {
                    wymog += item.Key.ToString() +" = "+ item.Value.ToString();
                    wymog += ", \n";
                }
                row["Wymagania"] = wymog.Remove(wymog.Length - 3);
                string wlsciwosc = "";
                foreach (var item in przedmiot.Wlasciwosci)
                {
                    wlsciwosc += item + ", \n";

                }
                row["Właściwości"] = wlsciwosc.Remove(wlsciwosc.Length - 3);
                string bonus = "";
                foreach (var item in przedmiot.Bonusy)
                {
                    bonus += item.DoCzego + " = " + item.Premia;
                    bonus += ", \n";
                }
                row["Bonusy"] = bonus.Remove(bonus.Length - 3);
                //bonus = string.Join(", \n", przedmiot.Bonusy.Select(item => item.DoCzego + " = " + item.Premia));
                //row["Bonusy"] = bonus;

                 

                dataTable.Rows.Add(row);
                if (zaznaczonaPostac.NakrycieGlowy?.Id==przedmiot.Id|| zaznaczonaPostac.LewaReka?.Id== przedmiot.Id||zaznaczonaPostac.PrawaReka?.Id== przedmiot.Id||zaznaczonaPostac.Stroj?.Id== przedmiot.Id||zaznaczonaPostac.Buty?.Id== przedmiot.Id)
                {
                    dataGridView1.Rows[dataGridView1.RowCount - 1].DefaultCellStyle.BackColor = Color.Green;
                }
                
                

            }
            dataGridView1.Update();
            dataGridView1.Refresh();



        }
    }
}
