namespace Ejercicio2
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
            textBoxPalabras = new TextBox();
            textBoxLetra = new TextBox();
            buttonFiltrar = new Button();
            listBoxResultados = new ListBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // textBoxPalabras
            // 
            textBoxPalabras.Location = new Point(212, 80);
            textBoxPalabras.Name = "textBoxPalabras";
            textBoxPalabras.Size = new Size(125, 27);
            textBoxPalabras.TabIndex = 0;
            // 
            // textBoxLetra
            // 
            textBoxLetra.Location = new Point(212, 151);
            textBoxLetra.Name = "textBoxLetra";
            textBoxLetra.Size = new Size(125, 27);
            textBoxLetra.TabIndex = 1;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new Point(212, 184);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(94, 29);
            buttonFiltrar.TabIndex = 2;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += buttonFiltrar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(212, 245);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(150, 104);
            listBoxResultados.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Palabras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 128);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Letras";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(169, 18);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(262, 20);
            linkLabel1.TabIndex = 64;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Comienzan con una letra determinada";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(310, 369);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 67;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(172, 369);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 66;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 421);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxResultados);
            Controls.Add(buttonFiltrar);
            Controls.Add(textBoxLetra);
            Controls.Add(textBoxPalabras);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPalabras;
        private TextBox textBoxLetra;
        private Button buttonFiltrar;
        private ListBox listBoxResultados;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
