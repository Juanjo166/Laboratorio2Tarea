namespace Ejercicio15
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
            btnEncontrarPrimos = new Button();
            txtNumeros = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(76, 52);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(370, 20);
            linkLabel1.TabIndex = 62;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Numeros primos y están ordenados de menor a mayor";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(287, 419);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 61;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(149, 419);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 60;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(162, 249);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 59;
            // 
            // btnEncontrarPrimos
            // 
            btnEncontrarPrimos.Location = new Point(162, 193);
            btnEncontrarPrimos.Name = "btnEncontrarPrimos";
            btnEncontrarPrimos.Size = new Size(193, 29);
            btnEncontrarPrimos.TabIndex = 58;
            btnEncontrarPrimos.Text = "Encontrar Primos";
            btnEncontrarPrimos.UseVisualStyleBackColor = true;
            btnEncontrarPrimos.Click += btnEncontrarPrimos_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(162, 138);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(199, 27);
            txtNumeros.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 115);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 56;
            label1.Text = "Ingrese un conjunto de numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 499);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(btnEncontrarPrimos);
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
        private Button btnEncontrarPrimos;
        private TextBox txtNumeros;
        private Label label1;
    }
}
