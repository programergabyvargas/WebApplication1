using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RepositorioContrato : RepositorioBase, IRepositorio<Contrato>
    {
        public RepositorioContrato(IConfiguration configuration) : base(configuration)
        {

        }

        public int Alta(Contrato entidad)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"INSERT INTO Contratos (FechaInicio, FechaFin, MontoMensual, IdInmueble, IdInquilino) " +
                              "VALUES (@fechaInicio, @fechaFin, @montoMensual, @idInmueble, @idInquilino);" +
                              "SELECT SCOPE_IDENTITY();";//devuelve el id insertado (LAST_INSERT_ID para mysql)
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@fechaInicio", entidad.FechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", entidad.FechaFin);
                    command.Parameters.AddWithValue("@montoMensual", entidad.MontoMensual);
                    command.Parameters.AddWithValue("@idInmueble", entidad.IdInmueble);
                    command.Parameters.AddWithValue("@idInquilino", entidad.IdInquilino);
                    connection.Open();
                    res = Convert.ToInt32(command.ExecuteScalar());
                    entidad.IdInmueble = res;
                    connection.Close();
                }
            }
            return res;
        }
        public int Baja(int id)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"DELETE FROM Contratos WHERE IdContrato = {id}";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }
        public int Modificacion(Contrato entidad)
        {
            int res = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"UPDATE contratos SET " +
                             $"FechaInicio=@fechaInicio, FechaFin=@fechaFin, MontoMensual=@montoMensual, IdInmueble=@idInmueble, IdInquilino=@idInquilino " +
                             $"WHERE IdContrato = @idContrato";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@fechaInicio", entidad.FechaInicio);
                    command.Parameters.AddWithValue("@fechaFin", entidad.FechaFin);
                    command.Parameters.AddWithValue("@montoMensual", entidad.MontoMensual);
                    command.Parameters.AddWithValue("@idInmueble", entidad.IdInmueble);
                    command.Parameters.AddWithValue("@idInquilino", entidad.IdInquilino);
                    command.Parameters.AddWithValue("@idContrato", entidad.IdContrato);

                    command.CommandType = CommandType.Text;
                    connection.Open();
                    res = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return res;
        }

        public IList<Contrato> ObtenerTodos()
        {
            IList<Contrato> res = new List<Contrato>();
            using (SqlConnection connection = new SqlConnection(connectionString))


            {
                string sql = $"SELECT IdContrato, FechaInicio, FechaFin, MontoMensual, c.IdInmueble, c.IdInquilino, i.Direccion, l.Apellido, l.Nombre " +
                           "FROM contratos c " +
                           "INNER JOIN inmuebles i ON c.IdInmueble = i.IdInmueble " +
                           "INNER JOIN inquilinos l ON c.IdInquilino = l.IdInquilino;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Contrato e = new Contrato
                        {
                            IdContrato = reader.GetInt32(0),
                            FechaInicio = reader.GetDateTime(1),
                            FechaFin = reader.GetDateTime(2),
                            MontoMensual = reader.GetInt32(3),
                            IdInmueble = reader.GetInt32(4),
                            IdInquilino = reader.GetInt32(5),
                            PropiedadAlquilada = new Inmueble
                            {
                                IdInmueble = reader.GetInt32(4),
                                Direccion = reader.GetString(6),
                               
                            },
                            Locatario = new Inquilino
                            {
                                IdInquilino = reader.GetInt32(5),
                                Apellido = reader.GetString(7),
                                Nombre = reader.GetString(8),
                            }
                        };
                        res.Add(e);
                    }
                    connection.Close();
                }
            }
            return res;
        }

        public Contrato ObtenerPorId(int id)
        {
            Contrato entidad = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT IdContrato, FechaInicio, FechaFin, MontoMensual, c.IdInmueble, c.IdInquilino, i.Direccion, l.Apellido, l.Nombre " +
                              "FROM contratos c " +
                              "INNER JOIN inmuebles i ON c.IdInmueble = i.IdInmueble " +
                              "INNER JOIN inquilinos l ON c.IdInquilino = l.IdInquilino " +
                              "WHERE IdContrato=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        entidad = new Contrato
                        {
                            IdContrato = reader.GetInt32(0),
                            FechaInicio = reader.GetDateTime(1),
                            FechaFin = reader.GetDateTime(2),
                            MontoMensual = reader.GetInt32(3),
                            IdInmueble = reader.GetInt32(4),
                            IdInquilino = reader.GetInt32(5),
                            PropiedadAlquilada = new Inmueble
                            {
                                IdInmueble = reader.GetInt32(4),
                                Direccion = reader.GetString(6),

                            },
                            Locatario = new Inquilino
                            {
                                IdInquilino = reader.GetInt32(5),
                                Apellido = reader.GetString(7),
                                Nombre = reader.GetString(8),
                            }
                        };
                    }
                    connection.Close();
                }
            }
            return entidad;
        }

        public IList<Contrato> BuscarPorContrato(int IdContrato)
        {
            List<Contrato> res = new List<Contrato>();


            return res;
        }

        public IList<Contrato> BuscarPorInquilino(int IdInquilino)
        {
            List<Contrato> res = new List<Contrato>();
            return res;
        }

        public IList<Contrato> BuscarPorInmueble(int id)
        {

            IList<Contrato> res = new List<Contrato>();
            using (SqlConnection connection = new SqlConnection(connectionString))


            {
                string sql = $"SELECT IdContrato, FechaInicio, FechaFin, MontoMensual, c.IdInmueble, c.IdInquilino, i.Direccion, l.Apellido, l.Nombre " +
                           "FROM contratos c " +
                           "INNER JOIN inmuebles i ON c.IdInmueble = i.IdInmueble " +
                           "INNER JOIN inquilinos l ON c.IdInquilino = l.IdInquilino " +
                           "WHERE c.IdInmueble =@id";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Contrato e = new Contrato
                        {
                            IdContrato = reader.GetInt32(0),
                            FechaInicio = reader.GetDateTime(1),
                            FechaFin = reader.GetDateTime(2),
                            MontoMensual = reader.GetInt32(3),
                            IdInmueble = reader.GetInt32(4),
                            IdInquilino = reader.GetInt32(5),
                            PropiedadAlquilada = new Inmueble
                            {
                                IdInmueble = reader.GetInt32(4),
                                Direccion = reader.GetString(6),

                            },
                            Locatario = new Inquilino
                            {
                                IdInquilino = reader.GetInt32(5),
                                Apellido = reader.GetString(7),
                                Nombre = reader.GetString(8),
                            }
                        };
                        res.Add(e);
                    }
                    connection.Close();
                }
            }
            return res;
        }


        public IList<Contrato> ObtenerVigentes(DateTime FechaInicio, DateTime FechaFin)
        {
            IList<Contrato> res = new List<Contrato>();
            using (SqlConnection connection = new SqlConnection(connectionString))


            {
                string sql = $"SELECT * " +
                             $"FROM contratos c " +
                             "WHERE (c.FechaInicio BETWEEN @fechaInicio AND @fechaFin) " +
                             "OR " +
                             "( c.FechaFin BETWEEN @fechaInicio AND @fechaFin) " +
                              "OR " +
                             "( @fechaInicio BETWEEN c.FechaInicio AND c.FechaFin) " +

                             "OR ( @fechaFin BETWEEN c.FechaInicio AND c.FechaFin)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = FechaInicio;
                    command.Parameters.Add("@fechaFin", SqlDbType.Date).Value = FechaFin;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Contrato e = new Contrato
                        {
                            IdContrato = reader.GetInt32(0),
                            FechaInicio = reader.GetDateTime(1),
                            FechaFin = reader.GetDateTime(2),
                            MontoMensual = reader.GetInt32(3),
                            IdInmueble = reader.GetInt32(4),
                            IdInquilino = reader.GetInt32(5),
                           /* PropiedadAlquilada = new Inmueble
                            {
                                IdInmueble = reader.GetInt32(4),
                                Direccion = reader.GetString(6),

                            },
                            Locatario = new Inquilino
                            {
                                IdInquilino = reader.GetInt32(5),
                                Apellido = reader.GetString(7),
                                Nombre = reader.GetString(8),
                            }*/
                        };
                        res.Add(e);
                    }
                    connection.Close();
                }
            }
            return res;
        }

    }
}
