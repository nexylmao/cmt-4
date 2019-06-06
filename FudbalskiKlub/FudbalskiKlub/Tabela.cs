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
    public partial class Tabela : Form
    {
        private BindingList<Fudbaler> fudbaleri;

        public Tabela()
        {
            InitializeComponent();

            fudbaleri = new BindingList<Fudbaler>();
            table.DataSource = fudbaleri;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Dodavanje dodavanje = new Dodavanje(fudbaleri);
            dodavanje.Show();
        }
    }
}
