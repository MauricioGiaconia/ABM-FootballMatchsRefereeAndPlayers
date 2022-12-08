namespace ColoniasYCerros
{
    partial class MostrarDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarDatos));
            this.textBuscador = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.labelColonias = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.comboBoxMostrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.comboBoxTabla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // textBuscador
            // 
            this.textBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBuscador.Location = new System.Drawing.Point(709, 50);
            this.textBuscador.MaximumSize = new System.Drawing.Size(200, 30);
            this.textBuscador.MinimumSize = new System.Drawing.Size(100, 23);
            this.textBuscador.Name = "textBuscador";
            this.textBuscador.Size = new System.Drawing.Size(100, 23);
            this.textBuscador.TabIndex = 10;
            this.textBuscador.TextChanged += new System.EventHandler(this.textIdEquipo_TextChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(63, 77);
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(746, 375);
            this.dgvDatos.TabIndex = 13;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellContentClick_1);
            this.dgvDatos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJugadores_ColumnHeaderMouseClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(613, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Buscar:";
            // 
            // labelPages
            // 
            this.labelPages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPages.Location = new System.Drawing.Point(448, 462);
            this.labelPages.MaximumSize = new System.Drawing.Size(50, 0);
            this.labelPages.MinimumSize = new System.Drawing.Size(25, 0);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(25, 15);
            this.labelPages.TabIndex = 18;
            this.labelPages.Text = "999";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrev.Location = new System.Drawing.Point(323, 458);
            this.buttonPrev.MaximumSize = new System.Drawing.Size(150, 30);
            this.buttonPrev.MinimumSize = new System.Drawing.Size(70, 23);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(70, 23);
            this.buttonPrev.TabIndex = 19;
            this.buttonPrev.Text = "Anterior";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.Location = new System.Drawing.Point(479, 458);
            this.buttonNext.MaximumSize = new System.Drawing.Size(150, 30);
            this.buttonNext.MinimumSize = new System.Drawing.Size(70, 23);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(70, 23);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // numericUpDownPages
            // 
            this.numericUpDownPages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numericUpDownPages.Location = new System.Drawing.Point(400, 458);
            this.numericUpDownPages.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownPages.MaximumSize = new System.Drawing.Size(80, 0);
            this.numericUpDownPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPages.MinimumSize = new System.Drawing.Size(42, 0);
            this.numericUpDownPages.Name = "numericUpDownPages";
            this.numericUpDownPages.Size = new System.Drawing.Size(42, 23);
            this.numericUpDownPages.TabIndex = 21;
            this.numericUpDownPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPages.ValueChanged += new System.EventHandler(this.numericUpDownPages_ValueChanged);
            // 
            // labelColonias
            // 
            this.labelColonias.AutoSize = true;
            this.labelColonias.Font = new System.Drawing.Font("Nirmala UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelColonias.Location = new System.Drawing.Point(12, 9);
            this.labelColonias.Name = "labelColonias";
            this.labelColonias.Size = new System.Drawing.Size(290, 45);
            this.labelColonias.TabIndex = 22;
            this.labelColonias.Text = "Colonias Y Cerros";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(812, 446);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 53);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxArrow.Image = global::ColoniasYCerros.Properties.Resources.arrow;
            this.pictureBoxArrow.ImageLocation = "";
            this.pictureBoxArrow.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.InitialImage")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(404, 50);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(28, 22);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArrow.TabIndex = 24;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBoxArrow_Click);
            // 
            // comboBoxMostrar
            // 
            this.comboBoxMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMostrar.FormattingEnabled = true;
            this.comboBoxMostrar.Location = new System.Drawing.Point(550, 50);
            this.comboBoxMostrar.Name = "comboBoxMostrar";
            this.comboBoxMostrar.Size = new System.Drawing.Size(57, 23);
            this.comboBoxMostrar.TabIndex = 25;
            this.comboBoxMostrar.SelectedIndexChanged += new System.EventHandler(this.comboBoxMostrar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(550, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mostrar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(613, 50);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(90, 23);
            this.comboBoxFiltro.TabIndex = 27;
            // 
            // comboBoxTabla
            // 
            this.comboBoxTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTabla.FormattingEnabled = true;
            this.comboBoxTabla.Location = new System.Drawing.Point(438, 50);
            this.comboBoxTabla.Name = "comboBoxTabla";
            this.comboBoxTabla.Size = new System.Drawing.Size(106, 23);
            this.comboBoxTabla.TabIndex = 28;
            this.comboBoxTabla.SelectedIndexChanged += new System.EventHandler(this.comboBoxTabla_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(435, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tabla:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTabla);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMostrar);
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelColonias);
            this.Controls.Add(this.numericUpDownPages);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBuscador);
            this.Name = "MostrarDatos";
            this.Text = "Colonias Y Cerros";
            this.Load += new System.EventHandler(this.MostrarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ventanaMenu_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private TextBox textBuscador;
        private DataGridView dgvDatos;
        private Label label5;
        private Label labelPages;
        private Button buttonPrev;
        private Button buttonNext;
        private NumericUpDown numericUpDownPages;
        private Label labelColonias;
        private Button buttonExit;
        private PictureBox pictureBoxArrow;
        private ComboBox comboBoxMostrar;
        private Label label1;
        private ComboBox comboBoxFiltro;
        private ComboBox comboBoxTabla;
        private Label label2;
    }
}