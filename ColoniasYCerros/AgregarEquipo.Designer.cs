namespace ColoniasYCerros
{
    partial class AgregarEquipo
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
            this.groupBoxAgregarJugador = new System.Windows.Forms.GroupBox();
            this.buttonCargarEquipo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textEquipo = new System.Windows.Forms.TextBox();
            this.labelColonias = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxAgregarJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAgregarJugador
            // 
            this.groupBoxAgregarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBoxAgregarJugador.Controls.Add(this.buttonCargarEquipo);
            this.groupBoxAgregarJugador.Controls.Add(this.label6);
            this.groupBoxAgregarJugador.Controls.Add(this.btnCargar);
            this.groupBoxAgregarJugador.Controls.Add(this.label1);
            this.groupBoxAgregarJugador.Controls.Add(this.textEquipo);
            this.groupBoxAgregarJugador.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAgregarJugador.Location = new System.Drawing.Point(188, 58);
            this.groupBoxAgregarJugador.MaximumSize = new System.Drawing.Size(900, 550);
            this.groupBoxAgregarJugador.MinimumSize = new System.Drawing.Size(561, 427);
            this.groupBoxAgregarJugador.Name = "groupBoxAgregarJugador";
            this.groupBoxAgregarJugador.Size = new System.Drawing.Size(561, 427);
            this.groupBoxAgregarJugador.TabIndex = 29;
            this.groupBoxAgregarJugador.TabStop = false;
            // 
            // buttonCargarEquipo
            // 
            this.buttonCargarEquipo.Location = new System.Drawing.Point(192, 289);
            this.buttonCargarEquipo.Name = "buttonCargarEquipo";
            this.buttonCargarEquipo.Size = new System.Drawing.Size(159, 67);
            this.buttonCargarEquipo.TabIndex = 15;
            this.buttonCargarEquipo.Text = "Cargar";
            this.buttonCargarEquipo.UseVisualStyleBackColor = true;
            this.buttonCargarEquipo.Click += new System.EventHandler(this.buttonCargarEquipo_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(192, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Agregar equipo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargar.Location = new System.Drawing.Point(575, 1002);
            this.btnCargar.MaximumSize = new System.Drawing.Size(450, 50);
            this.btnCargar.MinimumSize = new System.Drawing.Size(165, 50);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(165, 50);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del equipo:";
            // 
            // textEquipo
            // 
            this.textEquipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textEquipo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEquipo.Location = new System.Drawing.Point(192, 162);
            this.textEquipo.MaximumSize = new System.Drawing.Size(400, 29);
            this.textEquipo.MinimumSize = new System.Drawing.Size(276, 29);
            this.textEquipo.Name = "textEquipo";
            this.textEquipo.Size = new System.Drawing.Size(276, 29);
            this.textEquipo.TabIndex = 0;
            // 
            // labelColonias
            // 
            this.labelColonias.AutoSize = true;
            this.labelColonias.Font = new System.Drawing.Font("Nirmala UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelColonias.Location = new System.Drawing.Point(12, 10);
            this.labelColonias.Name = "labelColonias";
            this.labelColonias.Size = new System.Drawing.Size(290, 45);
            this.labelColonias.TabIndex = 28;
            this.labelColonias.Text = "Colonias Y Cerros";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(812, 447);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 53);
            this.buttonExit.TabIndex = 27;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // AgregarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.groupBoxAgregarJugador);
            this.Controls.Add(this.labelColonias);
            this.Controls.Add(this.buttonExit);
            this.Name = "AgregarEquipo";
            this.Text = "Colonias Y Cerros";
            this.groupBoxAgregarJugador.ResumeLayout(false);
            this.groupBoxAgregarJugador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxAgregarJugador;
        private Button buttonCargarEquipo;
        private Label label6;
        private Button btnCargar;
        private Label label1;
        private TextBox textEquipo;
        private Label labelColonias;
        private Button buttonExit;
    }
}