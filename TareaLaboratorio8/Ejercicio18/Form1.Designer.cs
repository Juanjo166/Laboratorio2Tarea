namespace Ejercicio18
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
            txtLetra = new TextBox();
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
            label2.Location = new Point(127, 179);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 87;
            label2.Text = "Ingresar la letra deseada";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(127, 218);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(199, 27);
            txtLetra.TabIndex = 86;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(52, 58);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(381, 20);
            linkLabel1.TabIndex = 85;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Letra determinada y están ordenadas de mayor a menor";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(252, 477);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 84;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(114, 477);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 83;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(127, 307);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 82;
            // 
            // btnEncontrarPalabras
            // 
            btnEncontrarPalabras.Location = new Point(127, 260);
            btnEncontrarPalabras.Name = "btnEncontrarPalabras";
            btnEncontrarPalabras.Size = new Size(193, 29);
            btnEncontrarPalabras.TabIndex = 81;
            btnEncontrarPalabras.Text = "Encontrar Palabras";
            btnEncontrarPalabras.UseVisualStyleBackColor = true;
            btnEncontrarPalabras.Click += btnEncontrarPalabras_Click;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(127, 137);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(199, 27);
            txtPalabras.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 101);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 79;
            label1.Text = "Ingrese un conjunto de PALABRAS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 557);
            Controls.Add(label2);
            Controls.Add(txtLetra);
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
        private TextBox txtLetra;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
        private ListBox listBoxResultados;
        private Button btnEncontrarPalabras;
        private TextBox txtPalabras;
        private Label label1;
    }
}
