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
    public partial class Transfer : Form
    {
        public Transfer(decimal balance)
        {
            InitializeComponent();
            nudAmount.Maximum = balance;
        }
    }
}
