﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solaire
{
    public partial class Airdrop : Form
    {
        public Airdrop(char cluster)
        {
            InitializeComponent();
            if (cluster == 't')
                nudAmount.Maximum = 1;
        }

        private void btnAirdrop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
