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
    public partial class recherche_client__comptes : Form
    {
        banqueEntities Bq;
        public recherche_client__comptes()
        {
            InitializeComponent();
        }

        private void recherche_client__comptes_Load(object sender, EventArgs e)
        {
            Bq = new banqueEntities();
            comboClient.DisplayMember = "Nom";
            comboClient.ValueMember = "Num";
            comboClient.DataSource = Bq.Clients.Select(c => new { Nom = c.Nom_client +" "+ c.Prenom_Client,Num =c.Num_client }).ToList();
            comboClient.Text = "-Faites Votre Choix-";
            dataGridView1.DataSource = null;

        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N = int.Parse(comboClient.SelectedValue.ToString());
            dataGridView1.DataSource = Bq.Clients.Where(c => c.Num_client == N).Select(c => new { c.Num_client, c.Nom_client, c.Prenom_Client }).ToList();
            dataGridView1.Refresh();
        }
    }
}
