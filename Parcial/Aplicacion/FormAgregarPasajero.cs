using Biblioteca;

namespace Aplicacion
{
    public partial class FormAgregarPasajero : Form
    {
        List<Pasajero> listaPasajeros = new List<Pasajero>();
        List<Vuelo>? listaVuelosDisponibles;
        Vuelo? vueloSeleccionado;
        string? lugar;
        public FormAgregarPasajero()
        {
            InitializeComponent();
        }
        private void FormSeleccionVuelo_Load(object sender, EventArgs e)
        {

            this.panel1.BringToFront();
            CargarCmbLugar(cmbOrigen);
            CargarCmbLugar(cmbDestino);
            CargarTxtDni();
            CargarCmbClase();
            CargarCmbComida();
        }
        private void CargarCmbLugar(ComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (var v in EasyTravel.GetListaLugares())
            {
                cmb.Items.AddRange(new object[] { v.Nombre });
            }
        }
        private void CargarTxtDni()
        {
            txtDni.Clear();
            txtDni.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDni.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            foreach (var cliente in EasyTravel.GetListaClientes())
            {
                txtDni.AutoCompleteCustomSource.Add(cliente.Dni.ToString());
            }
        }
        private void CargarCmbClase()
        {
            cmbClase.Items.Clear();
            foreach (var comida in Enum.GetValues(typeof(Pasajero.eClase)))
            {
                cmbClase.Items.Add(comida);
            }
            cmbClase.SelectedIndex = 0;
        }
        private void CargarCmbComida()
        {
            cmbTipoComida.Items.Clear();
            foreach (var comida in Enum.GetValues(typeof(Pasajero.eComida)))
            {
                cmbTipoComida.Items.Add(comida);
            }
            cmbTipoComida.SelectedIndex = 0;
        }

        private void cmbOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            MostrarVuelosDisponibles();
        }

        private void cmbDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            MostrarVuelosDisponibles();
        }

        private void btnSeleccionarVuelo_Click(object sender, EventArgs e)
        {
            SeleccionarVuelo();
        }

        private void lstVuelosDisponibles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarVuelo();
        }
        private void SeleccionarVuelo()
        {
            if (lstVuelosDisponibles.SelectedIndex != -1 && listaVuelosDisponibles != null)
            {
                vueloSeleccionado = listaVuelosDisponibles[lstVuelosDisponibles.SelectedIndex];
                this.panel2.BringToFront();
                listaPasajeros.Clear();
                MostrarLstPasajeros();
            }
            else
            {
                MessageBox.Show("Debes seleccionar un vuelo");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.panel3.BringToFront();

            lstResumen.Items.Add(string.Format(new string("{0,-60}{1,-30}"), "Cantidad", "2"));
            lstResumen.Items.Add(string.Format(new string("{0,-60}{1,-30}"), "Total", "200"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.BringToFront();
        }

        private void AgregarPasajero(object sender, EventArgs e)
        {
            if (vueloSeleccionado != null)
            {
                string nombre = txtNombre.Text;
                int dni;
                string clase = cmbClase.Text;

                if (Validacion.ValidarNombre(nombre) && Validacion.ValidarDni(txtDni, out dni) && Validacion.ValidarClase(clase))
                {
                    if (!vueloSeleccionado.ContienePasajero(dni))
                    {
                        listaPasajeros.Add(new Pasajero(nombre, dni, 0, clase));
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar pasajero, ya esta en este vuelo");
                    }
                }
                else
                {
                    MessageBox.Show("Error en los datos ingresados");
                }
            }
            else
            {
                MessageBox.Show("Error al consultar vuelo");
            }
            MostrarLstPasajeros();
        }
        private void QuitarPasajero(object sender, EventArgs e)
        {
            listaPasajeros.RemoveAt(lstPasajeros.SelectedIndex);
            MostrarLstPasajeros();
        }
        private void MostrarLstPasajeros()
        {
            lstPasajeros.Items.Clear();
            foreach (var item in listaPasajeros)
            {
                lstPasajeros.Items.Add(string.Format(new string("DNI: {0,-16} Nombre: {1,-16}"), item.Dni, item.Nombre));
            }
        }
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            CargarDatosClientePorDni();
        }

        private void CargarDatosClientePorDni()
        {
            int dni;
            if (Validacion.ValidarDni(txtDni, out dni))
            {
                Cliente? cliente = EasyTravel.GetCliente(dni);
                if (cliente != null)
                    txtNombre.Text = cliente.Nombre;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EasyTravel.AsignarPasajero(vueloSeleccionado, listaPasajeros); 
        }
        private void MostrarVuelosDisponibles()
        {
            lstVuelosDisponibles.Items.Clear();
            listaVuelosDisponibles = EasyTravel.GetListaVuelos();
            listaVuelosDisponibles = EasyTravel.FiltrarListaVuelosOrigen(listaVuelosDisponibles, cmbOrigen.Text.Trim());
            listaVuelosDisponibles = EasyTravel.FiltrarListaVuelosDestino(listaVuelosDisponibles, cmbDestino.Text.Trim());

            if (listaVuelosDisponibles.Count > 0)
            {
                string codigo = "Codigo Vuelo";
                string origen = "Origen";
                string destino = "Destino";
                string hora = "Hora Salida";
                string asientos = "Asientos Disponibles";

                foreach (Vuelo item in listaVuelosDisponibles)
                {
                    codigo = item.CodigoVuelo;
                    origen = item.Origen;
                    destino = item.Destino;
                    hora = item.HoraDeSalida;
                    asientos = item.AsientosDisponibles.ToString();

                    lstVuelosDisponibles.Items.Add(string.Format(new string("{0,-8}{1,-18}{2,-18}{3,18}{4,18}"), codigo, origen, destino, hora, asientos));
                }
            }
            else
            {
                lstVuelosDisponibles.Items.Add("No se encontraron vuelos");
            }
        }
    }
}
