using Biblioteca;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace Aplicacion
{
    public partial class frmApp : Form 
    {
        private PropertyInfo propiedad;
        private PropertyInfo[] listProps;
        private TipoOrden tipoOrden;
        Color BackColorBoton = new Color();
        public enum TipoOrden
        {
            desc,
            asc,
        }
        public frmApp()
        {
            InitializeComponent();
        }
        private void FormApp_Load(object sender, EventArgs e)
        {
            BackColorBoton = Color.FromArgb(0, 200, 27, 33);
            btnVerPasajeros.BackColor = BackColorBoton;
            btnVerLugares.BackColor = BackColorBoton;
            btnVerVuelos.BackColor = BackColorBoton;
            btnVerAviones.BackColor = BackColorBoton;

            btnAgregarPasajero.BackColor = BackColorBoton;
            btnAgregarVuelo.BackColor = BackColorBoton;


            this.pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(pnlLogin);

            foreach (var v in EasyTravel.listaUsuarios)
            {
                cmbUser.Items.AddRange(new object[] { v.Key });
            }
            cmbUser.SelectedIndex = 0;

            foreach (var v in Tema.GetLista())
            {
                cmbTema.Items.AddRange(new object[] { v });
            }
            cmbTema.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            if (EasyTravel.LogIn(cmbUser.Text, txtPass.Text))
            {
                LogIn();
            }
            else
            {
                MessageBox.Show("Error: Usuario o contraseña incorrectos");
            }
        }
        private void LogIn()
        {
            Text = "Pachuli-Air! | Usuario " + cmbUser.Text;
            lblUsuario.Text = "Usuario: " + EasyTravel.MostrarUsuarioLogueado();

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(pnlPrincipal);
            pnlMenuSub.Controls.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(EasyTravel.GetListaVuelos().Count > 0)
            {
                DataTable dt = GenerarDataTablePropiedades(typeof(Vuelo));
                foreach (var item in EasyTravel.GetListaVuelos())
                {
                    CargarLineasDataTable(dt, item);
                }
                dtgInfo.DataSource = dt;
            }
            else
            {
                this.dtgInfo.DataSource = null;
            }
            this.pnlMenuSub.Controls.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(EasyTravel.GetListaPasajeros().Count > 0)
            {
                DataTable dt = GenerarDataTablePropiedades(typeof(Pasajero));
                foreach (var item in EasyTravel.GetListaPasajeros())
                {
                    CargarLineasDataTable(dt, item);
                }
                dtgInfo.DataSource = dt;
            }
            else
            {
                this.dtgInfo.DataSource = null;
            }
            this.pnlMenuSub.Controls.Clear();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (EasyTravel.GetListaLugares().Count > 0)
            {
                DataTable dt = GenerarDataTablePropiedades(typeof(Lugar));
                foreach (var item in EasyTravel.GetListaLugares())
                {
                    CargarLineasDataTable(dt, item);
                }
                dtgInfo.DataSource = dt;
            }
            else
            {
                this.dtgInfo.DataSource = null;
            }
            this.pnlMenuSub.Controls.Clear();
        }
        private void btnMostrarAviones_Click(object sender, EventArgs e)
        {
            if (EasyTravel.GetListaAviones().Count > 0)
            {
                DataTable dt = GenerarDataTablePropiedades(typeof(Aeronave));
                foreach (var item in EasyTravel.GetListaAviones())
                {
                    CargarLineasDataTable(dt, item);
                }
                dtgInfo.DataSource = dt;
            }
            else
            {
                this.dtgInfo.DataSource = null;
            }
            this.pnlMenuSub.Controls.Clear();
        }
        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormAgregarPasajero form = new FormAgregarPasajero();
            form.ShowDialog();
        }
        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPass.Text = EasyTravel.GetPass(cmbUser.Text);
        }
        private void CargarLineasDataTable(DataTable dt, object item)
        {
            DataRow row = dt.NewRow();
            foreach (var prop in listProps)
            {
                row[prop.Name] = prop.GetValue(item);
            }
            dt.Rows.Add(row);
        }
        private DataTable GenerarDataTablePropiedades(Type tipo)
        {
            listProps = tipo.GetProperties();
            DataTable dt = new DataTable();
            foreach (var prop in listProps)
            {
                dt.Columns.Add(prop.Name);
            }
            return dt;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tema.SetTema(pnlPrincipal, dtgInfo, cmbTema.Text);
        }
        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            FormAgregarVuelo form = new FormAgregarVuelo();
            form.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}
