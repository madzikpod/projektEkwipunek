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
    public partial class OknoPrzedmiotowForm : Form
    {
        SklepForm sklepForm;
        Przedmiot PrzekanyPrzedmiot;
        public OknoPrzedmiotowForm(SklepForm sklep, Przedmiot przedmiot = null)
        {
            InitializeComponent();

            
            sklepForm = sklep;

            var typy = Enum.GetNames(typeof(TypPrzedmiotu));
            TypComboBox.DataSource = new List<string>(typy);

            var kto = Enum.GetNames(typeof(KtoMozeNosic));
            KtocomboBox.DataSource = new List<string>(kto);

            PrzekanyPrzedmiot = przedmiot;
            if (przedmiot != null)
            {
                TypComboBox.SelectedItem = przedmiot.Typ.ToString();
                KtocomboBox.SelectedItem = przedmiot.OgraniczeniaKlasowe.ToString();
                NazwaTextBox.Text = przedmiot.Nazwa;
                WagaNumericUpDown.Value = (decimal)przedmiot.Waga;
                foreach (string wlasciwosc in przedmiot.Wlasciwosci)
                {
                    WlasciwosciListView.Items.Add(wlasciwosc);
                }
                if (przedmiot.Wymagania.ContainsKey(StatystykiPostaci.Moc) && przedmiot.Wymagania[StatystykiPostaci.Moc] != 0)
                {
                    WMocNumericUpDown.Value =(decimal)przedmiot.Wymagania[StatystykiPostaci.Moc];
                }
                if (przedmiot.Wymagania.ContainsKey(StatystykiPostaci.Inteligencja) && przedmiot.Wymagania[StatystykiPostaci.Inteligencja] != 0)
                {
                    WInteligencjanumericUpDown.Value = (decimal)przedmiot.Wymagania[StatystykiPostaci.Inteligencja];
                }
                if (przedmiot.Wymagania.ContainsKey(StatystykiPostaci.Obrona) && przedmiot.Wymagania[StatystykiPostaci.Obrona] != 0)
                {
                    WObronaNumericUpDown.Value = (decimal)przedmiot.Wymagania[StatystykiPostaci.Obrona];
                }

                foreach (var bonus in przedmiot.Bonusy)
                {
                    switch (bonus.DoCzego)
                    {
                        case StatystykiPostaci.Moc:
                            BMocNumericUpDown.Value =(decimal) bonus.Premia;
                            break;
                        case StatystykiPostaci.Inteligencja:
                            BInteligencjaNumericUpDown.Value = (decimal)bonus.Premia;
                            break;
                        case StatystykiPostaci.Obrona:
                            BObronaNumericUpDown.Value = (decimal)bonus.Premia;
                            break;
                        default:
                            break;
                    }
                }

            }

        }

        private void OknoPrzedmiotowForm_Load(object sender, EventArgs e)
        {

            sklepForm.Visible = false;
        }



        private void OknoPrzedmiotowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sklepForm.Visible = true;
        }

        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NazwaTextBox.Text))
            {
                MessageBox.Show("Musisz wpisac Nazwę");
                return;
            }
            var typ = (TypPrzedmiotu)Enum.Parse(typeof(TypPrzedmiotu), TypComboBox.SelectedItem.ToString());
            string nazwa = NazwaTextBox.Text;
            double waga = (double)WagaNumericUpDown.Value;
            var listaBonusow = new List<Bonus>();
            var listaWlasciwosci = new List<string>();
            var kto = (KtoMozeNosic)Enum.Parse(typeof(KtoMozeNosic), KtocomboBox.SelectedItem.ToString());
            var wymagania = new Dictionary<StatystykiPostaci, double>();
            if (BMocNumericUpDown.Value != 0)
            {
                listaBonusow.Add(new Bonus { DoCzego = StatystykiPostaci.Moc, Premia = (double)BMocNumericUpDown.Value });
            }
            if (BInteligencjaNumericUpDown.Value != 0)
            {
                listaBonusow.Add(new Bonus { DoCzego = StatystykiPostaci.Inteligencja, Premia = (double)BInteligencjaNumericUpDown.Value });
            }
            if (BObronaNumericUpDown.Value != 0)
            {
                listaBonusow.Add(new Bonus { DoCzego = StatystykiPostaci.Obrona, Premia = (double)BObronaNumericUpDown.Value });
            }
            foreach (ListViewItem i in WlasciwosciListView.Items)
            {
                listaWlasciwosci.Add(i.Text);
            }
            if (WMocNumericUpDown.Value != 0)
            {
                wymagania.Add(StatystykiPostaci.Moc, (double)WMocNumericUpDown.Value);
            }
            if (WInteligencjanumericUpDown.Value != 0)
            {
                wymagania.Add(StatystykiPostaci.Inteligencja, (double)WInteligencjanumericUpDown.Value);
            }
            if (WObronaNumericUpDown.Value != 0)
            {
                wymagania.Add(StatystykiPostaci.Obrona, (double)WObronaNumericUpDown.Value);
            }
            if (PrzekanyPrzedmiot == null)
            {
                Przedmiot przedmiot = new Przedmiot(typ, nazwa, waga, listaBonusow, listaWlasciwosci, kto, wymagania);
                Gra.ListaPrzedmiotow.Add(przedmiot);
            }else
            {
                PrzekanyPrzedmiot.Nazwa = nazwa;
                PrzekanyPrzedmiot.Typ = typ;
                PrzekanyPrzedmiot.Waga = waga;
                PrzekanyPrzedmiot.Bonusy.Clear();
                PrzekanyPrzedmiot.Bonusy.AddRange(listaBonusow);
                PrzekanyPrzedmiot.Wlasciwosci.Clear();
                PrzekanyPrzedmiot.Wlasciwosci.AddRange(listaWlasciwosci);
                PrzekanyPrzedmiot.OgraniczeniaKlasowe = kto;
                PrzekanyPrzedmiot.Wymagania = wymagania;
            }
            
            sklepForm.WyswietlListePrzedmiotow();
            this.Close();

        }
        List<string> listaWlasciwosci = new List<string>();

        private void DodajWlasciwoscButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = WlasciwosciListView.Items.Add(string.Empty);
            item.BeginEdit();
        }

        private void UsunWlasciwoscButton_Click(object sender, EventArgs e)
        {
            if (WlasciwosciListView.SelectedItems.Count > 0)
            {
                foreach (var zaznaczonyelement in WlasciwosciListView.SelectedItems)
                {
                    WlasciwosciListView.Items.Remove(zaznaczonyelement as ListViewItem);
                }

            }

        }
    }
}
