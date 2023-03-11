using FastFood.Models;
using FastFood.Service.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FastFood.Service
{
    public class DataConnection : IDataConnection
    {
        public async Task<General> GetBalance()
        {
            const string sqlExpression = "sp_getWholeBalance";
            General result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Balance = reader.GetDouble(0);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }

                return result;
            }
        }
    }
}
