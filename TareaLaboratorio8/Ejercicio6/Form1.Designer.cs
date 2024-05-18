namespace Ejercicio6
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
            label3 = new Label();
            listBoxResultados = new ListBox();
            buttonDiferencia = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxConjunto2 = new TextBox();
            textBoxConjunto1 = new TextBox();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 292);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 20;
            label3.Text = "Resultado:";
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(105, 315);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(150, 104);
            listBoxResultados.TabIndex = 19;
            // 
            // buttonDiferencia
            // 
            buttonDiferencia.Location = new Point(120, 240);
            buttonDiferencia.Name = "buttonDiferencia";
            buttonDiferencia.Size = new Size(94, 29);
            buttonDiferencia.TabIndex = 18;
            buttonDiferencia.Text = "Diferencia";
            buttonDiferencia.UseVisualStyleBackColor = true;
            buttonDiferencia.Click += buttonDiferencia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 148);
            label2.Name = "label2";
            label2.Size = new Size(265, 20);
            label2.TabIndex = 17;
            label2.Text = "Ingrese el primer conjunto de numeros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 57);
            label1.Name = "label1";
            label1.Size = new Size(265, 20);
            label1.TabIndex = 16;
            label1.Text = "Ingrese el primer conjunto de numeros";
            // 
            // textBoxConjunto2
            // 
            textBoxConjunto2.Location = new Point(105, 188);
            textBoxConjunto2.Name = "textBoxConjunto2";
            textBoxConjunto2.Size = new Size(125, 27);
            textBoxConjunto2.TabIndex = 15;
            // 
            // textBoxConjunto1
            // 
            textBoxConjunto1.Location = new Point(105, 100);
            textBoxConjunto1.Name = "textBoxConjunto1";
            textBoxConjunto1.Size = new Size(125, 27);
            textBoxConjunto1.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(135, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(77, 20);
            linkLabel1.TabIndex = 68;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Diferencia";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(206, 436);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 75;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(68, 436);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 74;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 477);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(listBoxResultados);
            Controls.Add(buttonDiferencia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxConjunto2);
            Controls.Add(textBoxConjunto1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ListBox listBoxResultados;
        private Button buttonDiferencia;
        private Label label2;
        private Label label1;
        private TextBox textBoxConjunto2;
        private TextBox textBoxConjunto1;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
