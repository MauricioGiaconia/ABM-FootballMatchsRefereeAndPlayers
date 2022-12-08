namespace ColoniasYCerros
{
    partial class FiltroNuevoJugador
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCargarPartido = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxArbitro = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipo2 = new System.Windows.Forms.ComboBox();
            this.comboBoxEquipo1 = new System.Windows.Forms.ComboBox();
            this.textBoxPartido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCargarPartido
            // 
            this.buttonCargarPartido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCargarPartido.Location = new System.Drawing.Point(299, 269);
            this.buttonCargarPartido.Name = "buttonCargarPartido";
            this.buttonCargarPartido.Size = new System.Drawing.Size(154, 42);
            this.buttonCargarPartido.TabIndex = 23;
            this.buttonCargarPartido.Text = "Cargar";
            this.buttonCargarPartido.UseVisualStyleBackColor = true;
            this.buttonCargarPartido.Click += new System.EventHandler(this.buttonCargarPartido_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 23);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // comboBoxArbitro
            // 
            this.comboBoxArbitro.FormattingEnabled = true;
            this.comboBoxArbitro.Location = new System.Drawing.Point(241, 151);
            this.comboBoxArbitro.Name = "comboBoxArbitro";
            this.comboBoxArbitro.Size = new System.Drawing.Size(121, 23);
            this.comboBoxArbitro.TabIndex = 21;
            // 
            // comboBoxEquipo2
            // 
            this.comboBoxEquipo2.FormattingEnabled = true;
            this.comboBoxEquipo2.Location = new System.Drawing.Point(410, 97);
            this.comboBoxEquipo2.Name = "comboBoxEquipo2";
            this.comboBoxEquipo2.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEquipo2.TabIndex = 20;
            // 
            // comboBoxEquipo1
            // 
            this.comboBoxEquipo1.FormattingEnabled = true;
            this.comboBoxEquipo1.Location = new System.Drawing.Point(241, 98);
            this.comboBoxEquipo1.Name = "comboBoxEquipo1";
            this.comboBoxEquipo1.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEquipo1.TabIndex = 19;
            // 
            // textBoxPartido
            // 
            this.textBoxPartido.Location = new System.Drawing.Point(241, 42);
            this.textBoxPartido.Name = "textBoxPartido";
            this.textBoxPartido.Size = new System.Drawing.Size(320, 23);
            this.textBoxPartido.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(93, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha del partido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(163, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Arbitro:";
            // 
            // labelVs
            // 
            this.labelVs.AutoSize = true;
            this.labelVs.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVs.Location = new System.Drawing.Point(368, 97);
            this.labelVs.Name = "labelVs";
            this.labelVs.Size = new System.Drawing.Size(36, 25);
            this.labelVs.TabIndex = 15;
            this.labelVs.Text = "VS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(548, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Equipo 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(154, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Equipo 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre partido:";
            // 
            // NuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.buttonCargarPartido);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxArbitro);
            this.Controls.Add(this.comboBoxEquipo2);
            this.Controls.Add(this.comboBoxEquipo1);
            this.Controls.Add(this.textBoxPartido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelVs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoJugador";
            this.Size = new System.Drawing.Size(712, 352);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCargarPartido;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxArbitro;
        private ComboBox comboBoxEquipo2;
        private ComboBox comboBoxEquipo1;
        private TextBox textBoxPartido;
        private Label label6;
        private Label label5;
        private Label labelVs;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
