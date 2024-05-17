namespace TareaLaboratorio7
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblTipodeactividad = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblCondiciondecontrato = new Label();
            cboCondicion = new ComboBox();
            cboEspecialidad = new ComboBox();
            lblEspecialidad = new Label();
            cboAfiliado = new ComboBox();
            lblTipodeseguro = new Label();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            cboActividad = new ComboBox();
            btnSalir = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(42, 42);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(42, 76);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblTipodeactividad
            // 
            lblTipodeactividad.AutoSize = true;
            lblTipodeactividad.Location = new Point(42, 119);
            lblTipodeactividad.Name = "lblTipodeactividad";
            lblTipodeactividad.Size = new Size(125, 20);
            lblTipodeactividad.TabIndex = 2;
            lblTipodeactividad.Text = "Tipo de actividad";
            lblTipodeactividad.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(202, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(202, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblCondiciondecontrato
            // 
            lblCondiciondecontrato.AutoSize = true;
            lblCondiciondecontrato.Location = new Point(419, 42);
            lblCondiciondecontrato.Name = "lblCondiciondecontrato";
            lblCondiciondecontrato.Size = new Size(157, 20);
            lblCondiciondecontrato.TabIndex = 6;
            lblCondiciondecontrato.Text = "Condicion de contrato";
            // 
            // cboCondicion
            // 
            cboCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondicion.Items.AddRange(new object[] { "ESTABLE", "CONTRATADO" });
            cboCondicion.Location = new Point(419, 75);
            cboCondicion.Name = "cboCondicion";
            cboCondicion.Size = new Size(157, 28);
            cboCondicion.TabIndex = 7;
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "ESTRUCTURAS", "RECURSOS HIDRICOS" });
            cboEspecialidad.Location = new Point(631, 75);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(157, 28);
            cboEspecialidad.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(631, 42);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 8;
            lblEspecialidad.Text = "Especialidad";
            // 
            // cboAfiliado
            // 
            cboAfiliado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAfiliado.FormattingEnabled = true;
            cboAfiliado.Items.AddRange(new object[] { "AFP", "SNP" });
            cboAfiliado.Location = new Point(419, 158);
            cboAfiliado.Name = "cboAfiliado";
            cboAfiliado.Size = new Size(157, 28);
            cboAfiliado.TabIndex = 11;
            // 
            // lblTipodeseguro
            // 
            lblTipodeseguro.AutoSize = true;
            lblTipodeseguro.Location = new Point(419, 120);
            lblTipodeseguro.Name = "lblTipodeseguro";
            lblTipodeseguro.Size = new Size(109, 20);
            lblTipodeseguro.TabIndex = 10;
            lblTipodeseguro.Text = "Tipo de seguro";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(42, 204);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(746, 260);
            txtResultado.TabIndex = 12;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(42, 481);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(583, 481);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 147);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 15;
            // 
            // cboActividad
            // 
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "OBRAS", "VIAS" });
            cboActividad.Location = new Point(42, 158);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(157, 28);
            cboActividad.TabIndex = 16;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(694, 481);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(157, 481);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(94, 29);
            btnMostrar.TabIndex = 18;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 532);
            Controls.Add(btnMostrar);
            Controls.Add(btnSalir);
            Controls.Add(cboActividad);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(cboAfiliado);
            Controls.Add(lblTipodeseguro);
            Controls.Add(cboEspecialidad);
            Controls.Add(lblEspecialidad);
            Controls.Add(cboCondicion);
            Controls.Add(lblCondiciondecontrato);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTipodeactividad);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblTipodeactividad;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblCondiciondecontrato;
        private ComboBox cboCondicion;
        private ComboBox cboEspecialidad;
        private Label lblEspecialidad;
        private ComboBox cboAfiliado;
        private Label lblTipodeseguro;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnLimpiar;
        private Label label1;
        private ComboBox cboActividad;
        private Button btnSalir;
        private Button btnMostrar;
    }
}
