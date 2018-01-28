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
        public BindingList<Postac> bindinglist;
        public Form1()
        {
            InitializeComponent();

            Gra.ListaPostaci[0].Ekwipunek.Add(Gra.ListaPrzedmiotow[0]);
            Gra.ListaPostaci[0].Zaloz(CzescCiala.Glowa, Gra.ListaPostaci[0].Ekwipunek[0]);
            Gra.ListaPostaci[0].Ekwipunek.Add(Gra.ListaPrzedmiotow[1]);


            //ListaPostaci.DataSource = Gra.ListaPostaci;
            bindinglist  = new BindingList<Postac>(Gra.ListaPostaci);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindinglist;
            ListaPostaci.DataSource = bSource;
            ListaPostaci.DisplayMember = "Imie";

        }
        DataTable dataTable;
        private void ListaPostaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            var zaznaczonaPostac = ((sender as ComboBox).SelectedItem as Postac);
            Wyswietl(zaznaczonaPostac);
        }

        public void Wyswietl(Postac zaznaczonaPostac)
        {
            if(zaznaczonaPostac == null) { return; }
            OpisPostaci.Text = zaznaczonaPostac.Opis ?? zaznaczonaPostac.Klasa.Opis;
            level.Text = zaznaczonaPostac.Level.ToString();
            udzwig.Text = zaznaczonaPostac.Ekwipunek.Sum(przedmiot => przedmiot.Waga) + "/" + zaznaczonaPostac.Udzwig.ToString();
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


            dataTable = new DataTable();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;

            dataTable.Clear();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Typ");
            dataTable.Columns.Add("Nazwa");
            dataTable.Columns.Add("Waga");
            dataTable.Columns.Add("Wymagania");
            dataTable.Columns.Add("Właściwości");
            dataTable.Columns.Add("Bonusy");

            foreach (var przedmiot in zaznaczonaPostac.Ekwipunek)
            {

                DataRow row = dataTable.NewRow();
                row["Id"] = przedmiot.Id;
                row["Typ"] = przedmiot.Typ;
                row["Nazwa"] = przedmiot.Nazwa;
                row["Waga"] = przedmiot.Waga;
                string wymog = "";
                if (przedmiot.Wymagania.Count != 0) // jezeli wymagania nie sa puste
                {
                    foreach (var item in przedmiot.Wymagania) // dla kazdego wymagania w przedmiocie
                    {
                        wymog += item.Key.ToString() + " = " + item.Value.ToString(); // okreslamy wymog na klucz i wartosc 
                        wymog += ", \n";
                    }
                    row["Wymagania"] = wymog.Remove(wymog.Length - 3); //do wiersza wiersz wymagania przypisujemy bez ostatnich trzech znakow (entera tabulatora i przecinka)
                }

                if (przedmiot.Wlasciwosci.Count != 0)
                {
                    string wlsciwosc = "";
                    foreach (var item in przedmiot.Wlasciwosci)
                    {
                        wlsciwosc += item + ", \n";

                    }
                    row["Właściwości"] = wlsciwosc.Remove(wlsciwosc.Length - 3);
                }

                if (przedmiot.Bonusy.Count != 0)
                {
                    string bonus = "";
                    foreach (var item in przedmiot.Bonusy)
                    {
                        bonus += item.DoCzego + " = " + item.Premia;
                        bonus += ", \n";
                    }
                    row["Bonusy"] = bonus.Remove(bonus.Length - 3);
                }



                dataTable.Rows.Add(row);
                if (zaznaczonaPostac.NakrycieGlowy?.Id == przedmiot.Id || zaznaczonaPostac.LewaReka?.Id == przedmiot.Id || zaznaczonaPostac.PrawaReka?.Id == przedmiot.Id || zaznaczonaPostac.Stroj?.Id == przedmiot.Id || zaznaczonaPostac.Buty?.Id == przedmiot.Id)
                {
                    dataGridView1.Rows[dataGridView1.RowCount - 1].DefaultCellStyle.BackColor = Color.Green;
                }

            }
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var postac = (ListaPostaci.SelectedItem as Postac);
            var prezedmiot= postac.Ekwipunek[e.RowIndex];
            var kolor = dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor;
            if (kolor == Color.Green)
            {
                //zdejmij i zmien kolor wiersza
                CzescCiala czescCiala = (CzescCiala)(-1);
                if(postac.LewaReka!=null&& postac.LewaReka.Id==prezedmiot.Id)
                {
                    czescCiala = CzescCiala.LewaReka;
                }
                if (postac.PrawaReka != null && postac.PrawaReka.Id == prezedmiot.Id)
                {
                    czescCiala = CzescCiala.PrawaReka;
                }
                if (postac.NakrycieGlowy != null && postac.NakrycieGlowy.Id == prezedmiot.Id)
                {
                    czescCiala = CzescCiala.Glowa;
                }
                if (postac.Stroj != null && postac.Stroj.Id == prezedmiot.Id)
                {
                    czescCiala = CzescCiala.Tulow;
                }
                if (postac.Buty != null && postac.Buty.Id == prezedmiot.Id)
                {
                    czescCiala = CzescCiala.Stopy;
                }
                if(czescCiala != (CzescCiala)(-1))
                {
                    postac.Zdejmij(czescCiala);
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                
            }
            else
            {
                var czesc = CzescCiala.Glowa;
                switch (prezedmiot.Typ)
                {
                    case TypPrzedmiotu.Bron:
                        if (postac.LewaReka==null)
                        {
                            czesc = CzescCiala.LewaReka;
                            break;
                        }
                        if(postac.PrawaReka==null)
                        {
                            czesc = CzescCiala.PrawaReka;
                            break;
                        }
                        MessageBox.Show("nie mozesz tego zalozyc");
                        return;
                        
                    case TypPrzedmiotu.Stroj:
                        czesc = CzescCiala.Tulow;
                        break;
                    case TypPrzedmiotu.Buty:
                        czesc = CzescCiala.Stopy;
                        break;
                    case TypPrzedmiotu.NakrycieGlowy:
                        czesc = CzescCiala.Glowa;
                        break;
                    default:
                        break;
                }
                // zaloz i zmien kolor
                try
                {
                    postac.Zaloz(czesc, prezedmiot);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ograniczenia klasowe, nie mozna zalozyc");
                    return;
                }
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
            Wyswietl(postac);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Wyswietl(ListaPostaci.SelectedItem as Postac);
            
        }

        private void Sklep_Click(object sender, EventArgs e)
        {
            var formSklep = new SklepForm(ListaPostaci.SelectedItem as Postac, this);
            formSklep.Show();

        }

        private void DodajPostacButton_Click(object sender, EventArgs e)
        {
            var okno = new OknoPostaciForm(this);
            okno.Show();
            this.Visible = false;
        }

        private void EdytujPostacButton_Click(object sender, EventArgs e)
        {
            var okno = new OknoPostaciForm(this,ListaPostaci.SelectedItem as Postac);
            okno.Show();
            this.Visible = false;
        }

        private void UsunPostacButton_Click(object sender, EventArgs e)
        {
            this.bindinglist.Remove(ListaPostaci.SelectedItem as Postac);
        }
    }
}
