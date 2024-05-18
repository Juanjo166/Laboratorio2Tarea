namespace Ejercicio10
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
            txtLetra = new TextBox();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            listBoxResultados = new ListBox();
            btnFiltrar = new Button();
            txtPalabras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(97, 142);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(199, 27);
            txtLetra.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 119);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 26;
            label2.Text = "Ingresar la letra deseada";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(111, 22);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(158, 20);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Una letra determinada";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(222, 392);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(84, 392);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(111, 222);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 22;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(136, 172);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 21;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(97, 80);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(199, 27);
            txtPalabras.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 57);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 19;
            label1.Text = "Ingrese un conjunto de palabras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 481);
            Controls.Add(txtLetra);
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

        private TextBox txtLetra;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
        private ListBox listBoxResultados;
        private Button btnFiltrar;
        private TextBox txtPalabras;
        private Label label1;
    }
}
