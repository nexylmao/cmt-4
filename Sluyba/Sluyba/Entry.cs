using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sluyba
{
    public partial class Entry : Form
    {
        private BindingList<Student> studenti;

        private Student student;

        public Entry(BindingList<Student> studenti)
        {
            InitializeComponent();
            this.studenti = studenti;
            student = new Student();
            smer.DataSource = Enum.GetNames(typeof(Smer));
        }

        private void Check()
        {
            if (CheckIndex() &&
                CheckIme() &&
                CheckPrezime() &&
                CheckDatum() &&
                CheckImeRoditelja() &&
                CheckPol() &&
                CheckSmer() &&
                CheckGodine())
            {
                Create();
            }
        }

        private void Create()
        {
            try
            {
                studenti.Add(student);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckIndex()
        {
            try
            {
                int unos;
                if (!int.TryParse(index.Text, out unos))
                {
                    throw new Exception("Molimo vas unesite broj za index!");
                }
                foreach (Student x in studenti)
                {
                    if (x.BrojIndeksa == unos)
                    {
                        throw new Exception("Molimo vas, unesite unikatan broj indexa!");
                    }
                }
                student.BrojIndeksa = unos;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CheckIme()
        {
            if (ime.Text.Length <= 2)
            {
                MessageBox.Show("Ime mora biti dugacko barem 3 karaktera!");
                return false;
            }
            student.Ime = ime.Text;
            return true;
        }

        private bool CheckPrezime()
        {
            if (prezime.Text.Length <= 2)
            {
                MessageBox.Show("Prezime mora biti dugacko barem 3 karaktera!");
                return false;
            }
            student.Prezime = prezime.Text;
            return true;
        }

        private bool CheckDatum()
        {
            try
            {
                DateTime now = DateTime.Now;
                DateTime godine = new DateTime(now.Year - 18, now.Month, now.Day);
                if (datumRodjenja.Value.CompareTo(godine) >= 0) {
                    throw new Exception("Vi nemate ni 18 godina!");
                }
                student.DatumRodjenja = datumRodjenja.Value;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CheckImeRoditelja()
        {
            if (imeRoditelja.Text.Length <= 2)
            {
                MessageBox.Show("Ime roditelja mora biti dugacko barem 3 karaktera!");
                return false;
            }
            student.ImeRoditelja = imeRoditelja.Text;
            return true;
        }

        private bool CheckPol()
        {
            if (radio_muski.Checked)
            {
                student.Pol = Pol.Muski;
                return true;
            }
            else if (radio_zenski.Checked)
            {
                student.Pol = Pol.Zenski;
                return true;
            }
            else if (radio_ostalo.Checked)
            {
                student.Pol = Pol.Ostalo;
                return true;
            }
            else
            {
                MessageBox.Show("Morate izabrati pol!");
                return false;
            }
        }

        private bool CheckSmer()
        {
            if (smer.SelectedIndex >= 0)
            {
                student.Smer = (Smer)Enum.GetValues(typeof(Smer)).GetValue(smer.SelectedIndex);
                return true;
            }
            else
            {
                MessageBox.Show("Morate izabrati smer!");
                return false;
            }
        }

        private bool CheckGodine()
        {
            try
            {
                int unos;
                if (!int.TryParse(godina.Text, out unos))
                {
                    throw new Exception("Molimo vas unesite broj za godinu!");
                }
                if (unos <= 0)
                {
                    throw new Exception("Molimo vas unesite pozitivan broj za godinu!");
                }
                student.Godina = unos;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
