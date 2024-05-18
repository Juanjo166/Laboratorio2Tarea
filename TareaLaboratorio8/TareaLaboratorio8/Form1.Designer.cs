namespace TareaLaboratorio8
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
            textBoxInput = new TextBox();
            buttonProcesar = new Button();
            listBoxPrimos = new ListBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(159, 112);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 0;
            // 
            // buttonProcesar
            // 
            buttonProcesar.Location = new Point(170, 188);
            buttonProcesar.Name = "buttonProcesar";
            buttonProcesar.Size = new Size(94, 29);
            buttonProcesar.TabIndex = 1;
            buttonProcesar.Text = "Procesar";
            buttonProcesar.UseVisualStyleBackColor = true;
            buttonProcesar.Click += buttonProcesar_Click;
            // 
            // listBoxPrimos
            // 
            listBoxPrimos.FormattingEnabled = true;
            listBoxPrimos.Location = new Point(159, 252);
            listBoxPrimos.Name = "listBoxPrimos";
            listBoxPrimos.Size = new Size(150, 104);
            listBoxPrimos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 75);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingrese un conjuntos de numeros";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(159, 41);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(119, 20);
            linkLabel1.TabIndex = 63;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Numeros primos";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(257, 386);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 65;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(119, 386);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 64;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 483);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(listBoxPrimos);
            Controls.Add(buttonProcesar);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonProcesar;
        private ListBox listBoxPrimos;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
