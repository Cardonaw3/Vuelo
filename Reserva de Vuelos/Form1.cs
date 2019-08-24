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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        public void CDatos(BusquedaVueloBL busquedaVueloBL, CategoriaBL categoriaBL)
        {
         
            listaVueloBindingSource.DataSource = busquedaVueloBL.ListaVuelo;

            
            listaCategoriaBindingSource.DataSource = categoriaBL.ListaCategoria;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void listaVueloBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
