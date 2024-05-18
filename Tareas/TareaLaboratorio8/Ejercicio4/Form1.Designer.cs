namespace Ejercicio4
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
            textBoxConjunto1 = new TextBox();
            textBoxConjunto2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonInterseccion = new Button();
            listBoxResultados = new ListBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // textBoxConjunto1
            // 
            textBoxConjunto1.Location = new Point(136, 112);
            textBoxConjunto1.Name = "textBoxConjunto1";
            textBoxConjunto1.Size = new Size(125, 27);
            textBoxConjunto1.TabIndex = 0;
            // 
            // textBoxConjunto2
            // 
            textBoxConjunto2.Location = new Point(136, 200);
            textBoxConjunto2.Name = "textBoxConjunto2";
            textBoxConjunto2.Size = new Size(125, 27);
            textBoxConjunto2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 69);
            label1.Name = "label1";
            label1.Size = new Size(265, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el primer conjunto de numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 160);
            label2.Name = "label2";
            label2.Size = new Size(265, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el primer conjunto de numeros";
            // 
            // buttonInterseccion
            // 
            buttonInterseccion.Location = new Point(151, 252);
            buttonInterseccion.Name = "buttonInterseccion";
            buttonInterseccion.Size = new Size(94, 29);
            buttonInterseccion.TabIndex = 4;
            buttonInterseccion.Text = "Intersección";
            buttonInterseccion.UseVisualStyleBackColor = true;
            buttonInterseccion.Click += buttonInterseccion_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.Location = new Point(136, 327);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(150, 104);
            listBoxResultados.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 304);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Resultado:";
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(166, 25);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(72, 20);
            linkLabel1.TabIndex = 66;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Divisibles";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(242, 454);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 71;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(104, 454);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 70;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 530);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(listBoxResultados);
            Controls.Add(buttonInterseccion);
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

        private TextBox textBoxConjunto1;
        private TextBox textBoxConjunto2;
        private Label label1;
        private Label label2;
        private Button buttonInterseccion;
        private ListBox listBoxResultados;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
