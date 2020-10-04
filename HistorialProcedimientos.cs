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
    public partial class HistorialProcedimientos : Form
    {
        public HistorialProcedimientos(string codigo)
        {
            Conexion.Conexion Conect = new Conexion.Conexion();
            InitializeComponent();
            List<string> Procedimientos = Conect.BuscarProcedimientos(codigo);

            if(Procedimientos.Count > 0)
            {
                foreach (string Cita in Procedimientos)
                {
                    txtHistorial.Text += Cita;
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
