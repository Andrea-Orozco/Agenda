namespace Agenda
{
    using System;
    using System.Windows.Forms;
    public partial class EditarSeleccion : Form
    {
        string Codigo = string.Empty;
        public EditarSeleccion(string codigo)
        {
            Conexion.Conexion Conect = new Conexion.Conexion();
            InitializeComponent();
            string Cliente = Conect.BuscarEditarUsuarios(codigo);
            if (string.IsNullOrEmpty(Cliente))
            {
                this.Close();
            }
            else
            {
                Codigo = codigo;
                string[] datos = Cliente.Split(',');

                txtNombre.Text = datos[0];
                txtApellido.Text = datos[1];

                if (string.IsNullOrEmpty(datos[2]))
                {
                    txtTelefono.Text = string.Empty;
                }
                else
                {
                    txtTelefono.Text = datos[2];
                }

                if (string.IsNullOrEmpty(datos[3]))
                {
                    txtCorreo.Text = string.Empty;
                }
                else
                {
                    txtCorreo.Text = datos[3];
                }

                if (string.IsNullOrEmpty(datos[4]))
                {
                    txtPeso.Text = string.Empty;
                }
                else
                {
                    txtPeso.Text = datos[4];
                }

                if (string.IsNullOrEmpty(datos[5]))
                {
                    txtAltura.Text = string.Empty;
                }
                else
                {
                    txtAltura.Text = datos[5];
                }

                dtNacimiento.Value = DateTime.Parse(datos[6]);

                if (string.IsNullOrEmpty(datos[7]))
                {
                    txtPadecimientos.Text = string.Empty;
                }
                else
                {
                    txtPadecimientos.Text = datos[7];
                }
            }

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string restoParametros = string.Empty;

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre.");
                    return;
                }

                if (string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre.");
                    return;
                }

                if (dtNacimiento.Value.Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("Esa fecha no pudo nacer, escoja otra.");
                    return;
                }


                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    restoParametros += ", NULL";
                }
                else
                {
                    restoParametros += $", {int.Parse(txtTelefono.Text).ToString()}";
                }

                if (string.IsNullOrEmpty(txtCorreo.Text))
                {
                    restoParametros += ", NULL";
                }
                else
                {
                    restoParametros += $", '{txtCorreo.Text}'";
                }

                if (string.IsNullOrEmpty(txtPeso.Text))
                {
                    restoParametros += ", NULL";
                }
                else
                {
                    restoParametros += $", {double.Parse(txtTelefono.Text).ToString()}";
                }

                if (string.IsNullOrEmpty(txtAltura.Text))
                {
                    restoParametros += ", NULL";
                }
                else
                {
                    restoParametros += $", {double.Parse(txtAltura.Text).ToString()}";
                }

                if (string.IsNullOrEmpty(txtPadecimientos.Text))
                {
                    restoParametros += ", NULL";
                }
                else
                {
                    restoParametros += $", '{txtPadecimientos.Text}'";
                }

                Conexion.Conexion Conectar = new Conexion.Conexion();
                if (Conectar.ActualizarCliente(txtNombre.Text, txtApellido.Text, dtNacimiento.Value.ToString("yyyy/MM/dd"), Codigo, restoParametros))
                {
                    MessageBox.Show("Almacenado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Conectar.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
