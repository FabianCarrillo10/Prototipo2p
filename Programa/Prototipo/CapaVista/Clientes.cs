﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Clientes : Form
    {

        string emp = "clientes";
        csControlador cn = new csControlador();

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dataGridView1.DataSource = dt;
        }

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
