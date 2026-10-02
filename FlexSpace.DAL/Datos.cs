using MySql.Data.MySqlClient;

namespace FlexSpace.DAL
{
    public class Datos
    {
        public class Conexion
        {
            private string cadena = "Server=localhost;Database=biblioteca;Uid=root;Pwd=;";

            public MySqlConnection ObtenerConexion()
            {
                MySqlConnection conexion =
                new MySqlConnection(cadena);

                return conexion;
            }
        }

    }

}
