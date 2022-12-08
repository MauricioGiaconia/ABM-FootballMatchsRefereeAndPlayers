namespace ColoniasYCerros
{
    partial class AgregarArbitro
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelColonias = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxAgregarJugador = new System.Windows.Forms.GroupBox();
            this.buttonCargarArbitro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.groupBoxAgregarJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(812, 446);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 53);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelColonias
            // 
            this.labelColonias.AutoSize = true;
            this.labelColonias.Font = new System.Drawing.Font("Nirmala UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelColonias.Location = new System.Drawing.Point(12, 9);
            this.labelColonias.Name = "labelColonias";
            this.labelColonias.Size = new System.Drawing.Size(290, 45);
            this.labelColonias.TabIndex = 25;
            this.labelColonias.Text = "Colonias Y Cerros";
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textNombre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombre.Location = new System.Drawing.Point(183, 95);
            this.textNombre.MaximumSize = new System.Drawing.Size(400, 29);
            this.textNombre.MinimumSize = new System.Drawing.Size(276, 29);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(276, 29);
            this.textNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargar.Location = new System.Drawing.Point(395, 675);
            this.btnCargar.MaximumSize = new System.Drawing.Size(450, 50);
            this.btnCargar.MinimumSize = new System.Drawing.Size(165, 50);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(165, 50);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
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
            this.label6.Text = "Agregar arbitro";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxAgregarJugador
            // 
            this.groupBoxAgregarJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBoxAgregarJugador.Controls.Add(this.buttonCargarArbitro);
            this.groupBoxAgregarJugador.Controls.Add(this.label2);
            this.groupBoxAgregarJugador.Controls.Add(this.textApellido);
            this.groupBoxAgregarJugador.Controls.Add(this.label6);
            this.groupBoxAgregarJugador.Controls.Add(this.btnCargar);
            this.groupBoxAgregarJugador.Controls.Add(this.label1);
            this.groupBoxAgregarJugador.Controls.Add(this.textNombre);
            this.groupBoxAgregarJugador.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAgregarJugador.Location = new System.Drawing.Point(188, 57);
            this.groupBoxAgregarJugador.MaximumSize = new System.Drawing.Size(900, 550);
            this.groupBoxAgregarJugador.MinimumSize = new System.Drawing.Size(561, 427);
            this.groupBoxAgregarJugador.Name = "groupBoxAgregarJugador";
            this.groupBoxAgregarJugador.Size = new System.Drawing.Size(561, 427);
            this.groupBoxAgregarJugador.TabIndex = 26;
            this.groupBoxAgregarJugador.TabStop = false;
            // 
            // buttonCargarArbitro
            // 
            this.buttonCargarArbitro.Location = new System.Drawing.Point(192, 287);
            this.buttonCargarArbitro.Name = "buttonCargarArbitro";
            this.buttonCargarArbitro.Size = new System.Drawing.Size(159, 67);
            this.buttonCargarArbitro.TabIndex = 15;
            this.buttonCargarArbitro.Text = "Cargar";
            this.buttonCargarArbitro.UseVisualStyleBackColor = true;
            this.buttonCargarArbitro.Click += new System.EventHandler(this.buttonCargarArbitro_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido:";
            // 
            // textApellido
            // 
            this.textApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textApellido.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textApellido.Location = new System.Drawing.Point(183, 165);
            this.textApellido.MaximumSize = new System.Drawing.Size(400, 29);
            this.textApellido.MinimumSize = new System.Drawing.Size(276, 29);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(276, 29);
            this.textApellido.TabIndex = 13;
            // 
            // AgregarArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.groupBoxAgregarJugador);
            this.Controls.Add(this.labelColonias);
            this.Controls.Add(this.buttonExit);
            this.Name = "AgregarArbitro";
            this.Text = "Colonias Y Cerros";
            this.groupBoxAgregarJugador.ResumeLayout(false);
            this.groupBoxAgregarJugador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private Label labelColonias;
        private TextBox textNombre;
        private Label label1;
        private Button btnCargar;
        private Label label6;
        private GroupBox groupBoxAgregarJugador;
        private Button buttonCargarArbitro;
        private Label label2;
        private TextBox textApellido;
    }
}