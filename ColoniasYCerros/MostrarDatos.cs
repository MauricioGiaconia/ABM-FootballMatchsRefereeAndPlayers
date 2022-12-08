using ColoniasYCerros.Logica;
using ColoniasYCerros.Modelo;
using ColoniasYCerros.Scripts;
using System.Windows.Forms;

namespace ColoniasYCerros
{
    public partial class MostrarDatos : Form
    {

        private Funciones fun = new Funciones();

        private String order = "ASC", actualOrderBy = "nombre";
        private object typeOfData = new JugadorLogico();

        public string ActualOrderBy { get => actualOrderBy; set => actualOrderBy = value; }
        public string Order { get => order; set => order = value; }
        public object TypeOfData { get => typeOfData; set => typeOfData = value; }


        //PENDIENTES:
        // Ordenar codigo!
        // Adaptar ventana para poder elegir que datos mostrar (Jugadores, arbitros, equipos)
        // Agregar boton para editar cada dato en la fila

        //TERMINADOS:
        // Agregar combobox para poder elegir la cantidad de jugadores a mostrar por pagina TERMINADO!
        // Los jugadores que NO estan sancionados no deben ordenarse por fecha (quizas con un where donde sancion es 1) o que tenga que estar activa un checkbox para mostrar solo los sancionados TERMINADO!
        public MostrarDatos()
        {
            InitializeComponent();


        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
            cargarComboBoxTabla();
            cargarComboBoxMostrar();
            cargarComboBoxFiltrarPor();
            numericUpDownPages.Controls.RemoveAt(0);
            dgvDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkOrange;
            pictureBoxArrow.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
            mostrar_datos();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void mostrar_datos(int inicio = 0, String order = "nombre", String ascOrDesc = "ASC", String busqueda = "")
        {
            dgvDatos.DataSource = null;
            JugadorLogico logicaJug = JugadorLogico.Instancia;
            List<Jugador> listaJug;
            ArbitroLogico logicaArb = ArbitroLogico.Instancia;
            List<Arbitro> listaArb;
            EquipoLogico logicaEqp = EquipoLogico.Instancia;
            List<Equipo> listaEqp;
            Item filtrarPor = (Item)comboBoxFiltro.SelectedItem;

            cargarComboBoxFiltrarPor();

            updateTypeOfData();


            if (inicio > 1)
            {
                inicio = (inicio - 1) * logicaJug.PageSize;
            }
            else
            {
                inicio = 0;
            }


            if (comboBoxMostrar.SelectedItem != null)
            {
                Item itemMostrar = (Item)comboBoxMostrar.SelectedItem;

                if (this.typeOfData is JugadorLogico)
                {
                    logicaJug.PageSize = (int)itemMostrar.Value;

                } else if (this.typeOfData is ArbitroLogico)
                {
                   logicaArb.PageSize = (int)itemMostrar.Value;
                } else
                {
                   logicaEqp.PageSize = (int)itemMostrar.Value;
                }
                

            }

            if (!fun.IsNullOrEmpty(busqueda))
            {
                
                if (this.typeOfData is JugadorLogico)
                {
                    listaJug = logicaJug.listarDatos(inicio, order, ascOrDesc, true, busqueda, (string)filtrarPor.Value);
                    dgvDatos.DataSource = listaJug;
               
                }
                else if (this.typeOfData is ArbitroLogico)
                {
                    listaArb = logicaArb.listarDatos(inicio, order, ascOrDesc, true, busqueda, (string)filtrarPor.Value);
                    dgvDatos.DataSource = listaArb;
                    
                }
                else
                {
                    listaEqp = logicaEqp.listarDatos(inicio, order, ascOrDesc, true, busqueda, (string)filtrarPor.Value);
                    dgvDatos.DataSource = listaEqp;
          
                }               
            }
            else
            {
              
                if (this.typeOfData is JugadorLogico)
                {
                    listaJug = logicaJug.listarDatos(inicio, order, ascOrDesc);
                    dgvDatos.DataSource = listaJug;

                }
                else if (this.typeOfData is ArbitroLogico)
                {
                    listaArb = logicaArb.listarDatos(inicio, order, ascOrDesc);
                    dgvDatos.DataSource = listaArb;
                }
                else
                {
                    listaEqp = logicaEqp.listarDatos(inicio, order, ascOrDesc);
                    dgvDatos.DataSource = listaEqp;
                }

            }

            
            if (dgvDatos.DataSource != null)
            {
                dgvDatos.Columns["Id"].Visible = false;
            }
           

            if (this.typeOfData is JugadorLogico || this.typeOfData is EquipoLogico)
            {
                if (this.typeOfData is JugadorLogico)
                {
                    dgvDatos.Columns["JugEquipo"].Visible = false;
                    dgvDatos.Columns["Fecha_nacimiento"].HeaderText = "Fecha nacimiento";
                    dgvDatos.Columns["Fecha_sancion"].HeaderText = "Vencimiento de sancion";
                }
                else
                {
                    
                    dgvDatos.Columns["Fecha_sancion"].HeaderText = "Vencimiento de sancion";
                }
              

                bool sancionado = false;

                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    foreach (DataGridViewColumn col in dgvDatos.Columns)
                    {
                      
                        if (dgvDatos[col.Index, row.Index].Value.ToString() == "True")
                        {

                            dgvDatos.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.Red;
                            dgvDatos.Rows[row.Index].Cells[col.Index].ReadOnly = true;
                            sancionado = true;

                        }
                        else if (dgvDatos[col.Index, row.Index].Value.ToString() == "False")
                        {
                            dgvDatos.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.Green;
                            dgvDatos.Rows[row.Index].Cells[col.Index].ReadOnly = true;
                            sancionado = false;

                        }

                        if (this.typeOfData is JugadorLogico) { 
                            if (!sancionado && col.Index == dgvDatos.Columns["Fecha_sancion"].Index)
                            {

                                dgvDatos.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.LightGray;
                                dgvDatos.Rows[row.Index].Cells[col.Index].Style.ForeColor = Color.DarkGray;
                                dgvDatos[col.Index, row.Index].Value = "";

                            }
                        }
                        else
                        {
                            if (!sancionado && col.Index == dgvDatos.Columns["Fecha_sancion"].Index)
                            {

                                dgvDatos.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.LightGray;
                                dgvDatos.Rows[row.Index].Cells[col.Index].Style.ForeColor = Color.DarkGray;
                                dgvDatos[col.Index, row.Index].Value = "";

                            }
                        }
                    }
                }
            }

            addButtonColumnToDgv(dgvDatos, "Editar", "columnEdit");
            addButtonColumnToDgv(dgvDatos, "Eliminar", "columnDelete");           

            if (!fun.IsNullOrEmpty(busqueda) || logicaJug.PageSize > 15 || logicaArb.PageSize > 15 || logicaEqp.PageSize > 15)
            {
                if (this.typeOfData is JugadorLogico)
                {
                    if (logicaJug.calcularTotalPag(this.ActualOrderBy, busqueda) == 0)
                    {
                        labelPages.Text = "1";
                        numericUpDownPages.Maximum = 1;
                    }
                    else
                    {

                        labelPages.Text = logicaJug.calcularTotalPag(this.ActualOrderBy, busqueda).ToString();
                        numericUpDownPages.Maximum = logicaJug.calcularTotalPag(this.ActualOrderBy, busqueda);
                    }

                }
                else if (this.typeOfData is ArbitroLogico)
                {
                    if (logicaArb.calcularTotalPag(this.ActualOrderBy, busqueda) == 0)
                    {
                        labelPages.Text = "1";
                        numericUpDownPages.Maximum = 1;
                    }
                    else
                    {

                        labelPages.Text = logicaArb.calcularTotalPag(this.ActualOrderBy, busqueda).ToString();
                        numericUpDownPages.Maximum = logicaArb.calcularTotalPag(this.ActualOrderBy, busqueda);
                    }
                }
                else
                {
                    if (logicaEqp.calcularTotalPag(this.ActualOrderBy, busqueda) == 0)
                    {
                        labelPages.Text = "1";
                        numericUpDownPages.Maximum = 1;
                    }
                    else
                    {

                        labelPages.Text = logicaEqp.calcularTotalPag(this.ActualOrderBy, busqueda).ToString();
                        numericUpDownPages.Maximum = logicaEqp.calcularTotalPag(this.ActualOrderBy, busqueda);
                    }
                }


            }
            else
            {

                if (this.typeOfData is JugadorLogico)
                {
                    labelPages.Text = (logicaJug.calcularTotalPag(this.ActualOrderBy) == 0) ? "1" : logicaJug.calcularTotalPag(this.ActualOrderBy).ToString();
                    numericUpDownPages.Maximum = (logicaJug.calcularTotalPag(this.ActualOrderBy) == 0) ? 1 : logicaJug.calcularTotalPag(this.ActualOrderBy);

                }
                else if (this.typeOfData is ArbitroLogico)
                {
                    labelPages.Text = (logicaArb.calcularTotalPag(this.ActualOrderBy) == 0) ? "1" : logicaArb.calcularTotalPag(this.ActualOrderBy).ToString();
                    numericUpDownPages.Maximum = (logicaArb.calcularTotalPag(this.ActualOrderBy) == 0) ? 1 : logicaArb.calcularTotalPag(this.ActualOrderBy);
                }
                else
                {
                    Console.WriteLine("Eqp: " + logicaEqp.calcularTotalPag(this.ActualOrderBy));
                    labelPages.Text = (logicaEqp.calcularTotalPag(this.ActualOrderBy) == 0) ? "1" : logicaEqp.calcularTotalPag(this.ActualOrderBy).ToString();
                    numericUpDownPages.Maximum = (logicaEqp.calcularTotalPag(this.ActualOrderBy) == 0) ? 1 : logicaEqp.calcularTotalPag(this.ActualOrderBy);
                }
               
            }



        }

