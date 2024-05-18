namespace Ejercicio14
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
            btnEncontrarNoDuplicados = new Button();
            txtNumeros = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(119, 49);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(235, 20);
            linkLabel1.TabIndex = 55;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Números que no están duplicados";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(271, 418);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 54;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(133, 418);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 53;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(146, 248);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 52;
            // 
            // btnEncontrarNoDuplicados
            // 
            btnEncontrarNoDuplicados.Location = new Point(146, 192);
            btnEncontrarNoDuplicados.Name = "btnEncontrarNoDuplicados";
            btnEncontrarNoDuplicados.Size = new Size(193, 29);
            btnEncontrarNoDuplicados.TabIndex = 51;
            btnEncontrarNoDuplicados.Text = "Encontrar No Duplicados";
            btnEncontrarNoDuplicados.UseVisualStyleBackColor = true;
            btnEncontrarNoDuplicados.Click += btnEncontrarNoDuplicados_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(146, 137);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(199, 27);
            txtNumeros.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 114);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 49;
            label1.Text = "Ingrese un conjunto de numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 496);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(btnEncontrarNoDuplicados);
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
        private Button btnEncontrarNoDuplicados;
        private TextBox txtNumeros;
        private Label label1;
    }
}
