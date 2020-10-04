namespace Agenda
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Conexion;
    public partial class pantalla_Marco : Form
    {
        public pantalla_Marco()
        {
            InitializeComponent();
        }

        private void hamburguesa_abierta_Click(object sender, EventArgs e)
        {
            panel_MenuCerrado.Visible = true;
            panel_MenuAbierto.Visible = false;
            panel_Trabajo.Size = new Size(753,499);
            panel_Trabajo.Location = new Point(46,1);

            if (panel_Pacientes.Visible)
            {
                panel_Pacientes.Size = new Size(753, 499);
                panel_Pacientes.Location = new Point(46, 1);

                btn_Paciente_Editar.Location = new Point(465, 35);
                btn_Paciente_Buscar.Location = new Point(235, 241);
            }
            else if(panel_Citas.Visible)
            {
                panel_Citas.Size = new Size(753, 499);
                panel_Citas.Location = new Point(46, 1);

                panel_Citas_Dia.Width = 422;
                srl_Citas_Dia.Location = new Point(409, 0);
                month_Calendario.Location = new Point(465, 35);
                btn_Citas_Agregar.Location = new Point(474, 216);
                btn_Citas_Editar.Location = new Point(620, 216);
                btn_Citas_Eliminar.Location = new Point(552, 322);
            }
        }

        private void hamburguesa_Cerrada_Click(object sender, EventArgs e)
        {
            panel_MenuCerrado.Visible = false;
            panel_MenuAbierto.Visible = true;
            panel_Trabajo.Size = new Size(664, 499);
            panel_Trabajo.Location = new Point(135, 1);

            if (panel_Pacientes.Visible)
            {
                panel_Pacientes.Size = new Size(664, 499);
                panel_Pacientes.Location = new Point(135, 1);

                btn_Paciente_Editar.Location = new Point(365, 35);
                btn_Paciente_Buscar.Location = new Point(189, 241);
            }
            else if (panel_Citas.Visible)
            {
                panel_Citas.Size = new Size(664, 499);
                panel_Citas.Location = new Point(135, 1);

                panel_Citas_Dia.Width = 322;
                srl_Citas_Dia.Location = new Point(309, 0);
                month_Calendario.Location = new Point(365, 35);
                btn_Citas_Agregar.Location = new Point(374, 216);
                btn_Citas_Editar.Location = new Point(520, 216);
                btn_Citas_Eliminar.Location = new Point(452, 322);
            }
        }

        private void btn_PacienteAbierto_Click(object sender, EventArgs e)
        {
            if (panel_Pacientes.Visible)
            {
                panel_Pacientes.Visible = false;
            }
            else
            {
                panel_Pacientes.Visible = true;
                panel_Pacientes.Size = new Size(664, 499);
                panel_Pacientes.Location = new Point(135, 1);

                btn_Paciente_Editar.Location = new Point(365, 35);
                btn_Paciente_Buscar.Location = new Point(189, 241);
                if(panel_Citas.Visible)
                {
                    panel_Citas.Visible = false;
                }
            }
        }

        private void btn_PacienteCerrado_Click(object sender, EventArgs e)
        {
            if (panel_Pacientes.Visible)
            {
                panel_Pacientes.Visible = false;
            }
            else
            {
                panel_Pacientes.Visible = true;
                panel_Pacientes.Size = new Size(753, 499);
                panel_Pacientes.Location = new Point(46, 1);

                btn_Paciente_Editar.Location = new Point(465, 35);
                btn_Paciente_Buscar.Location = new Point(235, 241);
                if (panel_Citas.Visible)
                {
                    panel_Citas.Visible = false;
                }
            }
        }

        private void btn_Paciente_Agregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_CitaAbierto_Click(object sender, EventArgs e)
        {
            if (panel_Citas.Visible)
            {
                panel_Citas.Visible = false;
            }
            else
            {
                panel_Citas.Visible = true;
                panel_Citas.Size = new Size(664, 499);
                panel_Citas.Location = new Point(135, 1);
                if (panel_Pacientes.Visible)
                {
                    panel_Pacientes.Visible = false;
                }
            }
        }

        private void btn_CitaCerrado_Click(object sender, EventArgs e)
        {
            if (panel_Citas.Visible)
            {
                panel_Citas.Visible = false;
            }
            else
            {
                panel_Citas.Visible = true;
                panel_Citas.Size = new Size(753, 499);
                panel_Citas.Location = new Point(46, 1);

                panel_Citas_Dia.Width = 422;
                srl_Citas_Dia.Location = new Point(409,0);
                month_Calendario.Location = new Point(465,35);
                btn_Citas_Agregar.Location = new Point(474,216);
                btn_Citas_Editar.Location = new Point(620, 216);
                btn_Citas_Eliminar.Location = new Point(552, 322);

                if (panel_Pacientes.Visible)
                {
                    panel_Pacientes.Visible = false;
                }
            }
        }

        private void pantalla_Marco_Load(object sender, EventArgs e)
        {
            Conexion.Conexion prueba = new Conexion.Conexion();
        }

        private void btn_Paciente_Agregar_Click_1(object sender, EventArgs e)
        {
            //Agregar paciente
            AgregarPaciente VentanaAgregar = new AgregarPaciente();
            VentanaAgregar.Visible = true;
        }

        private void btn_Paciente_Editar_Click(object sender, EventArgs e)
        {
            EditarUsuario VentanaEditar = new EditarUsuario();
            VentanaEditar.Visible = true;
        }
    }
}
