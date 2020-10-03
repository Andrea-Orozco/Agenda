namespace Agenda.Conexion
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;

    class Conexion
    {

        public string Error { get; set; }
        SqlConnection Conection;
        public Conexion()
        {
        }

        private bool Abrir()
        {
            try
            {
                Conection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=ControlInterno;Trusted_Connection=True;");
                Conection.Open();
                return true;
            }
            catch(Exception ex)
            {
                Error = ex.ToString();
                return false;
            }
            
        }

        public bool AgregarCliente(string nombre, string apellido, string fechaN, string restoParametros)
        {
            bool respuesta = false;
            string sqlComand = $"exec AgregarCliente '{nombre}', '{apellido}', '{fechaN}'{restoParametros}";

            if(Abrir())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlComand, Conection);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    respuesta = true;
                }
                catch(Exception ex)
                {
                    Error += $" --- No se ejecutó la instruccion error: {ex.ToString()}";
                }
            }
            else
            {
                Error += " --- No se abrió la base de datos";
            }
            return respuesta;
        }

    }
}
