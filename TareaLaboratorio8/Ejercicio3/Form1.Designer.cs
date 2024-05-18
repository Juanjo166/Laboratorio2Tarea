namespace Ejercicio3
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
            textBoxNumeros = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxDivisor = new TextBox();
            buttonFiltrar = new Button();
            listBoxResultados = new ListBox();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // textBoxNumeros
            // 
            textBoxNumeros.Location = new Point(169, 91);
            textBoxNumeros.Name = "textBoxNumeros";
            textBoxNumeros.Size = new Size(125, 27);
            textBoxNumeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 55);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 1;
            label1.Text = "Numeros(separa por comas)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 144);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "Divisor";
            // 
            // textBoxDivisor
            // 
            textBoxDivisor.Location = new Point(169, 176);
            textBoxDivisor.Name = "textBoxDivisor";
            textBoxDivisor.Size = new Size(125, 27);
            textBoxDivisor.TabIndex = 2;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new Point(169, 223);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(94, 29);
            buttonFiltrar.TabIndex = 4;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += buttonFiltrar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(158, 273);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(150, 104);
            listBoxResultados.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(191, 25);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 20);
            linkLabel1.TabIndex = 65;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Divisibles";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(263, 398);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 69;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(125, 398);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 68;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 468);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(linkLabel1);
            Controls.Add(listBoxResultados);
            Controls.Add(buttonFiltrar);
            Controls.Add(label2);
            Controls.Add(textBoxDivisor);
            Controls.Add(label1);
            Controls.Add(textBoxNumeros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNumeros;
        private Label label1;
        private Label label2;
        private TextBox textBoxDivisor;
        private Button buttonFiltrar;
        private ListBox listBoxResultados;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
