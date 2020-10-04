namespace Agenda
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

    public partial class AgregarCita : Form
    {
        Conexion.Conexion Conectar;
        public AgregarCita()
        {
            InitializeComponent();
            Conectar = new Conexion.Conexion();
            List<string> Resultados = Conectar.BuscarUsuarios(string.Empty);

            foreach (string Cliente in Resultados)
            {
                string[] datos = Cliente.Split(',');
                Conexion.ComboboxItem Item = new Conexion.ComboboxItem();
                Item.Value = datos[0];
                Item.Text = $"{datos[1]}, {datos[2]}";
                cb_Clientes.Items.Add(Item);
            }
        }

        private void btn_Aceptar_Click(object sender, System.EventArgs e)
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

                Conectar = new Conexion.Conexion();
                if (Conectar.AgregarCita(dtFechaCita.Value.ToString("yyyy/MM/dd"),txtHoraInicio.Text, txtRazon.Text,(cb_Clientes.SelectedItem as Conexion.ComboboxItem).Value.ToString(), restoParametros))
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
