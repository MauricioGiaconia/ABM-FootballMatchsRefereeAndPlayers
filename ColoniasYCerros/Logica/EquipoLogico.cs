using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColoniasYCerros.Modelo;
using System.Data.SQLite;
using System.Collections;
using System.Data.Common;

namespace ColoniasYCerros.Logica
{
    public class EquipoLogico
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static EquipoLogico _instancia = null;

        //Pagination
        private int pageSize = 15;
        private int currentPageIndex = 1;
        private int totalPage = 0;

        public EquipoLogico() { }

        public static EquipoLogico Instancia 
        {
            get {
                if (_instancia == null)
                {
                    _instancia = new EquipoLogico();
                }

                return _instancia;
            }
            
        }

        public int PageSize { get => pageSize; set => pageSize = value; }
        public int CurrentPageIndex { get => currentPageIndex; set => currentPageIndex = value; }
        public int TotalPage { get => totalPage; set => totalPage = value; }

        public Equipo GetEquipo(int xid)
        {

            Equipo equipo = new Equipo();
            bool abandono;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                String query = "SELECT * FROM Equipos AS 'eq' WHERE eq.id = @id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@id", xid));
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dre = cmd.ExecuteReader())
                {

                    while (dre.Read())
                    {
                        if (int.Parse(dre["abandona"].ToString()) == 1)
                        {
                            abandono = true;

                        }
                        else
                        {
                            abandono = false;
                        }

                        equipo.Id = int.Parse(dre["id"].ToString());
                        equipo.Nombre = dre["nombre"].ToString();
                        equipo.Abandona = abandono;

                        break;
                    }
                  
          

                }
            }

            return equipo;
        }

        public List<Equipo> listarDatos(int inicio = 0, String orderBy = "nombre", String ascOrDesc = "ASC", bool filtrarNombre = false, String filtro = "", String filtrarPor = "nombre")
        {
            List<Equipo> aLista = new List<Equipo>();
            bool sancion = false;
            EquipoLogico equipoLogico = new EquipoLogico();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Equipos";

                if (filtrarNombre)
                {
                    query += " WHERE " + filtrarPor + " LIKE @filter";
                }

                if (orderBy == "abandona" && filtrarNombre)
                {
                    query += " AND abandona = 1";

                }
                else if (orderBy == "abandona")
                {
                    query += " WHERE abandona = 1";
                }

                query += " ORDER BY " + orderBy + " " + ascOrDesc + " LIMIT @floor, @top";

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

                        if (int.Parse(dr["abandona"].ToString()) == 1)
                        {
                            sancion = true;

                        }
                        else
                        {
                            sancion = false;
                        }

                        DateTime fecha_sancion = DateTime.Now;

                        aLista.Add(new Equipo()
                        {
                            Id = int.Parse(dr["id"].ToString()),
                            Nombre = dr["nombre"].ToString(),
                            Abandona = sancion,
                            Fecha_sancion = fecha_sancion
                       }); ;
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
                query = "SELECT COUNT(*) FROM Equipos";

                if (filtrarPor == "abandona" && filter == "")
                {
                    query += " WHERE abandona = 1";

                }
                else if (filtrarPor == "abandona" && filter != "")
                {
                    query += " WHERE abandona = 1 AND nombre LIKE @filter";
                }
                else if (filter != "" && filtrarPor != "abandona")
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

                string query = "DELETE FROM Equipos WHERE id = @id ";

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

        public Item addDato(String nameEqp = "")
        {
            Item respuesta = new Item();
            respuesta.Text = "Equipo cargado con exito!";
            respuesta.Value = true;

            using (SQLiteConnection con = new SQLiteConnection(cadena))
            {
                con.Open();

                String query = "INSERT INTO Equipos(nombre, abandona)" +
                    " SELECT @newEqp, @abandona" +
                    " WHERE NOT EXISTS (SELECT Equipos.nombre, Equipos.abandona FROM Equipos WHERE Equipos.nombre = @newEqp)";

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.Add(new SQLiteParameter("@newEqp", nameEqp));
                cmd.Parameters.Add(new SQLiteParameter("@abandona", '0'));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta.Text = "El equipo ingresado ya existe en la base de datos, ingrese otro!";
                    respuesta.Value = false;
                }
            }


            return respuesta;
        }

    }
}
