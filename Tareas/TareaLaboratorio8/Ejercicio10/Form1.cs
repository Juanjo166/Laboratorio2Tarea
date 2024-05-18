namespace Ejercicio10
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

            // Obtener la letra deseada
            string letra = txtLetra.Text;

            if (letra.Length == 1)
            {
                // Obtener las palabras que contienen la letra especificada
                var palabrasFiltradas = FiltrarPorLetra(palabras, letra[0]);

                // Mostrar las palabras filtradas en el ListBox
                foreach (var palabra in palabrasFiltradas)
                {
                    listBoxResultados.Items.Add(palabra);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una sola letra.");
            }
        }


        private List<string> FiltrarPorLetra(List<string> palabras, char letra)
        {
            return palabras.Where(p => p.Contains(letra)).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabras.Clear();
            txtLetra.Clear();
            listBoxResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
