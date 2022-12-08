using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoniasYCerros.Logica;
using ColoniasYCerros.Modelo;
using ColoniasYCerros.Scripts;

namespace ColoniasYCerros.Logica
{
    public class ArbitroLogico
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ArbitroLogico instancia = null;
        private Funciones fun = new Funciones();

        //Pagination
        private int pageSize = 15;
        private int currentPageIndex = 1;
        private int totalPage = 0;

        public ArbitroLogico() { }

        public static ArbitroLogico Instancia
        {
            get
            {
                if (instancia == null) { instancia = new ArbitroLogico(); }
                return instancia;
            }
        }

        public int PageSize { get => pageSize; set => pageSize = value; }
        public int CurrentPageIndex { get => currentPageIndex; set => currentPageIndex = value; }
        public int TotalPage { get => totalPage; set => totalPage = value; }

        public Item cargarArbitro(String nombre, String apellido)
        {

            Item respuesta = new Item();

            respuesta.Text = "¡Arbitro cargado con exito!";
            respuesta.Value = true;

            if (!fun.IsNullOrEmpty(nombre) && !fun.IsNullOrEmpty(apellido))
            {

                String nomYApe = nombre.Trim() + " " + apellido.Trim();

                using (SQLiteConnection con = new SQLiteConnection(cadena))
                {
                    con.Open();
                    String query = "INSERT INTO Arbitros(nombre)" +
                                    " SELECT @name" +
                                    " WHERE NOT EXISTS (SELECT nombre FROM Arbitros WHERE nombre = @name)";

                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.Add(new SQLiteParameter("@name", nomYApe));

                    cmd.CommandType = System.Data.CommandType.Text;



                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta.Text = "¡ERROR: El arbitro ingresado ya existe!";
                        respuesta.Value = false;
                    }
                }
            }
            else
            {
                respuesta.Text = "¡ERROR: Los campos nombre y apellido estan vacios!";
                respuesta.Value = false;
            }

            return respuesta;
        }

        public List<Arbitro> listarDatos(int inicio = 0, String orderBy = "nombre", String ascOrDesc = "ASC", bool filtrarNombre = false, String filtro = "", String filtrarPor = "nombre")
        {
            List<Arbitro> aLista = new List<Arbitro>();
            bool sancion = false;
            ArbitroLogico equipoLogico = new ArbitroLogico();
            String[] aNomYApe;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Arbitros";

                if (filtrarNombre)
                {
                    query += " WHERE " + filtrarPor + " LIKE @filter";
                }

                query += " ORDER BY " + orderBy + " " + ascOrDesc + " LIMIT @floor, @top";

                Console.WriteLine(filtrarPor + " " + filtro);

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@floor", inicio));
                cmd.Parameters.Add(new SQLiteParameter("@top", this.PageSize));


                if (filtrarNombre)
                {
                    cmd.Parameters.Add(new SQLiteParameter("@filter", "%" + filtro + "%"));

                }

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        aNomYApe = dr["nombre"].ToString().Split(" ");


                        aLista.Add(new Arbitro()
                        {
                            Id = int.Parse(dr["id"].ToString()),
                            Nombre = aNomYApe[0],
                            Apellido = aNomYApe[1]

                        });
                    }

                }
            }

            return aLista;
        }

        public int calcularTotalPag(String filtrarPor = "nombre", String filter = "")
        {
            int totalPages = 0;
            String query;

            using (SQLiteConnection con = new SQLiteConnection(cadena))
            {
                con.Open();
                query = "SELECT COUNT(*) FROM Arbitros";

                if (filter != "" && filtrarPor != "fecha_sancion")
                {
                    query += " WHERE " + filtrarPor + " LIKE @filter";

                }

                SQLiteCommand cmd = new SQLiteCommand(query, con);

                if (filter != "")
                {

                    cmd.Parameters.Add(new SQLiteParameter("@filter", "%" + filter + "%"));
                }

                totalPages = int.Parse(cmd.ExecuteScalar().ToString()) / this.PageSize;
            }


            if (totalPages % this.PageSize > 0)
            {
                totalPages += 1;
            }

            return totalPages;
        }

        public bool deleteDato(int xid)
        {
            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "DELETE FROM Arbitros WHERE id = @id ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);



                cmd.Parameters.Add(new SQLiteParameter("@id", xid));
                cmd.CommandType = System.Data.CommandType.Text;


                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }


            return respuesta;
        }

    }
}
