using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class RepositorioPago
    {
		private readonly string connectionString;
		private readonly IConfiguration configuration;

		public RepositorioPago(IConfiguration configuration) 
		{
			this.configuration = configuration;
			connectionString = configuration["ConnectionStrings:DefaultConnection"];
		}

		public int Alta(Pago p)
		{
			int res = -1;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"INSERT INTO Pagos (NroPago, FechaPago, Importe, IdContrato) " +
					$"VALUES (@nroPago, @fechaPago, @importe, @idContrato);" +
					"SELECT SCOPE_IDENTITY();";//devuelve el id insertado (LAST_INSERT_ID para mysql)
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@nroPago", p.NroPago);
					command.Parameters.AddWithValue("@fechaPago", p.FechaPago);
					command.Parameters.AddWithValue("@importe", p.Importe);
					command.Parameters.AddWithValue("@idContrato", p.IdContrato);
					connection.Open();
					res = Convert.ToInt32(command.ExecuteScalar());
					p.IdPago = res;
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
				string sql = $"DELETE FROM Pagos WHERE IdPago = @id";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@id", id);
					connection.Open();
					res = command.ExecuteNonQuery();
					connection.Close();
				}
			}
			return res;
		}
		public int Modificacion(Pago p)
		{
			int res = -1;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"UPDATE Pagos SET NroPago=@nroPago, FechaPago=@fechaPago, Importe=@importe, IdContrato=@idContrato " +
					         $"WHERE IdPago = @idPago";
				
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@nroPago", p.NroPago);
					command.Parameters.AddWithValue("@fechaPago", p.FechaPago);
					command.Parameters.AddWithValue("@importe", p.Importe);
					command.Parameters.AddWithValue("@idContrato", p.IdContrato);
					command.Parameters.AddWithValue("@idPago", p.IdPago);
					connection.Open();
					res = command.ExecuteNonQuery();
					connection.Close();
				}
			}
			return res;
		}

		public IList<Pago> ObtenerTodos()
		{
			IList<Pago> res = new List<Pago>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"SELECT IdPago, NroPago, FechaPago, Importe, IdContrato " +
					         $"FROM Pagos";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read())
					{
						Pago p = new Pago
						{
							IdPago = reader.GetInt32(0),
							NroPago = reader.GetInt32(1),
							FechaPago = reader.GetDateTime(2),
							Importe = reader.GetInt32(3),
							IdContrato = reader.GetInt32(4),
							
						};
						res.Add(p);
					}
					connection.Close();
				}
			}
			return res;
		}

		public Pago ObtenerPorId(int id)
		{
			Pago p = null;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"SELECT * FROM Pagos " +
					         $"WHERE IdPago=@id";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.Add("@id", SqlDbType.Int).Value = id;
					command.CommandType = CommandType.Text;
					connection.Open();
					var reader = command.ExecuteReader();
					if (reader.Read())
					{
						p = new Pago
						{
							IdPago = reader.GetInt32(0),
							NroPago = reader.GetInt32(1),
							FechaPago = reader.GetDateTime(2),
							Importe = reader.GetInt32(3),
							IdContrato = reader.GetInt32(4),
						};
					}
					connection.Close();
				}
			}
			return p;
		}

		public Pago ObtenerPorNumeroDePago(int nroPago)
		{
			Pago p = null;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"SELECT IdPago, NroPago, FechaPago, Importe, IdContrato FROM Pagos" +
					$" WHERE NroPago=@nroPago";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.CommandType = CommandType.Text;
					command.Parameters.Add("@nroPago", SqlDbType.VarChar).Value = nroPago;
					connection.Open();
					var reader = command.ExecuteReader();
					if (reader.Read())
					{
						p = new Pago
						{
							IdPago = reader.GetInt32(0),
							NroPago = reader.GetInt32(1),
							FechaPago = reader.GetDateTime(2),
							Importe = reader.GetInt32(3),
							IdContrato = reader.GetInt32(4),
						};
					}
					connection.Close();
				}
			}
			return p;
		}

		public IList<Pago> BuscarPorContrato(int idContrato)
		{
			List<Pago> res = new List<Pago>();
			Pago p = null;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				string sql = $"SELECT IdPago, NroPago, FechaPago, Importe, IdContrato FROM Pagos " +
					         $"WHERE IdContrato = @idContrato";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.Add("@idContrato", SqlDbType.VarChar).Value = idContrato;
					command.CommandType = CommandType.Text;
					connection.Open();
					var reader = command.ExecuteReader();
					while (reader.Read())
					{
						p = new Pago
						{
							IdPago = reader.GetInt32(0),
							NroPago = reader.GetInt32(1),
							FechaPago = reader.GetDateTime(2),
							Importe = reader.GetInt32(3),
							IdContrato = reader.GetInt32(4),
						};
						res.Add(p);
					}
					connection.Close();
				}
			}
			return res;
		}

	}
}
