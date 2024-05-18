namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox
            listBoxResultados.Items.Clear();

            // Obtener las palabras del TextBox y separarlas por comas o espacios
            string inputPalabras = txtPalabras.Text;
            var palabras = inputPalabras.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Obtener la longitud 
            if (int.TryParse(txtLongitud.Text, out int longitud))
            {
                // Obtener las palabras que tienen la longitud 
                var palabrasFiltradas = FiltrarPorLongitud(palabras, longitud);

                // Mostrar 
                foreach (var palabra in palabrasFiltradas)
                {
                    listBoxResultados.Items.Add(palabra);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para la longitud.");
            }

        }

        private List<string> FiltrarPorLongitud(List<string> palabras, int longitud)
        {
            return palabras.Where(p => p.Length == longitud).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabras.Clear();
            txtLongitud.Clear();
            listBoxResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
