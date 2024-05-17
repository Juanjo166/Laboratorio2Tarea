namespace TareaLaboratorio7_2_
{
    public partial class Form1 : Form
    {
        Jefe jefe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboArea.SelectedIndex = 0;
            cboCargo.SelectedIndex = 0;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string dni = txtDni.Text;
            string cargo = cboCargo.Text;
            string area = cboArea.Text;
            int antiguedad = int.Parse(txtAntigüedad.Text);

            jefe = new Jefe(nombre, dni, cargo, area, antiguedad);
            MessageBox.Show("OBJETO CREADO");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Calculamos los valores una vez y los almacenamos en variables locales
            double sueldoBase = jefe.CalcularSueldoBase();
            double bonificacion = jefe.CalcularBonificacion();

            // Mostramos la información
            txtResultado.AppendText("DNI: " + jefe.Dni + Environment.NewLine);
            txtResultado.AppendText("Nombre: " + jefe.Nombres + Environment.NewLine);
            txtResultado.AppendText("Cargo: " + jefe.Cargo + Environment.NewLine);
            txtResultado.AppendText("Area: " + jefe.Area + Environment.NewLine);
            txtResultado.AppendText("Años de Antiguedad: " + jefe.AnosAntiguedad + Environment.NewLine);
            txtResultado.AppendText("Sueldo Base: " + sueldoBase + Environment.NewLine); // Mostramos la variable local
            txtResultado.AppendText("Bonificacion: " + bonificacion + Environment.NewLine); // Mostramos la variable local
            txtResultado.AppendText("Movilidad : " + jefe.AsignarMontoMovilidad() + Environment.NewLine);
            txtResultado.AppendText("Sueldo Final: " + jefe.CalcularSueldoFinal() + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDni.Clear();
            txtNombres.Clear();
            txtAntigüedad.Clear();
            txtResultado.Clear();

            cboArea.SelectedIndex = -1;
            cboCargo.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
