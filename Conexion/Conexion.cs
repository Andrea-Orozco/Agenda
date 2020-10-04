namespace Agenda.Conexion
{
    using System;
    using System.Collections.Generic;
    using System.Data;
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

        public List<string> BuscarProcedimientos(string codigo)
        {
            List<string> Resultados = new List<string>();
            string sqlComand = string.Empty;
            string result = string.Empty;

            sqlComand = $"exec BuscaProcedimientos {codigo}";

            if (Abrir())
            {
                try
                {
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand(sqlComand, Conection);
                    cmd.CommandType = CommandType.Text;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        result = $"-----------------{reader["Fecha"].ToString()}----------------------- \n {reader["Procedimiento"].ToString()} \n -----------------{reader["Fecha"].ToString()}----------------------- \n";
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

        public bool AgregarCita(string fecha, string horaI, string razon, string idCliente, string resto)
        {
            bool respuesta = false;
            string sqlComand = $"exec AgregarCita '{fecha}','{horaI}','{razon}',{idCliente}{resto}";

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

        public bool ActualizarCita(string fecha, string horaI, string razon, string idCliente, string idCita, string resto)
        {
            bool respuesta = false;
            string sqlComand = $"exec ActualizarCita '{fecha}','{horaI}','{razon}',{idCliente},{idCita}{resto}";

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

        public DataTable BuscarCitas(string fecha)
        {
            DataTable Resultados = new DataTable();
            string sqlComand = $"exec BuscarCitas'{fecha}'";

            if (Abrir())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sqlComand, Conection);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter Adaptador = new SqlDataAdapter(cmd);
                    Adaptador.Fill(Resultados);
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

        public bool EliminarCita(string fecha, string idCliente)
        {
            bool respuesta = false;
            string sqlComand = $"exec EliminarCita {idCliente}, '{fecha}'";

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

        public string BuscaEditaCita(string codigo, string fecha)
        {
            string sqlComand = string.Empty;
            string result = string.Empty;

            sqlComand = $"exec BuscaEditaCita {codigo}, '{fecha}'";

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
                        result = reader["Fecha"].ToString() + "," + reader["HoraInicio"].ToString() + "," + reader["HoraFin"].ToString() + "," +
                                 reader["Razon"].ToString() + "," + reader["idCliente"].ToString() + "," + reader["Procedimiento"].ToString();
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

    }
}
