using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT12_banque
{
    public partial class consultationComptes : Form
    {
        public consultationComptes()
        {
            InitializeComponent();
        }

        private void consultationComptes_Load(object sender, EventArgs e)
        {
            banqueEntities bnq = new banqueEntities();
            dataGridView1.DataSource = bnq.Comptes.Select(pl => new { pl.Num_Compte, pl.Num_Client, pl.Solde, pl.TypeC }).ToList();

        }
    }
}
