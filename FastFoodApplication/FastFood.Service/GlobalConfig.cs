using FastFood.Models;
using FastFood.Service.Interfaces;

namespace FastFood.Service
{
    public static class GlobalConfig
    {
        public static string ConnectionString { get; } = @"Server=DESKTOP-E70FG99\SQLEXPRESS;Database=FastFood;Trusted_Connection=True;TrustServerCertificate=true";

        public static IDataConnection DataConnection { get; private set; }

        public static IDataConnection ChooseDbType(DbType dbType)
        {
            switch (dbType)
            {
                case DbType.Sql:
                    DataConnection = new DataConnection();
                    break;
            }

            return DataConnection;
        }

    }
}
