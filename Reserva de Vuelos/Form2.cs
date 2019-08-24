using Reserva_de_Vuelos.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_de_Vuelos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

          

        }

        public void CargarDatos(Datos_ClientesBL DatosclientesBL)
        {
            

            listaClientesBindingSource.DataSource = DatosclientesBL.ListaClientes;


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           

        }

        private void datos_ClientesBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
