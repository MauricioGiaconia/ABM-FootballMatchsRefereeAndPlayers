namespace ColoniasYCerros
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelColonias = new System.Windows.Forms.Label();
            this.buttonMostrarDatos = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddJug = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCargarEquipo = new System.Windows.Forms.Button();
            this.buttonCargarArbitro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCargarPartido = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelColonias
            // 
            this.labelColonias.AutoSize = true;
            this.labelColonias.Font = new System.Drawing.Font("Nirmala UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelColonias.Location = new System.Drawing.Point(12, 9);
            this.labelColonias.Name = "labelColonias";
            this.labelColonias.Size = new System.Drawing.Size(290, 45);
            this.labelColonias.TabIndex = 0;
            this.labelColonias.Text = "Colonias Y Cerros";
            // 
            // buttonMostrarDatos
            // 
            this.buttonMostrarDatos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarDatos.Location = new System.Drawing.Point(156, 73);
            this.buttonMostrarDatos.Name = "buttonMostrarDatos";
            this.buttonMostrarDatos.Size = new System.Drawing.Size(152, 53);
            this.buttonMostrarDatos.TabIndex = 1;
            this.buttonMostrarDatos.Text = "Mostrar datos";
            this.buttonMostrarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarDatos.Click += new System.EventHandler(this.buttonMostrarJug_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(812, 446);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 53);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddJug
            // 
            this.buttonAddJug.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddJug.Location = new System.Drawing.Point(156, 14);
            this.buttonAddJug.Name = "buttonAddJug";
            this.buttonAddJug.Size = new System.Drawing.Size(152, 53);
            this.buttonAddJug.TabIndex = 3;
            this.buttonAddJug.Text = "Cargar jugador";
            this.buttonAddJug.UseVisualStyleBackColor = true;
            this.buttonAddJug.Click += new System.EventHandler(this.buttonAddJug_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.buttonCargarPartido);
            this.panel1.Controls.Add(this.buttonCargarEquipo);
            this.panel1.Controls.Add(this.buttonCargarArbitro);
            this.panel1.Controls.Add(this.buttonAddJug);
            this.panel1.Controls.Add(this.buttonMostrarDatos);
            this.panel1.Location = new System.Drawing.Point(227, 78);
            this.panel1.MaximumSize = new System.Drawing.Size(900, 660);
            this.panel1.MinimumSize = new System.Drawing.Size(450, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 381);
            this.panel1.TabIndex = 4;
            // 
            // buttonCargarEquipo
            // 
            this.buttonCargarEquipo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCargarEquipo.Location = new System.Drawing.Point(156, 191);
            this.buttonCargarEquipo.Name = "buttonCargarEquipo";
            this.buttonCargarEquipo.Size = new System.Drawing.Size(152, 53);
            this.buttonCargarEquipo.TabIndex = 6;
            this.buttonCargarEquipo.Text = "Cargar equipo";
            this.buttonCargarEquipo.UseVisualStyleBackColor = true;
            this.buttonCargarEquipo.Click += new System.EventHandler(this.buttonCargarEquipo_Click);
            // 
            // buttonCargarArbitro
            // 
            this.buttonCargarArbitro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCargarArbitro.Location = new System.Drawing.Point(156, 132);
            this.buttonCargarArbitro.Name = "buttonCargarArbitro";
            this.buttonCargarArbitro.Size = new System.Drawing.Size(152, 53);
            this.buttonCargarArbitro.TabIndex = 5;
            this.buttonCargarArbitro.Text = "Cargar arbitro";
            this.buttonCargarArbitro.UseVisualStyleBackColor = true;
            this.buttonCargarArbitro.Click += new System.EventHandler(this.buttonCargarArbitro_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(55, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cargar muchos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCargarPartido
            // 
            this.buttonCargarPartido.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCargarPartido.Location = new System.Drawing.Point(156, 250);
            this.buttonCargarPartido.Name = "buttonCargarPartido";
            this.buttonCargarPartido.Size = new System.Drawing.Size(152, 53);
            this.buttonCargarPartido.TabIndex = 7;
            this.buttonCargarPartido.Text = "Cargar partido";
            this.buttonCargarPartido.UseVisualStyleBackColor = true;
            this.buttonCargarPartido.Click += new System.EventHandler(this.buttonCargarPartido_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelColonias);
            this.Name = "MainMenu";
            this.Text = "Colonias Y Cerros";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelColonias;
        private Button buttonMostrarDatos;
        private Button buttonExit;
        private Button buttonAddJug;
        private Panel panel1;
        private Button button1;
        private Button buttonCargarArbitro;
        private Button buttonCargarEquipo;
        private Button buttonCargarPartido;
    }
}