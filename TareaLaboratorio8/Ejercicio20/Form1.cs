namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarPalabras_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();

            // Obtener las palabras del TextBox y separarlas por comas o espacios
            string inputPalabras = txtPalabras.Text;
            var palabras = inputPalabras.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(p => p.Trim()).ToList();

            // Obtener la longitud deseada
            if (int.TryParse(txtLongitud.Text.Trim(), out int longitud))
            {
                // Encontrar las palabras que son palíndromos, tienen la longitud deseada y ordenarlas
                var palabrasFiltradas = EncontrarPalindromosPorLongitudOrdenados(palabras, longitud);

                // Mostrar las palabras en el ListBox
                foreach (var palabra in palabrasFiltradas)
                {
                    listBoxResultados.Items.Add(palabra);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una longitud válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<string> EncontrarPalindromosPorLongitudOrdenados(List<string> palabras, int longitud)
        {
            var palabrasFiltradas = palabras.Where(p => EsPalindromo(p) && p.Length == longitud)
                                            .OrderBy(p => p)
                                            .ToList();
            return palabrasFiltradas;
        }

        private bool EsPalindromo(string palabra)
        {
            int inicio = 0;
            int fin = palabra.Length - 1;
            while (inicio < fin)
            {
                if (palabra[inicio] != palabra[fin])
                {
                    return false;
                }
                inicio++;
                fin--;
            }
            return true;
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
