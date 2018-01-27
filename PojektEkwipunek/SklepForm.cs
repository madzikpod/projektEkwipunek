using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjektEkwipunek
{
    public partial class SklepForm : Form
    {
        Form1 GlownyForm;
        public SklepForm(Postac postac, Form1 form)
        {
            Postac = postac;
            InitializeComponent();
            GlownyForm = form;

        }
        private void WyswietlListePrzedmiotow()
        {
            DataTable dataTable;

            dataTable = new DataTable();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            ListaPrzedmiotowGrid.DataSource = bindingSource;

            dataTable.Clear();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Typ");
            dataTable.Columns.Add("Nazwa");
            dataTable.Columns.Add("Waga");
            dataTable.Columns.Add("Wymagania");
            dataTable.Columns.Add("Właściwości");
            dataTable.Columns.Add("Bonusy");

            foreach (var przedmiot in Gra.ListaPrzedmiotow)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = przedmiot.Id;
                row["Typ"] = przedmiot.Typ;
                row["Nazwa"] = przedmiot.Nazwa;
                row["Waga"] = przedmiot.Waga;
                string wymog = "";
                foreach (var item in przedmiot.Wymagania)
                {
                    wymog += item.Key.ToString() + " = " + item.Value.ToString();
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
            }
            ListaPrzedmiotowGrid.Columns["Id"].Visible = false;
        }

        private Postac Postac;
        private void SklepForm_Load(object sender, EventArgs e)
        {
            WyswietlListePrzedmiotow();
            this.chart1.Titles.Add("Statystyki");
            GlownyForm.Visible = false;
            ZalozButton.Text = "Załóż " + Postac.Imie;

        }

        private void ListaPrzedmiotowGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var bonusy = Gra.ListaPrzedmiotow[e.RowIndex].Bonusy;
            double moc = 0;
            double obrona = 0;
            double udziwg = 0;
            double inteligencja = 0;

            foreach (var bonus in bonusy)
            {
                if (bonus.DoCzego == StatystykiPostaci.Inteligencja)
                {
                    inteligencja += bonus.Premia;
                }
                if (bonus.DoCzego == StatystykiPostaci.Moc)
                {
                    moc += bonus.Premia;
                }
                if (bonus.DoCzego == StatystykiPostaci.Obrona)
                {
                    obrona += bonus.Premia;
                }
            }
            string[] seriesArray = { "Moc", "Obrona", "Inteligencja" };
            double[] pointsArray = { moc, obrona, inteligencja };

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.

            this.chart1.Series.Clear();
            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray[i]);

                // Add point.
                series.Points.Add(pointsArray[i]);
            }
            this.chart1.ResetAutoValues();
        }

        private void SklepForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlownyForm.Visible = true;
        }

        private void ZalozButton_Click(object sender, EventArgs e)
        {
            int rowIndex = this.ListaPrzedmiotowGrid.SelectedCells[0].RowIndex;
            var przedmiot = Gra.ListaPrzedmiotow[rowIndex];
            if (Postac.Obciazenie + Gra.ListaPrzedmiotow[rowIndex].Waga <= Postac.Udzwig && !Postac.Ekwipunek.Any(p => p.Id == przedmiot.Id))
            {
                Postac.Ekwipunek.Add(Gra.ListaPrzedmiotow[rowIndex]);
                MessageBox.Show("Przedmiot został dodany do ekwipunku");
                
                GlownyForm.Wyswietl(Postac);
            }
            else
            {
                MessageBox.Show("Nie można dodać do ekwipunku");
            }
        }
    }
}
