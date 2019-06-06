using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FudbalskiKlub
{
    public partial class Dodavanje : Form
    {
        private BindingList<Fudbaler> fudbaleri;

        private Fudbaler fudbaler;

        public Dodavanje(BindingList<Fudbaler> fudbaleri)
        {
            InitializeComponent();
            this.fudbaleri = fudbaleri;
            fudbaler = new Fudbaler();

            pozicija.DataSource = Enum.GetValues(typeof(Pozicija));
        }
        
        private bool CheckIme()
        {
            if (ime.Text.Length > 2)
            {
                fudbaler.Ime = ime.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Morate uneti ime (barem 3 slova dugacko)!");
                return false;
            }
        }

        private bool CheckPrezime()
        {
            if (prezime.Text.Length > 2)
            {
                fudbaler.Prezime = prezime.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Morate uneti prezime (barem 3 slova dugacko)!");
                return false;
            }
        }

        private bool CheckDatumRodjenja()
        {
            if (datumRodjenja.Value.CompareTo(DateTime.Now) < 0)
            {
                fudbaler.DatumRodjenja = datumRodjenja.Value;
                return true;
            }
            else
            {
                MessageBox.Show("Ne mozete uneti buduci datum!");
                return false;
            }
        }

        private bool CheckBrojDresa()
        {
            try
            {
                int broj = int.Parse(dres.Text);
                if (broj < 0)
                {
                    throw new Exception();
                }
                foreach(Fudbaler x in fudbaleri)
                {
                    if (x.BrojDresa == broj)
                    {
                        throw new DuplicateNameException();
                    }
                }
                fudbaler.BrojDresa = broj;
                return true;
            }
            catch (DuplicateNameException)
            {
                MessageBox.Show("Morate uneti unikatan broj dresa, neko vec ima taj broj!");
                return false;
            }
            catch
            {
                MessageBox.Show("Morate uneti validan broj dresa!");
                return false;
            }
        }

        private bool CheckPozicija()
        {
            fudbaler.Pozicija = (Pozicija)pozicija.SelectedIndex;
            return true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (CheckIme() && CheckPrezime() && CheckDatumRodjenja() && CheckBrojDresa() && CheckPozicija())
            {
                fudbaleri.Add(fudbaler);
                Close();
            }
        }
    }
}
