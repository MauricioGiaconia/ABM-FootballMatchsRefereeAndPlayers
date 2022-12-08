using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using ColoniasYCerros.Modelo;
using System.Data.SQLite;
using System.Collections;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Security.Cryptography;

namespace ColoniasYCerros.Logica
{

    //Pendiente: ordenar por clave foranea de equipo. Decidir si hacer o no
    public class JugadorLogico
    {

        private string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static JugadorLogico _instancia = null;

        //Pagination
        private int pageSize = 15;
        private int currentPageIndex = 1;
        private int totalPage = 0;

        public JugadorLogico()
        {

        }


        public static JugadorLogico Instancia
        {
            get{

                if (_instancia == null)
                {
                    _instancia = new JugadorLogico();
                }

                return _instancia;
            }
        }

        public int PageSize { get => pageSize; set => pageSize = value; }

        public int CurrentPageIndex { get => currentPageIndex; set => currentPageIndex = value; }
        public int TotalPage { get => totalPage; set => totalPage = value; }

        public Item guardarJugador(Jugador obj)
        {
            Item respuesta = new Item();

            respuesta.Text = "¡Jugador cargado con exito!";
            respuesta.Value = true;

            int sancion = 0;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                string query = "INSERT INTO Jugadores(nombre, dni, fecha_nacimiento, id_equipo, sancionado, fecha_sancion) " +
                                "SELECT @nombre, @dni, @fecha_nacimiento, @id_equipo, @sancionado, @fecha_sancion "  +
                                "WHERE NOT EXISTS (SELECT dni FROM Jugadores WHERE dni = @dni)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                if (obj.Sancionado)
                {
                    sancion = 1;
                }

                cmd.Parameters.Add(new SQLiteParameter("@nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@dni", obj.Dni));
                cmd.Parameters.Add(new SQLiteParameter("@fecha_nacimiento", obj.Fecha_nacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@id_equipo", obj.JugEquipo.Id));
                cmd.Parameters.Add(new SQLiteParameter("@sancionado", sancion));
                cmd.Parameters.Add(new SQLiteParameter("@fecha_sancion", obj.Fecha_sancion));

                cmd.CommandType = System.Data.CommandType.Text;

                

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta.Text = "¡ERROR: El jugador ingresado ya existe!";
                    respuesta.Value = false;
                }

              
            }

            
            return respuesta;
        }

        public List<Jugador> listarDatos(int inicio = 0, String orderBy = "nombre", String ascOrDesc = "ASC", bool filtrarNombre = false, String filtro = "", String filtrarPor = "nombre")
        {
            List<Jugador> aLista = new List<Jugador>();
            bool sancion = false;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM Jugadores";

                if (filtrarNombre)
                {
                    query += " WHERE " + filtrarPor + " LIKE @filter";
                }

                if (orderBy == "fecha_sancion" && filtrarNombre)
                {
                    query += " AND sancionado = 1";

                } else if (orderBy == "fecha_sancion")
                {
                    query += " WHERE sancionado = 1";
                }

                query += " ORDER BY " + orderBy + " " + ascOrDesc + " LIMIT @floor, @top";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@floor", inicio));
                cmd.Parameters.Add(new SQLiteParameter("@top", this.PageSize));

                
                if (filtrarNombre)
                {
                    cmd.Parameters.Add(new SQLiteParameter("@filter", "%"+filtro+"%"));

                }

                cmd.CommandType = System.Data.CommandType.Text;
              
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        if (int.Parse(dr["sancionado"].ToString()) == 1)
                        {
                            sancion = true;

                        }
                        else
                        {
                            sancion = false;
                        }

                        
                        aLista.Add(new Jugador()
                        {
                            Id = int.Parse(dr["id"].ToString()),
                            Nombre = dr["nombre"].ToString(),
                            Dni = (int)(long)dr["dni"],
                            Fecha_nacimiento = DateTime.Parse(dr["fecha_nacimiento"].ToString()),
                            JugEquipo = EquipoLogico.Instancia.GetEquipo(int.Parse(dr["id_equipo"].ToString())),
                            Sancionado = sancion,
                            Fecha_sancion = DateTime.Parse(dr["fecha_sancion"].ToString())

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
                query = "SELECT COUNT(*) FROM Jugadores";
                
                if (filtrarPor == "fecha_sancion" && filter == "")
                {
                    query += " WHERE sancionado = 1";

                } else if (filtrarPor == "fecha_sancion" && filter != "")
                {
                    query += " WHERE sancionado = 1 AND nombre LIKE @filter";
                }
                else if (filter != "" && filtrarPor != "fecha_sancion")
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

                string query = "DELETE FROM Jugadores WHERE id = @id ";

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
   

        public void cargarMuchos(int xCantidad)
        {
            int anio = 1950;
            String fecha = "-11-25 00:00:00";
            String fechaInsert = "";

            for (int i = 0; i < xCantidad; i++)
            {
                fechaInsert = (anio + i) + fecha;

                guardarJugador(new Jugador
                {
                    Nombre = "Jugador" + (i + 500),
                    Dni = i + 500,
                    Fecha_nacimiento = DateTime.Parse(fechaInsert),
                    JugEquipo = EquipoLogico.Instancia.GetEquipo(2),
                    Sancionado = true,
                    Fecha_sancion = DateTime.Parse(fechaInsert)
                });
            }
        }
    }
}
