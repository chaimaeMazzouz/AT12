﻿using System;
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
    public partial class consultationClients : Form
    {
        public consultationClients()
        {
            InitializeComponent();
        }

        private void consultationClients_Load(object sender, EventArgs e)
        {
            banqueEntities bnq = new banqueEntities();
            dataGridView1.DataSource = bnq.Clients.Select(pl => new { pl.Nom_client, pl.Num_client, pl.Prenom_Client }).ToList();

        }
    }
}
