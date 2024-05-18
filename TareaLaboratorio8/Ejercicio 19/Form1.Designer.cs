namespace Ejercicio_19
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
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            listBoxResultados = new ListBox();
            btnProcesar = new Button();
            txtNumeros = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(3, 56);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(447, 20);
            linkLabel1.TabIndex = 94;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Numeros ordenados de menor a mayor y que no están duplicados";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(235, 455);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 93;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(97, 455);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 92;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(110, 285);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 91;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(110, 238);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(193, 29);
            btnProcesar.TabIndex = 90;
            btnProcesar.Text = "Procesar Números";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(110, 188);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(199, 27);
            txtNumeros.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 152);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 88;
            label1.Text = "Ingrese un conjunto de NUMEROS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 565);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(btnProcesar);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
        private ListBox listBoxResultados;
        private Button btnProcesar;
        private TextBox txtNumeros;
        private Label label1;
    }
}
