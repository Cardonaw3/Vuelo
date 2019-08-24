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
    public partial class Menu : Form
    {
        BusquedaVueloBL _busquedaVueloBL;
        CategoriaBL _categoriaBL;
        Datos_ClientesBL _DatosClientesBL; 

        public object End { get; private set; }

        public Menu()
        {
            InitializeComponent();
            _busquedaVueloBL = new BusquedaVueloBL();
            _categoriaBL = new CategoriaBL();
            _DatosClientesBL = new Datos_ClientesBL();
        }

        private void seleccionDeVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formDestino = new Form1();
            formDestino.MdiParent = this;

            formDestino.CDatos(_busquedaVueloBL, _categoriaBL);
            formDestino.Show();

        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReserva = new Form2();
            formReserva.MdiParent = this;
            formReserva.CargarDatos(_DatosClientesBL);
            formReserva.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            



        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
