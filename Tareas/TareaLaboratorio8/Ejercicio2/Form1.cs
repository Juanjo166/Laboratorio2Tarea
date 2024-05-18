namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            // Limpiar box
            listBoxResultados.Items.Clear();

            // Obtener las palabras del TextBox y separarlas por comas o espacios
            string inputPalabras = textBoxPalabras.Text;
            var palabras = inputPalabras.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Obtener la letra inicial del TextBox
            string letraInicial = textBoxLetra.Text;

            if (!string.IsNullOrEmpty(letraInicial) && letraInicial.Length == 1)
            {
                // Filtrar las palabras que comienzan con la letra inicial
                var palabrasFiltradas = FiltrarPalabrasPorLetra(palabras, letraInicial[0]);

                // Mostrar el resultado
                foreach (var palabra in palabrasFiltradas)
                {
                    listBoxResultados.Items.Add(palabra);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una sola letra válida.");
            }
        }


        private List<string> FiltrarPalabrasPorLetra(List<string> palabras, char letra)
        {
            return palabras.Where(p => p.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPalabras.Clear();
            textBoxLetra.Clear();
            listBoxResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
