﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
	public class RepositorioInmueble : RepositorioBase, IRepositorio<Inmueble>
	{
		public RepositorioInmueble(IConfiguration configuration) : base(configuration)
		{
			
		}

		public int Alta(Inmueble entidad)
		{
			int res = -1;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"INSERT INTO inmuebles (Direccion, Ambientes, Superficie, Latitud, Longitud, IdPropietario) " +
					         $"VALUES (@direccion, @ambientes, @superficie, @latitud, @longitud, @Idpropietario); " +
					"SELECT SCOPE_IDENTITY();";//devuelve el id insertado (LAST_INSERT_ID para mysql)
				using (var command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@direccion", entidad.Direccion);
					command.Parameters.AddWithValue("@ambientes", entidad.Ambientes);
					command.Parameters.AddWithValue("@superficie", entidad.Superficie);
					command.Parameters.AddWithValue("@latitud", entidad.Latitud);
					command.Parameters.AddWithValue("@longitud", entidad.Longitud);
					command.Parameters.AddWithValue("@Idpropietario", entidad.IdPropietario);
					

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
				string sql = $"DELETE FROM Inmuebles WHERE Id = {id}";
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
		public int Modificacion(Inmueble entidad)
		{
			int res = -1;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
                string sql = "UPDATE Inmuebles SET " +
					         "Direccion=@direccion, Ambientes=@ambientes, Superficie=@superficie, Latitud=@latitud, Longitud=@longitud, IdPropietario=@Idpropietario, Disponible=@disponible " +
					         "WHERE IdInmueble=@idinmueble";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.AddWithValue("@direccion", entidad.Direccion);
					command.Parameters.AddWithValue("@ambientes", entidad.Ambientes);
					command.Parameters.AddWithValue("@superficie", entidad.Superficie);
					command.Parameters.AddWithValue("@latitud", entidad.Latitud);
					command.Parameters.AddWithValue("@longitud", entidad.Longitud);
					command.Parameters.AddWithValue("@Idpropietario", entidad.IdPropietario);
					command.Parameters.AddWithValue("@disponible", entidad.Disponible);
					command.Parameters.AddWithValue("@idinmueble", entidad.IdInmueble);
					

					command.CommandType = CommandType.Text;
					connection.Open();
					res = command.ExecuteNonQuery();
					connection.Close();
				}
			}
			return res;
		}

		public IList<Inmueble> ObtenerTodos()
		{
			IList<Inmueble> res = new List<Inmueble>();
			using (SqlConnection connection = new SqlConnection(connectionString))
		
			
			{
				string sql = $"SELECT IdInmueble, Direccion, Ambientes, Superficie, Latitud, Longitud, Disponible, Precio, i.IdPropietario, p.Nombre, p.Apellido "+
					         $"FROM inmuebles i INNER JOIN propietarios p ON i.IdPropietario = p.IdPropietario ";	
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read())
					{
						Inmueble e = new Inmueble
						{
							IdInmueble = reader.GetInt32(0),
                            Direccion = reader.GetString(1),
                            Ambientes = reader.GetInt32(2),
                            Superficie = reader.GetInt32(3),
                            Latitud = reader.GetDecimal(4),
                            Longitud = reader.GetDecimal(5),
							Disponible = reader.GetBoolean(6),
							Precio = reader.GetInt32(7),
                            IdPropietario = reader.GetInt32(8),
                            Duenio = new Propietario
                            {
                                IdPropietario = reader.GetInt32(8),
                                Nombre = reader.GetString(9),
                                Apellido = reader.GetString(10),
                            }
						};
						res.Add(e);
					}
					connection.Close();
				}
			}
			return res;
		}

		public Inmueble ObtenerPorId(int id)
		{
			Inmueble entidad = null;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
                string sql = $"SELECT IdInmueble, Direccion, Ambientes, Superficie, Latitud, Longitud, Disponible, i.IdPropietario, p.Nombre, p.Apellido" +
                    $" FROM Inmuebles i INNER JOIN Propietarios p ON i.IdPropietario = p.IdPropietario" +
                    $" WHERE IdInmueble=@id";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
					connection.Open();
					var reader = command.ExecuteReader();
					if (reader.Read())
					{
						entidad = new Inmueble
						{
							IdInmueble = reader.GetInt32(0),
                            Direccion = reader.GetString(1),
                            Ambientes = reader.GetInt32(2),
                            Superficie = reader.GetInt32(3),
                            Latitud = reader.GetDecimal(4),
                            Longitud = reader.GetDecimal(5),
							Disponible = reader.GetBoolean(6),
							IdPropietario = reader.GetInt32(7),
                            Duenio = new Propietario
                            {
                                IdPropietario = reader.GetInt32(7),
                                Nombre = reader.GetString(8),
                                Apellido = reader.GetString(9),
                            }
                        };
					}
					connection.Close();
				}
			}
			return entidad;
        }

        public IList<Inmueble> BuscarPorPropietario(int id)
        {
            List<Inmueble> res = new List<Inmueble>();
            Inmueble entidad = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = $"SELECT IdInmueble, Direccion, Ambientes, Superficie, Latitud, Longitud, Disponible, i.IdPropietario, p.Nombre, p.Apellido" +
					         $" FROM Inmuebles i INNER JOIN Propietarios p ON i.IdPropietario = p.IdPropietario" +
							 $" WHERE p.IdPropietario=@id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        entidad = new Inmueble
                        {
							IdInmueble = reader.GetInt32(0),
							Direccion = reader.GetString(1),
							Ambientes = reader.GetInt32(2),
							Superficie = reader.GetInt32(3),
							Latitud = reader.GetDecimal(4),
							Longitud = reader.GetDecimal(5),
							Disponible = reader.GetBoolean(6),
							IdPropietario = reader.GetInt32(7),
							Duenio = new Propietario
							{
								IdPropietario = reader.GetInt32(7),
								Nombre = reader.GetString(8),
								Apellido = reader.GetString(9),
							}
						};
                        res.Add(entidad);
                    }
                    connection.Close();
                }
            }
            return res;
        }

		public IList<Inmueble> MostrarDisponibles()
		{
			List<Inmueble> res = new List<Inmueble>();
			Inmueble entidad = null;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"SELECT IdInmueble, Direccion, Ambientes, Superficie, Latitud, Longitud, Disponible, i.IdPropietario, p.Nombre, p.Apellido" +
							 $" FROM Inmuebles i INNER JOIN Propietarios p ON i.IdPropietario = p.IdPropietario" +
							 $" WHERE i.Disponible=1";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read())
					{
						entidad = new Inmueble
						{
							IdInmueble = reader.GetInt32(0),
							Direccion = reader.GetString(1),
							Ambientes = reader.GetInt32(2),
							Superficie = reader.GetInt32(3),
							Latitud = reader.GetDecimal(4),
							Longitud = reader.GetDecimal(5),
							Disponible = reader.GetBoolean(6),
							IdPropietario = reader.GetInt32(7),
							Duenio = new Propietario
							{
								IdPropietario = reader.GetInt32(7),
								Nombre = reader.GetString(8),
								Apellido = reader.GetString(9),
							}
						};
						res.Add(entidad);
					}
					connection.Close();
				}
			}
			return res;
		}


		public IList<Inmueble> ListarInmueblesNoOcupados(DateTime FechaInicio, DateTime FechaFin)
		{
			IList<Inmueble> res = new List<Inmueble>();
			Inmueble entidad = null;
			using (SqlConnection connection = new SqlConnection(connectionString))


			{
				string sql = $"SELECT IdInmueble, Direccion, Ambientes, Superficie, Latitud, Longitud, Disponible, i.IdPropietario, p.Nombre, p.Apellido " +
					         $"FROM Inmuebles i INNER JOIN Propietarios p ON i.IdPropietario = p.IdPropietario " +
					         $"WHERE i.IdInmueble NOT IN " +
					        $"(SELECT c.IdInmueble " +
							 $"FROM contratos c " +
							 "WHERE (c.FechaInicio BETWEEN @fechaInicio AND @fechaFin) " +
							 "OR " +
							 "( c.FechaFin BETWEEN @fechaInicio AND @fechaFin) " +
							  "OR " +
							 "( @fechaInicio BETWEEN c.FechaInicio AND c.FechaFin) " +

							 "OR ( @fechaFin BETWEEN c.FechaInicio AND c.FechaFin))";

				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = FechaInicio;
					command.Parameters.Add("@fechaFin", SqlDbType.Date).Value = FechaFin;
					command.CommandType = CommandType.Text;
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read())
					{
						entidad = new Inmueble
						{
							IdInmueble = reader.GetInt32(0),
							Direccion = reader.GetString(1),
							Ambientes = reader.GetInt32(2),
							Superficie = reader.GetInt32(3),
							Latitud = reader.GetDecimal(4),
							Longitud = reader.GetDecimal(5),
							Disponible = reader.GetBoolean(6),
							IdPropietario = reader.GetInt32(7),
							Duenio = new Propietario
							{
								IdPropietario = reader.GetInt32(7),
								Nombre = reader.GetString(8),
								Apellido = reader.GetString(9),
							}
						};
						res.Add(entidad);
					}
					connection.Close();
				}
			}
			return res;
		}

	}
}
