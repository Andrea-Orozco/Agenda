namespace Agenda
{
    partial class EditarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarCita));
            this.btn_Rechazar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Clientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraFin = new System.Windows.Forms.TextBox();
            this.txtHoraInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaCita = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProced = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Rechazar
            // 
            this.btn_Rechazar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Rechazar.BackgroundImage")));
            this.btn_Rechazar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Rechazar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rechazar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Rechazar.FlatAppearance.BorderSize = 0;
            this.btn_Rechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rechazar.Location = new System.Drawing.Point(186, 346);
            this.btn_Rechazar.Name = "btn_Rechazar";
            this.btn_Rechazar.Size = new System.Drawing.Size(119, 71);
            this.btn_Rechazar.TabIndex = 49;
            this.btn_Rechazar.Text = "Cancelar";
            this.btn_Rechazar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Rechazar.UseVisualStyleBackColor = true;
            this.btn_Rechazar.Click += new System.EventHandler(this.btn_Rechazar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Aceptar.BackgroundImage")));
            this.btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Location = new System.Drawing.Point(24, 346);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(119, 71);
            this.btn_Aceptar.TabIndex = 48;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(97, 129);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(204, 20);
            this.txtRazon.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Razón cita:";
            // 
            // cb_Clientes
            // 
            this.cb_Clientes.FormattingEnabled = true;
            this.cb_Clientes.Location = new System.Drawing.Point(97, 92);
            this.cb_Clientes.Name = "cb_Clientes";
            this.cb_Clientes.Size = new System.Drawing.Size(204, 21);
            this.cb_Clientes.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Cliente: ";
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Location = new System.Drawing.Point(230, 59);
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.Size = new System.Drawing.Size(71, 20);
            this.txtHoraFin.TabIndex = 43;
            // 
            // txtHoraInicio
            // 
            this.txtHoraInicio.Location = new System.Drawing.Point(97, 59);
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.Size = new System.Drawing.Size(71, 20);
            this.txtHoraInicio.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Hora Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Hora Inicio:";
            // 
            // dtFechaCita
            // 
            this.dtFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaCita.Location = new System.Drawing.Point(98, 24);
            this.dtFechaCita.Name = "dtFechaCita";
            this.dtFechaCita.Size = new System.Drawing.Size(203, 20);
            this.dtFechaCita.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Procedimientos realizados:";
            // 
            // txtProced
            // 
            this.txtProced.Location = new System.Drawing.Point(36, 193);
            this.txtProced.Name = "txtProced";
            this.txtProced.Size = new System.Drawing.Size(265, 147);
            this.txtProced.TabIndex = 51;
            this.txtProced.Text = "";
            // 
            // EditarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(329, 461);
            this.Controls.Add(this.txtProced);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Rechazar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Clientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFechaCita);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarCita";
            this.Text = "Editar Cita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rechazar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraFin;
        private System.Windows.Forms.TextBox txtHoraInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaCita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtProced;
    }
}