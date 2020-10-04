using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class EditarCita : Form
    {
        Conexion.Conexion Conectar;
        string FechaOriginal;
        string CodigoClienteOriginal;
        string IdCita;
        public EditarCita(string fecha, string codigo, string cita)
        {
            FechaOriginal = fecha;
            CodigoClienteOriginal = codigo;
            IdCita = cita;
            InitializeComponent();

            Conectar = new Conexion.Conexion();
            string Resultado = Conectar.BuscaEditaCita(codigo,fecha);
            if(string.IsNullOrEmpty(Resultado) && !string.IsNullOrEmpty(Conectar.Error))
            {
                this.Close();
            }
            else
            {
                string[] datos = Resultado.Split(',');

                dtFechaCita.Value = DateTime.Parse(datos[0]);
                txtHoraInicio.Text = datos[1];

                if (string.IsNullOrEmpty(datos[2]))
                {
                    txtHoraFin.Text = string.Empty;
                }
                else
                {
                    txtHoraFin.Text = datos[2];
                }

                txtRazon.Text = datos[3];

                if (string.IsNullOrEmpty(datos[5]))
                {
                    txtProced.Text = string.Empty;
                }
                else
                {
                    txtProced.Text = datos[5];
                }

                Conectar = new Conexion.Conexion();
                List<string> Resultados = Conectar.BuscarUsuarios(string.Empty);

                foreach (string Cliente in Resultados)
                {
                    string[] cliente = Cliente.Split(',');
                    Conexion.ComboboxItem Item = new Conexion.ComboboxItem();
                    Item.Value = cliente[0];
                    Item.Text = $"{cliente[1]}, {cliente[2]}";
                    cb_Clientes.Items.Add(Item);

                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string restoParametros = string.Empty;

                if (dtFechaCita.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Muy tarde para agendar una cita esa fecha.");
                    return;
                }

                if (string.IsNullOrEmpty(txtHoraInicio.Text))
                {
                    MessageBox.Show("Debe ingresar una hora de inicio.");
                    return;
                }

                if (string.IsNullOrEmpty(txtRazon.Text))
                {
                    MessageBox.Show("Debe ingresar una razon guia de la cita.");
                    return;
                }

                if (string.IsNullOrEmpty(txtHoraFin.Text))
                {
                    restoParametros += ", NULL";
                }
                else
                {
                    restoParametros += $", '{txtHoraFin.Text}'";
                }

                if (string.IsNullOrEmpty(txtProced.Text))
                {
                    restoParametros += ", NULL";
                }
                else
                {
                    restoParametros += $", '{txtProced.Text}'";
                }

                Conectar = new Conexion.Conexion();
                if (Conectar.ActualizarCita(dtFechaCita.Value.ToString("yyyy/MM/dd"), txtHoraInicio.Text, txtRazon.Text, (cb_Clientes.SelectedItem as Conexion.ComboboxItem).Value.ToString(), IdCita, restoParametros))
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

        private void btn_Rechazar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
