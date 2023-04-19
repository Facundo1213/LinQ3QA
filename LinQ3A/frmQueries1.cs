﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EjemplosWin
{
    public partial class frmQueries1 : Form
    {
        public frmQueries1()
        {
            InitializeComponent();
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Datos.Productos;
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var colecion = from producto in Datos.Productos
                           orderby producto.Nombre
                           select producto;
            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery3_Click(object sender, EventArgs e)
        {
            var colecion = from producto in Datos.Productos
                           orderby producto.Nombre descending
                           select new
                           {
                               Codigo = producto.Codigo,
                               NombreProducto = producto.Nombre
                           };
            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery4_Click(object sender, EventArgs e)
        {
            var colecion = from producto in Datos.Productos
                           orderby producto.Precio descending
                           select new dtoProducto
                           {
                               Nombre=producto.Nombre,
                               Precio=producto.Precio 
                           };
            grvResultados.DataSource = colecion.ToList();
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            var coleccion = from Control ctl in this.Controls
                           select new 
                           {
                               Control = ctl.Name,
                               Texto = ctl.Text
                           };
            grvResultados.DataSource = coleccion.ToList();
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            var colecion = from producto in Datos.Productos
                where producto.Precio > 1 && producto.Stock < 100
                select producto;

            grvResultados.DataSource = colecion.ToList();
        }

        private void frmQueries1_Load(object sender, EventArgs e)
        {

        }
    }
}
