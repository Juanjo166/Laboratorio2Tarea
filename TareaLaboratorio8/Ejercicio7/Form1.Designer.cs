namespace Ejercicio7
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
            label1 = new Label();
            textBoxPalabras = new TextBox();
            buttonAnagramas = new Button();
            listBoxResultados = new ListBox();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 81);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un conjunto de palabras";
            // 
            // textBoxPalabras
            // 
            textBoxPalabras.Location = new Point(108, 119);
            textBoxPalabras.Name = "textBoxPalabras";
            textBoxPalabras.Size = new Size(125, 27);
            textBoxPalabras.TabIndex = 1;
            // 
            // buttonAnagramas
            // 
            buttonAnagramas.Location = new Point(120, 177);
            buttonAnagramas.Name = "buttonAnagramas";
            buttonAnagramas.Size = new Size(94, 29);
            buttonAnagramas.TabIndex = 2;
            buttonAnagramas.Text = "Anagramas";
            buttonAnagramas.UseVisualStyleBackColor = true;
            buttonAnagramas.Click += buttonAnagramas_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(95, 232);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(150, 104);
            listBoxResultados.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(137, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(84, 20);
            linkLabel1.TabIndex = 69;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Anagramas";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(204, 362);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 77;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(66, 362);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 76;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 446);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(linkLabel1);
            Controls.Add(listBoxResultados);
            Controls.Add(buttonAnagramas);
            Controls.Add(textBoxPalabras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPalabras;
        private Button buttonAnagramas;
        private ListBox listBoxResultados;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
