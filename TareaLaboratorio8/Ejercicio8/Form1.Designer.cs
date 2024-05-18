namespace Ejercicio8
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
            listBoxResultados = new ListBox();
            buttonPalindromos = new Button();
            textBoxPalabras = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(125, 240);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 7;
            // 
            // buttonPalindromos
            // 
            buttonPalindromos.Location = new Point(150, 190);
            buttonPalindromos.Name = "buttonPalindromos";
            buttonPalindromos.Size = new Size(94, 29);
            buttonPalindromos.TabIndex = 6;
            buttonPalindromos.Text = "Palindromos";
            buttonPalindromos.UseVisualStyleBackColor = true;
            buttonPalindromos.Click += buttonPalindromos_Click;
            // 
            // textBoxPalabras
            // 
            textBoxPalabras.Location = new Point(111, 134);
            textBoxPalabras.Name = "textBoxPalabras";
            textBoxPalabras.Size = new Size(199, 27);
            textBoxPalabras.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 94);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese un conjunto de palabras";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(98, 410);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(236, 410);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(160, 38);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(85, 20);
            linkLabel1.TabIndex = 70;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Palindromo";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 460);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(buttonPalindromos);
            Controls.Add(textBoxPalabras);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxResultados;
        private Button buttonPalindromos;
        private TextBox textBoxPalabras;
        private Label label1;
        private Button btnLimpiar;
        private Button btnSalir;
        private LinkLabel linkLabel1;
    }
}
