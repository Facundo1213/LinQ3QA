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
        
        private void btnQuery7_Click(object sender, EventArgs e)//BtnEmpresa
        {
            grvResultados.DataSource = Empresa.Empre;
        }
        private void btnQuery2_Click(object sender, EventArgs e)
        {
            var colecion = from empleado in Empleado.empleados
                           join empresa in Empresa.Empre on empleado.EmpresaId equals empresa.Id 
                           where empleado.Estado == "Ausente"
                           select new
                           {
                               EmpresaId = empresa.Nombre + " " + empleado.EmpresaId,
                               Nombre = empleado.Nombre,
                               
                           };

            grvResultados.DataSource = colecion.ToList();
        }
        private void btnQuery3_Click(object sender, EventArgs e)
        {
            
            var colecion = from item in Empleado.empleados where item.Salario <= 4000
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
            var colecion = from item in Empleado.empleados
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
            var colecion = from empleado in Empleado.empleados
                           join empresa in Empresa.Empre on empleado.EmpresaId equals empresa.Id
                           select new
                           {
                               Empresa = empresa.Nombre,
                               Salario = Math.Abs(empleado.Salario),
                               

                           }; ;
            grvResultados.DataSource = colecion.ToList();
            //muestras los botones con su nombre y contenido
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            var colecion = from empleados in Empleado.empleados
                           where empleados.Cargo == "CEO"
                           select new
                           {
                               Cargo = empleados.Cargo,
                               Nombre = empleados.Nombre,
                               EmpresaId = empleados.EmpresaId

                           };


            grvResultados.DataSource = colecion.ToList();
            //lista los producto ordenados por precio mayor 1 y stock menor a 100
        }

        private void frmQueries1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grvResultados.DataSource = Empleado.empleados;
        }

        private void grvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var colecion = from empleados in Empleado.empleados
                           where empleados.Cargo == "Junior"
                           select new
                           {
                               Cargo = empleados.Cargo,
                               Nombre = empleados.Nombre,
                           };
            grvResultados.DataSource = colecion.ToList();
        }
    }
}
