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
    public partial class OknoPostaciForm : Form
    {
        Form1 OknoGlowne;
        Postac PrzekazanaPostac;
        public OknoPostaciForm(Form1 form,Postac postac=null)
        {
            OknoGlowne = form;
            InitializeComponent();
            PrzekazanaPostac = postac;


            var typy = Enum.GetNames(typeof(TypPostaci));
            TypComboBox.DataSource = new List<string>(typy);
            if (postac != null)
            {
                NazwaTextBox.Text = postac.Imie;
                LevelNumericUpDown.Value = postac.Level;
                LevelNumericUpDown.Minimum = postac.Level;
                TypComboBox.SelectedItem = postac.Klasa.Typ.ToString();
                TypComboBox.Enabled = false;
                OpisTextBox.Text = postac.Opis ?? postac.Klasa.Opis;

            }
            
        }

        private void OknoPostaciForm_Load(object sender, EventArgs e)
        {
            OknoGlowne.Visible = false;
        }

        private void OknoPostaciForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OknoGlowne.Visible = true;
        }

        private void ZapiszButton_onClic(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(NazwaTextBox.Text))
            {
                MessageBox.Show("Musisz wpisac Nazwę");
                return;
            }
            var typ = (TypPostaci)Enum.Parse(typeof(TypPostaci), TypComboBox.SelectedItem.ToString());
            string nazwa = NazwaTextBox.Text;
            int level = (int)LevelNumericUpDown.Value;
            string opis = OpisTextBox.Text;
            Postac postac = null;
            switch (typ)
            {

                case TypPostaci.TypowaGrazyna:
                    postac = new TypowaGrazyna(nazwa, level);
                    break;
                case TypPostaci.JanuszBiznesu:
                    postac = new JanuszBiznesu(nazwa, level);
                    break;
                case TypPostaci.Sebix:
                    postac = new Sebix(nazwa, level);
                    break;
                case TypPostaci.Gimbus:
                    postac = new Gimbus(nazwa, level);
                    break;
                default:
                    break;
            }
            postac.Opis = opis;

            if(postac==null)
            {
                OknoGlowne.bindinglist.Add(postac);
            }else
            {
                PrzekazanaPostac.Imie = nazwa;
                PrzekazanaPostac.Opis = opis;
                PrzekazanaPostac.LevelUp(level- PrzekazanaPostac.Level); //zwiekasznie o roznice (ten co bedzie mial minus nowy)
                PrzekazanaPostac.Level = level;
                OknoGlowne.Wyswietl(PrzekazanaPostac);

            }
            
            
            

            this.Close();
        }
    }
}
