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
    public partial class StudentskaSluyba : Form
    {
        private BindingList<Student> studenti;

        public StudentskaSluyba()
        {
            InitializeComponent();
            studenti = new BindingList<Student>();
            table.DataSource = studenti;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Entry form = new Entry(studenti);
            form.Show();
        }
    }
}