        private void textIdEquipo_TextChanged(object sender, EventArgs e)
        {
            mostrar_datos(0, this.actualOrderBy, this.Order, textBuscador.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((numericUpDownPages.Value - 1) >= numericUpDownPages.Minimum)
            {
                numericUpDownPages.Value--;
            }

        }

        private void numericUpDownPages_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPages.Value < 1)
            {
                numericUpDownPages.Value = 1;
            }
            else if (numericUpDownPages.Value > int.Parse(labelPages.Text))
            {
                numericUpDownPages.Value = int.Parse(labelPages.Text);
            }

            verificarYMostrar((int)numericUpDownPages.Value, this.ActualOrderBy, this.Order);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((numericUpDownPages.Value + 1) <= numericUpDownPages.Maximum)
            {
                numericUpDownPages.Value++;

            }
        }



        private void dgvJugadores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            String msg = "¿Seguro que quieres eliminar al jugador ";

            if (this.TypeOfData is ArbitroLogico)
            {
                msg = "¿Seguro que quieres eliminar al arbitro ";
                
            } else if (this.TypeOfData is EquipoLogico)
            {
                msg = "¿Seguro que quieres eliminar al equipo ";
            }

            if (e.ColumnIndex == dgvDatos.Columns["columnDelete"].Index && e.RowIndex > -1)
            {
               
                if (dgvDatos.Rows[e.RowIndex].Cells["Id"] != null)
                {

                    if (MessageBox.Show(msg +
                                        dgvDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString() + "?", "Confirmar",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (this.TypeOfData is JugadorLogico)
                        {
                            JugadorLogico.Instancia.deleteDato(int.Parse(dgvDatos.Rows[e.RowIndex].Cells["Id"].Value.ToString()));

                        } else if (this.TypeOfData is ArbitroLogico)
                        {

                            ArbitroLogico.Instancia.deleteDato(int.Parse(dgvDatos.Rows[e.RowIndex].Cells["Id"].Value.ToString()));

                        } else if (this.TypeOfData is EquipoLogico)
                        {
                            EquipoLogico.Instancia.deleteDato(int.Parse(dgvDatos.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
                        }
                            

                        verificarYMostrar((int)numericUpDownPages.Value, this.ActualOrderBy, this.Order);
                     }

                    


                }
            } else if (e.ColumnIndex == dgvDatos.Columns["columnEdit"].Index && e.RowIndex > -1)
            {
                // Pendiente hacer la reaccion al clickear el boton editar, deberá abrir otra ventana con los datos del item clickeado y permitir editarlos
            }
        }

        private void verificarYMostrar(int page = 0, String orderBy = "nombre", String ascOrDesc = "ASC")
        {
            if (fun.IsNullOrEmpty(textBuscador.Text))
            {

                mostrar_datos(page, orderBy, ascOrDesc);
            }
            else
            {

                
                mostrar_datos(page, orderBy, ascOrDesc, textBuscador.Text);

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvJugadores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String orderBy = "";
            updateTypeOfData();

            if (e.ColumnIndex < 8)
            {
                if (dgvDatos.Columns[e.ColumnIndex].HeaderText == "Vencimiento de sancion" && this.TypeOfData is JugadorLogico)
                {
                    orderBy = "fecha_sancion";

                }
                else if (dgvDatos.Columns[e.ColumnIndex].HeaderText == "Fecha nacimiento")
                {
                    orderBy = "fecha_nacimiento";

                }
                else if (dgvDatos.Columns[e.ColumnIndex].HeaderText == "Equipo")
                {

                    orderBy = "id_equipo";

                } else if (dgvDatos.Columns[e.ColumnIndex].HeaderText == "Vencimiento de sancion" && this.TypeOfData is EquipoLogico) {
                    orderBy = "fecha_venc_sancion";

                }
                else
                {

                    orderBy = dgvDatos.Columns[e.ColumnIndex].HeaderText.ToLower();

                }

                if (orderBy == this.ActualOrderBy)
                {

                    toggleOrder();
                    rotateArrow(true);
                }
                else if (orderBy != this.ActualOrderBy && this.Order == "DESC")
                {

                    toggleOrder();
                    rotateArrow(true);
                }

                this.ActualOrderBy = orderBy;

                verificarYMostrar((int)numericUpDownPages.Value, orderBy, this.Order);
                dgvDatos.EnableHeadersVisualStyles = false;
                dgvDatos.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.LightBlue;
            }

        }



        private void pictureBoxArrow_Click(object sender, EventArgs e)
        {

            rotateArrow();
            verificarYMostrar((int)numericUpDownPages.Value, this.ActualOrderBy, this.Order);
        }

        private void rotateArrow(bool fromHeader = false)
        {

            Image img = pictureBoxArrow.Image;
            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBoxArrow.Image = img;

            if (!fromHeader)
            {
                toggleOrder();
            }



        }

        private void cargarComboBoxTabla()
        {
            List<Item> items = new List<Item>
            {
                new Item{Text = "Jugadores", Value = new JugadorLogico()},
                new Item{Text = "Arbitros", Value = new ArbitroLogico()},
                new Item{Text = "Equipos", Value = new EquipoLogico()}
            };

            cargarComboBox(comboBoxTabla, items);
        }

        private void cargarComboBoxMostrar()
        {
            List<Item> items = new List<Item>
            {
                new Item{Text = "15", Value = 15},
                new Item{Text = "30", Value = 30},
                new Item{Text = "50", Value = 50},
                new Item{Text = "100", Value = 100}
            };

            cargarComboBox(comboBoxMostrar, items);
        }

        private void cargarComboBoxFiltrarPor()
        {
            List<Item> items;
            //Quizas mas adelante agregar equipo como opcion a filtrar
            if (this.typeOfData is JugadorLogico)
            {
                items = new List<Item>
                {
                    new Item{Text = "Nombre", Value = "nombre"},
                    new Item{Text = "DNI", Value = "dni"},


                };

            } else if (this.typeOfData is ArbitroLogico)
            {
                items = new List<Item>
                {
                    new Item{Text = "Nombre", Value = "nombre"}

                };

            }
            else
            {
                items = new List<Item>
                {
                    new Item{Text = "Nombre", Value = "nombre"},
                    new Item{Text = "Abandono", Value = "abandona"},


                };
            }
            

            cargarComboBox(comboBoxFiltro, items, true);

        }

        private void cargarComboBox(ComboBox comboBox, List<Item>items, bool clean = false)
        {
            if (clean)
            {
                comboBox.Items.Clear();
            }

            foreach (Item item in items)
            {
                comboBox.Items.Add(item);
            }

            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.BackColor = Color.White;

        }

        

        private void comboBoxMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarYMostrar((int)numericUpDownPages.Value, this.ActualOrderBy, this.Order);
        }

        private void comboBoxTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTypeOfData();
            verificarYMostrar((int)numericUpDownPages.Value, "nombre", this.Order);
        }

        private void updateTypeOfData()
        {
            Item item = (Item)comboBoxTabla.SelectedItem;
            this.TypeOfData = item.Value;
        }

        private void toggleOrder()
        {
            if (this.Order == "ASC")
            {
                this.Order = "DESC";
            }
            else
            {
                this.Order = "ASC";
            }
        }

        private void addButtonColumnToDgv(DataGridView dgv, String text, String columnName)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.HeaderText = text;
            button.Text = text;
            button.UseColumnTextForButtonValue = true;
            button.Name = columnName;

            if (dgv.Columns[columnName] != null)
            {
                dgv.Columns.Remove(columnName);
            }

            dgv.Columns.Add(button);
        }
    }
}