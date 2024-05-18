namespace Ejercicio9
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
            btnSalir = new Button();
            btnLimpiar = new Button();
            listBoxResultados = new ListBox();
            btnFiltrar = new Button();
            txtPalabras = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            txtLongitud = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(237, 395);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(99, 395);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(126, 225);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 13;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(151, 175);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 12;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(112, 83);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(199, 27);
            txtPalabras.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 60);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 10;
            label1.Text = "Ingrese un conjunto de palabras";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(126, 25);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(157, 20);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Longitud determinada";
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(112, 145);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(199, 27);
            txtLongitud.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 122);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 17;
            label2.Text = "Ingresar la longitud deseada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 463);
            Controls.Add(txtLongitud);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(btnFiltrar);
            Controls.Add(txtPalabras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnLimpiar;
        private ListBox listBoxResultados;
        private Button btnFiltrar;
        private TextBox txtPalabras;
        private Label label1;
        private LinkLabel linkLabel1;
        private TextBox txtLongitud;
        private Label label2;
    }
}
