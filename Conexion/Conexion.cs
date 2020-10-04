namespace Agenda.Conexion
{
    using System;
    using System.Collections.Generic;
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
            catch (Exception ex)
            {
                Error = ex.ToString();
                return false;
            }

        }

        public string BuscarEditarUsuarios(string codigo)
        {
            string sqlComand = string.Empty;
            string result = string.Empty;

            sqlComand = $"Select * from Cliente where idCliente='{codigo}'";

            if (Abrir())
            {
                try
                {
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(sqlComand, Conection);
                    cmd.CommandType = System.Data.CommandType.Text;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader["Nombre"].ToString() + "," + reader["Apellido"].ToString() + "," + reader["Telefono"].ToString() + "," +
                                 reader["Correo"].ToString() + "," + reader["Peso"].ToString() + "," + reader["Altura"].ToString() + "," + 
                                 reader["FechaNacimiento"].ToString() + "," + reader["Padecimientos"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Error += $" --- No se ejecutó la instruccion error: {ex.ToString()}";
                }
                finally
                {
                    Conection.Close();
                }
            }
            else
            {
                Error += " --- No se abrió la base de datos";
            }
            return result;
        }

        public List<string> BuscarUsuarios(string nombre)
        {
            List<string> Resultados = new List<string>();
            string sqlComand = string.Empty;
            string result = string.Empty;

            if (string.IsNullOrEmpty(nombre))
            {
                sqlComand = "Select idCliente, Nombre, Apellido from Cliente";
            }
            else
            {
                sqlComand = $"Select idCliente, Nombre, Apellido from Cliente where Nombre = '{nombre}'";
            }

            if (Abrir())
            {
                try
                {
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(sqlComand, Conection);
                    cmd.CommandType = System.Data.CommandType.Text;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader["idCliente"].ToString() + "," + reader["Nombre"].ToString() + "," + reader["Apellido"].ToString();
                        Resultados.Add(result);
                    }
                }
                catch (Exception ex)
                {
                    Error += $" --- No se ejecutó la instruccion error: {ex.ToString()}";
                }
                finally
                {
                    Conection.Close();
                }
            }
            else
            {
                Error += " --- No se abrió la base de datos";
            }
            return Resultados;
        }

        public bool AgregarCliente(string nombre, string apellido, string fechaN, string restoParametros)
        {
            bool respuesta = false;
            string sqlComand = $"exec AgregarCliente '{nombre}', '{apellido}', '{fechaN}'{restoParametros}";

            if (Abrir())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlComand, Conection);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    Error += $" --- No se ejecutó la instruccion error: {ex.ToString()}";
                }
                finally
                {
                    Conection.Close();
                }
            }
            else
            {
                Error += " --- No se abrió la base de datos";
            }
            return respuesta;
        }

        public bool ActualizarCliente(string nombre, string apellido, string fechaN, string idCliente, string restoParametros)
        {
            bool respuesta = false;
            string sqlComand = $"exec ActualizaCliente '{nombre}', '{apellido}', '{fechaN}',{idCliente}{restoParametros}";

            if (Abrir())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlComand, Conection);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    respuesta = true;
                }
                catch (Exception ex)
                {
                    Error += $" --- No se ejecutó la instruccion error: {ex.ToString()}";
                }
                finally
                {
                    Conection.Close();
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
