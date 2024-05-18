namespace Ejercicio13
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
            btnEncontrarDuplicados = new Button();
            txtNumeros = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(146, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 20);
            linkLabel1.TabIndex = 48;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Numeros duplicados";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(253, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 47;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(115, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 46;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(128, 245);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(185, 144);
            listBoxResultados.TabIndex = 45;
            // 
            // btnEncontrarDuplicados
            // 
            btnEncontrarDuplicados.Location = new Point(146, 189);
            btnEncontrarDuplicados.Name = "btnEncontrarDuplicados";
            btnEncontrarDuplicados.Size = new Size(162, 29);
            btnEncontrarDuplicados.TabIndex = 44;
            btnEncontrarDuplicados.Text = "Encontrar Duplicados";
            btnEncontrarDuplicados.UseVisualStyleBackColor = true;
            btnEncontrarDuplicados.Click += btnEncontrarDuplicados_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(128, 134);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(199, 27);
            txtNumeros.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 111);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 42;
            label1.Text = "Ingrese un conjunto de numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 490);
            Controls.Add(linkLabel1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(listBoxResultados);
            Controls.Add(btnEncontrarDuplicados);
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
        private Button btnEncontrarDuplicados;
        private TextBox txtNumeros;
        private Label label1;
    }
}
