namespace Agenda
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_ResultadoBusqueda.Controls.Clear();
            Conexion.Conexion Conectar = new Conexion.Conexion();

            List<string> Resultados = Conectar.BuscarUsuarios(txtBuscar.Text);

            if(Resultados.Count == 0 && string.IsNullOrEmpty(Conectar.Error))
            {
                MessageBox.Show("No hay resulados para esa busqueda.");
            }
            else if(!string.IsNullOrEmpty(Conectar.Error))
            {
                MessageBox.Show(Conectar.Error);
            }
            else
            {
                int cont = 1;
                foreach (string Cliente in Resultados)
                {
                        string[] datos = Cliente.Split(',');
                        Button button = new Button();
                        button.Name = $"button{datos[0]}";
                        button.Text = $"{datos[1]}, {datos[2]}";
                        button.Width = 398;
                        button.Height = 50;
                        button.Click += new EventHandler(button_Editar_Click);
                    if (cont == 1)
                        {
                            button.Location = new Point(0, 0);
                        }
                        else
                        {
                            button.Location = new Point(0, button.Height * (cont - 1));
                        }
                        pnl_ResultadoBusqueda.Controls.Add(button);
                        cont++;
                }
            }
        }

        protected void button_Editar_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            string nombre = boton.Name;
            string codigo = nombre.Remove(0,6);

            EditarSeleccion VentanaEditarSeleccion = new EditarSeleccion(codigo);
            VentanaEditarSeleccion.Show();
        }
    }
}
