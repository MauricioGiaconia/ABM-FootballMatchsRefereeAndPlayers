namespace ColoniasYCerros
{
    partial class VentanaPartidos
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonListaPartidos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(812, 447);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 53);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelColonias
            // 
            this.labelColonias.AutoSize = true;
            this.labelColonias.Font = new System.Drawing.Font("Nirmala UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelColonias.Location = new System.Drawing.Point(12, 10);
            this.labelColonias.Name = "labelColonias";
            this.labelColonias.Size = new System.Drawing.Size(290, 45);
            this.labelColonias.TabIndex = 3;
            this.labelColonias.Text = "Colonias Y Cerros";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nuevo partido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonListaPartidos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(80, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 48);
            this.panel1.TabIndex = 6;
            // 
            // buttonListaPartidos
            // 
            this.buttonListaPartidos.BackColor = System.Drawing.Color.Gold;
            this.buttonListaPartidos.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.buttonListaPartidos.FlatAppearance.BorderSize = 2;
            this.buttonListaPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListaPartidos.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListaPartidos.Location = new System.Drawing.Point(160, 0);
            this.buttonListaPartidos.Name = "buttonListaPartidos";
            this.buttonListaPartidos.Size = new System.Drawing.Size(176, 45);
            this.buttonListaPartidos.TabIndex = 8;
            this.buttonListaPartidos.Text = "Partidos sin arbitro";
            this.buttonListaPartidos.UseVisualStyleBackColor = false;
            this.buttonListaPartidos.Click += new System.EventHandler(this.buttonListaPartidos_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 351);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 288);
            this.panel2.TabIndex = 7;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(80, 112);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(712, 352);
            this.panelContenedor.TabIndex = 7;
            // 
            // VentanaPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelColonias);
            this.Name = "VentanaPartidos";
            this.Text = "Colonias Y Cerros";
            this.Load += new System.EventHandler(this.VentanaPartidos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private Label labelColonias;
        private Button button1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panelContenedor;
        private Button buttonListaPartidos;
    }
}