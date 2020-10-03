

namespace Agenda
{
    using System;
    using System.Windows.Forms;
    public partial class AgregarPaciente : Form
    {
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string restoParametros = string.Empty;

                if(string.IsNullOrEmpty(txtNombre.Text))
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
                

                if(string.IsNullOrEmpty(txtTelefono.Text))
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
                if (Conectar.AgregarCliente(txtNombre.Text, txtApellido.Text, dtNacimiento.Value.ToString("yyyy/MM/dd"), restoParametros))
                {
                    MessageBox.Show("Almacenado.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Conectar.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_Rechazar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
