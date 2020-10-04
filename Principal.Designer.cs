namespace Agenda
{
    partial class pantalla_Marco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_Marco));
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.panel_Citas = new System.Windows.Forms.Panel();
            this.panel_Citas_Dia = new System.Windows.Forms.DataGridView();
            this.btn_Citas_Editar = new System.Windows.Forms.Button();
            this.btn_Citas_Eliminar = new System.Windows.Forms.Button();
            this.btn_Citas_Agregar = new System.Windows.Forms.Button();
            this.month_Calendario = new System.Windows.Forms.MonthCalendar();
            this.panel_Pacientes = new System.Windows.Forms.Panel();
            this.btn_Paciente_Buscar = new System.Windows.Forms.Button();
            this.btn_Paciente_Editar = new System.Windows.Forms.Button();
            this.btn_Paciente_Agregar = new System.Windows.Forms.Button();
            this.panel_Trabajo = new System.Windows.Forms.Panel();
            this.panel_MenuAbierto = new System.Windows.Forms.Panel();
            this.btn_CitaAbierto = new System.Windows.Forms.Button();
            this.btn_PacienteAbierto = new System.Windows.Forms.Button();
            this.hamburguesa_abierta = new System.Windows.Forms.Button();
            this.panel_MenuCerrado = new System.Windows.Forms.Panel();
            this.btn_CitaCerrado = new System.Windows.Forms.Button();
            this.btn_PacienteCerrado = new System.Windows.Forms.Button();
            this.hamburguesa_Cerrada = new System.Windows.Forms.Button();
            this.panel_Contenedor.SuspendLayout();
            this.panel_Citas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_Citas_Dia)).BeginInit();
            this.panel_Pacientes.SuspendLayout();
            this.panel_MenuAbierto.SuspendLayout();
            this.panel_MenuCerrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Contenedor
            // 
            resources.ApplyResources(this.panel_Contenedor, "panel_Contenedor");
            this.panel_Contenedor.Controls.Add(this.panel_Citas);
            this.panel_Contenedor.Controls.Add(this.panel_Pacientes);
            this.panel_Contenedor.Controls.Add(this.panel_Trabajo);
            this.panel_Contenedor.Controls.Add(this.panel_MenuAbierto);
            this.panel_Contenedor.Controls.Add(this.panel_MenuCerrado);
            this.panel_Contenedor.Name = "panel_Contenedor";
            // 
            // panel_Citas
            // 
            this.panel_Citas.BackColor = System.Drawing.Color.Plum;
            this.panel_Citas.Controls.Add(this.panel_Citas_Dia);
            this.panel_Citas.Controls.Add(this.btn_Citas_Editar);
            this.panel_Citas.Controls.Add(this.btn_Citas_Eliminar);
            this.panel_Citas.Controls.Add(this.btn_Citas_Agregar);
            this.panel_Citas.Controls.Add(this.month_Calendario);
            resources.ApplyResources(this.panel_Citas, "panel_Citas");
            this.panel_Citas.Name = "panel_Citas";
            // 
            // panel_Citas_Dia
            // 
            this.panel_Citas_Dia.AllowUserToResizeColumns = false;
            this.panel_Citas_Dia.AllowUserToResizeRows = false;
            this.panel_Citas_Dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            resources.ApplyResources(this.panel_Citas_Dia, "panel_Citas_Dia");
            this.panel_Citas_Dia.MultiSelect = false;
            this.panel_Citas_Dia.Name = "panel_Citas_Dia";
            this.panel_Citas_Dia.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_Citas_Editar
            // 
            this.btn_Citas_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Citas_Editar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Citas_Editar, "btn_Citas_Editar");
            this.btn_Citas_Editar.Name = "btn_Citas_Editar";
            this.btn_Citas_Editar.UseVisualStyleBackColor = true;
            this.btn_Citas_Editar.Click += new System.EventHandler(this.btn_Citas_Editar_Click);
            // 
            // btn_Citas_Eliminar
            // 
            this.btn_Citas_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Citas_Eliminar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Citas_Eliminar, "btn_Citas_Eliminar");
            this.btn_Citas_Eliminar.Name = "btn_Citas_Eliminar";
            this.btn_Citas_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Citas_Eliminar.Click += new System.EventHandler(this.btn_Citas_Eliminar_Click);
            // 
            // btn_Citas_Agregar
            // 
            this.btn_Citas_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Citas_Agregar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Citas_Agregar, "btn_Citas_Agregar");
            this.btn_Citas_Agregar.Name = "btn_Citas_Agregar";
            this.btn_Citas_Agregar.UseVisualStyleBackColor = true;
            this.btn_Citas_Agregar.Click += new System.EventHandler(this.btn_Citas_Agregar_Click);
            // 
            // month_Calendario
            // 
            this.month_Calendario.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.month_Calendario, "month_Calendario");
            this.month_Calendario.MaxSelectionCount = 1;
            this.month_Calendario.Name = "month_Calendario";
            this.month_Calendario.TitleBackColor = System.Drawing.Color.Plum;
            this.month_Calendario.TrailingForeColor = System.Drawing.Color.LightPink;
            this.month_Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.month_Calendario_DateChanged);
            // 
            // panel_Pacientes
            // 
            this.panel_Pacientes.BackColor = System.Drawing.Color.Plum;
            this.panel_Pacientes.Controls.Add(this.btn_Paciente_Buscar);
            this.panel_Pacientes.Controls.Add(this.btn_Paciente_Editar);
            this.panel_Pacientes.Controls.Add(this.btn_Paciente_Agregar);
            resources.ApplyResources(this.panel_Pacientes, "panel_Pacientes");
            this.panel_Pacientes.Name = "panel_Pacientes";
            // 
            // btn_Paciente_Buscar
            // 
            this.btn_Paciente_Buscar.BackColor = System.Drawing.Color.Plum;
            this.btn_Paciente_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Paciente_Buscar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Paciente_Buscar, "btn_Paciente_Buscar");
            this.btn_Paciente_Buscar.Name = "btn_Paciente_Buscar";
            this.btn_Paciente_Buscar.UseVisualStyleBackColor = false;
            this.btn_Paciente_Buscar.Click += new System.EventHandler(this.btn_Paciente_Buscar_Click);
            // 
            // btn_Paciente_Editar
            // 
            this.btn_Paciente_Editar.BackColor = System.Drawing.Color.Plum;
            this.btn_Paciente_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Paciente_Editar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Paciente_Editar, "btn_Paciente_Editar");
            this.btn_Paciente_Editar.Name = "btn_Paciente_Editar";
            this.btn_Paciente_Editar.UseVisualStyleBackColor = false;
            this.btn_Paciente_Editar.Click += new System.EventHandler(this.btn_Paciente_Editar_Click);
            // 
            // btn_Paciente_Agregar
            // 
            this.btn_Paciente_Agregar.BackColor = System.Drawing.Color.Plum;
            this.btn_Paciente_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Paciente_Agregar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_Paciente_Agregar, "btn_Paciente_Agregar");
            this.btn_Paciente_Agregar.Name = "btn_Paciente_Agregar";
            this.btn_Paciente_Agregar.UseVisualStyleBackColor = false;
            this.btn_Paciente_Agregar.Click += new System.EventHandler(this.btn_Paciente_Agregar_Click_1);
            // 
            // panel_Trabajo
            // 
            resources.ApplyResources(this.panel_Trabajo, "panel_Trabajo");
            this.panel_Trabajo.BackColor = System.Drawing.Color.Plum;
            this.panel_Trabajo.Name = "panel_Trabajo";
            // 
            // panel_MenuAbierto
            // 
            this.panel_MenuAbierto.Controls.Add(this.btn_CitaAbierto);
            this.panel_MenuAbierto.Controls.Add(this.btn_PacienteAbierto);
            this.panel_MenuAbierto.Controls.Add(this.hamburguesa_abierta);
            resources.ApplyResources(this.panel_MenuAbierto, "panel_MenuAbierto");
            this.panel_MenuAbierto.Name = "panel_MenuAbierto";
            // 
            // btn_CitaAbierto
            // 
            this.btn_CitaAbierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CitaAbierto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CitaAbierto.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_CitaAbierto, "btn_CitaAbierto");
            this.btn_CitaAbierto.Name = "btn_CitaAbierto";
            this.btn_CitaAbierto.UseVisualStyleBackColor = true;
            this.btn_CitaAbierto.Click += new System.EventHandler(this.btn_CitaAbierto_Click);
            // 
            // btn_PacienteAbierto
            // 
            this.btn_PacienteAbierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PacienteAbierto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_PacienteAbierto.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_PacienteAbierto, "btn_PacienteAbierto");
            this.btn_PacienteAbierto.Name = "btn_PacienteAbierto";
            this.btn_PacienteAbierto.UseVisualStyleBackColor = true;
            this.btn_PacienteAbierto.Click += new System.EventHandler(this.btn_PacienteAbierto_Click);
            // 
            // hamburguesa_abierta
            // 
            this.hamburguesa_abierta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamburguesa_abierta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hamburguesa_abierta.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.hamburguesa_abierta, "hamburguesa_abierta");
            this.hamburguesa_abierta.Name = "hamburguesa_abierta";
            this.hamburguesa_abierta.UseVisualStyleBackColor = true;
            this.hamburguesa_abierta.Click += new System.EventHandler(this.hamburguesa_abierta_Click);
            // 
            // panel_MenuCerrado
            // 
            this.panel_MenuCerrado.Controls.Add(this.btn_CitaCerrado);
            this.panel_MenuCerrado.Controls.Add(this.btn_PacienteCerrado);
            this.panel_MenuCerrado.Controls.Add(this.hamburguesa_Cerrada);
            resources.ApplyResources(this.panel_MenuCerrado, "panel_MenuCerrado");
            this.panel_MenuCerrado.Name = "panel_MenuCerrado";
            // 
            // btn_CitaCerrado
            // 
            this.btn_CitaCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CitaCerrado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CitaCerrado.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_CitaCerrado, "btn_CitaCerrado");
            this.btn_CitaCerrado.Name = "btn_CitaCerrado";
            this.btn_CitaCerrado.UseVisualStyleBackColor = true;
            this.btn_CitaCerrado.Click += new System.EventHandler(this.btn_CitaCerrado_Click);
            // 
            // btn_PacienteCerrado
            // 
            this.btn_PacienteCerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PacienteCerrado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_PacienteCerrado.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_PacienteCerrado, "btn_PacienteCerrado");
            this.btn_PacienteCerrado.Name = "btn_PacienteCerrado";
            this.btn_PacienteCerrado.UseVisualStyleBackColor = true;
            this.btn_PacienteCerrado.Click += new System.EventHandler(this.btn_PacienteCerrado_Click);
            // 
            // hamburguesa_Cerrada
            // 
            this.hamburguesa_Cerrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hamburguesa_Cerrada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hamburguesa_Cerrada.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.hamburguesa_Cerrada, "hamburguesa_Cerrada");
            this.hamburguesa_Cerrada.Name = "hamburguesa_Cerrada";
            this.hamburguesa_Cerrada.UseVisualStyleBackColor = true;
            this.hamburguesa_Cerrada.Click += new System.EventHandler(this.hamburguesa_Cerrada_Click);
            // 
            // pantalla_Marco
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.panel_Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "pantalla_Marco";
            this.Activated += new System.EventHandler(this.pantalla_Marco_Activated);
            this.Load += new System.EventHandler(this.pantalla_Marco_Load);
            this.panel_Contenedor.ResumeLayout(false);
            this.panel_Contenedor.PerformLayout();
            this.panel_Citas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_Citas_Dia)).EndInit();
            this.panel_Pacientes.ResumeLayout(false);
            this.panel_MenuAbierto.ResumeLayout(false);
            this.panel_MenuCerrado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Panel panel_MenuAbierto;
        private System.Windows.Forms.Button hamburguesa_abierta;
        private System.Windows.Forms.Button btn_CitaAbierto;
        private System.Windows.Forms.Button btn_PacienteAbierto;
        private System.Windows.Forms.Panel panel_MenuCerrado;
        private System.Windows.Forms.Button btn_CitaCerrado;
        private System.Windows.Forms.Button btn_PacienteCerrado;
        private System.Windows.Forms.Button hamburguesa_Cerrada;
        private System.Windows.Forms.Panel panel_Trabajo;
        private System.Windows.Forms.Panel panel_Pacientes;
        private System.Windows.Forms.Button btn_Paciente_Buscar;
        private System.Windows.Forms.Button btn_Paciente_Editar;
        private System.Windows.Forms.Button btn_Paciente_Agregar;
        private System.Windows.Forms.Panel panel_Citas;
        private System.Windows.Forms.MonthCalendar month_Calendario;
        private System.Windows.Forms.Button btn_Citas_Editar;
        private System.Windows.Forms.Button btn_Citas_Eliminar;
        private System.Windows.Forms.Button btn_Citas_Agregar;
        private System.Windows.Forms.DataGridView panel_Citas_Dia;
    }
}

