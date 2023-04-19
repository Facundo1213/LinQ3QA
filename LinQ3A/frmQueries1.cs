using System;
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
        private void btnQuery7_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Empresa.Empre;
        }
        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var colecion = from producto in Empresa.Empre
                           orderby producto.Nombre
                           select producto;
            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery3_Click(object sender, EventArgs e)
        {
            
            var colecion = from item in Empleado.empreados where item.Salario <= 4000
                           orderby item.Salario descending
                           select new
                           {
                               Salario = item.Salario,
                               Empleado = item.Nombre,
                               EmpresaId = item.EmpresaId

                           };
            grvResultados.DataSource = colecion.ToList();
            //Lista los codigo y nombre productos de froma descendete  por nombre
        }
        private void btnQuery4_Click(object sender, EventArgs e)
        {
            var colecion = from item in Empleado.empreados
                           where item.Salario >= 6000
                           orderby item.Salario descending
                           select new
                           {
                               Salario = item.Salario,
                               Empleado = item.Nombre,
                               

                           };
            grvResultados.DataSource = colecion.ToList();
            //Lista nombre y precio los producto por precio de forma decendente 
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
            //muestras los botones con su nombre y contenido
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            var colecion = from producto in Datos.Productos
                           where producto.Precio > 1 && producto.Stock < 100
                           select producto;

            grvResultados.DataSource = colecion.ToList();
            //lista los producto ordenados por precio mayor 1 y stock menor a 100
        }

        private void frmQueries1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Empleado.empreados;
        }

        private void grvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
