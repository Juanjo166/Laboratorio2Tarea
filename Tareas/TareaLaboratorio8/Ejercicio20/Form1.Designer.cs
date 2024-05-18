namespace Ejercicio20
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
            label2 = new Label();
            txtLongitud = new TextBox();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            listBoxResultados = new ListBox();
            btnEncontrarPalabras = new Button();
            txtPalabras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 168);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 96;
            label2.Text = "Ingresar la longitud deseada";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(110, 207);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(199, 27);
            txtLongitud.TabIndex = 95;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(46, 31);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(323, 40);
            linkLabel1.TabIndex = 94;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Palíndromos, tienen una longitud determinada, \r\nestán ordenadas de menor a mayor";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(235, 466);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 93;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(97, 466);
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
            listBoxResultados.Location = new Point(110, 296);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 91;
            // 
            // btnEncontrarPalabras
            // 
            btnEncontrarPalabras.Location = new Point(110, 249);
            btnEncontrarPalabras.Name = "btnEncontrarPalabras";
            btnEncontrarPalabras.Size = new Size(193, 29);
            btnEncontrarPalabras.TabIndex = 90;
            btnEncontrarPalabras.Text = "Encontrar Palabras";
            btnEncontrarPalabras.UseVisualStyleBackColor = true;
            btnEncontrarPalabras.Click += btnEncontrarPalabras_Click;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(110, 126);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(199, 27);
            txtPalabras.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 90);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 88;
            label1.Text = "Ingrese un conjunto de PALABRAS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 542);
            Controls.Add(label2);
            Controls.Add(txtLongitud);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(btnEncontrarPalabras);
            Controls.Add(txtPalabras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtLongitud;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
        private ListBox listBoxResultados;
        private Button btnEncontrarPalabras;
        private TextBox txtPalabras;
        private Label label1;
    }
}
