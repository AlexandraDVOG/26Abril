using ITD.PERROSPERDIDOS.DOMAIN.INTERFACES;
using System.Data;


namespace ITD.PERROSPERDIDOS.INFRAESTRUCTURE.REPOSITORIES
{
    public class AdministradorRepositor : IAdministradorRepository
    {
        public readonly IDbConnection _dbConnection;

        public AdministradorRepositor(string connectionString)
        {
            _dbConnection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
        }

        public Task<int> AgregarAdministrador(string usuario, long telefono, string contrasena)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> ModificarNumeroCelular(int idUsuario, string contraseña, string nuevoNumeroCelular)
        {
            throw new System.NotImplementedException();
        }

        // ...dotnet add .bridgettejosefinafrairedominguez@MacBook-de-Brid Abril24 package MySql.Data

    }
}
