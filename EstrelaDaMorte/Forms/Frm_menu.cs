﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstrelaDaMorte
{
    public partial class Frm_menu : Form
    {
        public Frm_menu()
        {
            InitializeComponent();
        }


      

        private void Frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void pilotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_piloto frm = new Frm_piloto();
            frm.Show();
        }
    }
}
