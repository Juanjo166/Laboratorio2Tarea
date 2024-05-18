namespace Ejercicio16
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
            btnEncontrarPalindromos = new Button();
            txtPalabras = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(66, 59);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(341, 20);
            linkLabel1.TabIndex = 69;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Palíndromos y están ordenadas de menor a mayor";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(255, 425);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 68;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(117, 425);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 67;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(130, 255);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 66;
            // 
            // btnEncontrarPalindromos
            // 
            btnEncontrarPalindromos.Location = new Point(130, 199);
            btnEncontrarPalindromos.Name = "btnEncontrarPalindromos";
            btnEncontrarPalindromos.Size = new Size(193, 29);
            btnEncontrarPalindromos.TabIndex = 65;
            btnEncontrarPalindromos.Text = "Encontrar Palíndromos";
            btnEncontrarPalindromos.UseVisualStyleBackColor = true;
            btnEncontrarPalindromos.Click += btnEncontrarPalindromos_Click;
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(130, 144);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(199, 27);
            txtPalabras.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 108);
            label1.Name = "label1";
            label1.Size = new Size(234, 20);
            label1.TabIndex = 63;
            label1.Text = "Ingrese un conjunto de PALABRAS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 512);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(btnEncontrarPalindromos);
            Controls.Add(txtPalabras);
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
        private Button btnEncontrarPalindromos;
        private TextBox txtPalabras;
        private Label label1;
    }
}
