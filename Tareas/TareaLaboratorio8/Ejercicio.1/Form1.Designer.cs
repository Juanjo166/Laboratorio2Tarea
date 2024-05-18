namespace Ejercicio._1
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
            btnSalir = new Button();
            btnLimpiar = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            listBoxPrimos = new ListBox();
            buttonProcesar = new Button();
            textBoxInput = new TextBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(274, 413);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 72;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(136, 413);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 71;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(176, 68);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(119, 20);
            linkLabel1.TabIndex = 70;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Numeros primos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 102);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 69;
            label1.Text = "Ingrese un conjuntos de numeros";
            // 
            // listBoxPrimos
            // 
            listBoxPrimos.FormattingEnabled = true;
            listBoxPrimos.Location = new Point(176, 279);
            listBoxPrimos.Name = "listBoxPrimos";
            listBoxPrimos.Size = new Size(150, 104);
            listBoxPrimos.TabIndex = 68;
            // 
            // buttonProcesar
            // 
            buttonProcesar.Location = new Point(187, 215);
            buttonProcesar.Name = "buttonProcesar";
            buttonProcesar.Size = new Size(94, 29);
            buttonProcesar.TabIndex = 67;
            buttonProcesar.Text = "Procesar";
            buttonProcesar.UseVisualStyleBackColor = true;
            buttonProcesar.Click += buttonProcesar_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(176, 139);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 66;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 511);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(listBoxPrimos);
            Controls.Add(buttonProcesar);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnLimpiar;
        private LinkLabel linkLabel1;
        private Label label1;
        private ListBox listBoxPrimos;
        private Button buttonProcesar;
        private TextBox textBoxInput;
    }
}
