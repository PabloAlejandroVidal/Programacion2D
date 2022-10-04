using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class FormAgregarVuelo : Form
    {
        Vuelo? vueloSeleccionado;
        string? lugar;
        public FormAgregarVuelo()
        {
            InitializeComponent();

            CargarCmbLugar(cmbOrigen);
            CargarCmbLugar(cmbDestino);
        }
        private void CargarCmbLugar(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (var v in EasyTravel.GetListaLugares())
            {
                cmb.Items.AddRange(new object[] { v.Nombre });
            }
        }
    }
}
