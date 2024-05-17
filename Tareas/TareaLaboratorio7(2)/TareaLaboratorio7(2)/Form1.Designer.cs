namespace TareaLaboratorio7_2_
{
    partial class Form1
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
            lblNombre = new Label();
            txtNombres = new TextBox();
            txtDni = new TextBox();
            lblDni = new Label();
            lblAntigüedad = new Label();
            label1 = new Label();
            cboCargo = new ComboBox();
            cboArea = new ComboBox();
            lblArea = new Label();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtAntigüedad = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(45, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(45, 52);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(202, 27);
            txtNombres.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(292, 53);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(292, 30);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // lblAntigüedad
            // 
            lblAntigüedad.AutoSize = true;
            lblAntigüedad.Location = new Point(45, 97);
            lblAntigüedad.Name = "lblAntigüedad";
            lblAntigüedad.Size = new Size(87, 20);
            lblAntigüedad.TabIndex = 4;
            lblAntigüedad.Text = "Antigüedad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Cargo";
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            cboCargo.Location = new Point(579, 52);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(151, 28);
            cboCargo.TabIndex = 7;
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Planificación" });
            cboArea.Location = new Point(579, 120);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(151, 28);
            cboArea.TabIndex = 9;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(579, 97);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 20);
            lblArea.TabIndex = 8;
            lblArea.Text = "Area";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(45, 163);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(760, 229);
            txtResultado.TabIndex = 10;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(45, 424);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 11;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(171, 424);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(561, 424);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(689, 424);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtAntigüedad
            // 
            txtAntigüedad.Location = new Point(45, 120);
            txtAntigüedad.Name = "txtAntigüedad";
            txtAntigüedad.Size = new Size(125, 27);
            txtAntigüedad.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 485);
            Controls.Add(txtAntigüedad);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboArea);
            Controls.Add(lblArea);
            Controls.Add(cboCargo);
            Controls.Add(label1);
            Controls.Add(lblAntigüedad);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtNombres);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombres;
        private TextBox txtDni;
        private Label lblDni;
        private Label lblAntigüedad;
        private Label label1;
        private ComboBox cboCargo;
        private ComboBox cboArea;
        private Label lblArea;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtAntigüedad;
    }
}
