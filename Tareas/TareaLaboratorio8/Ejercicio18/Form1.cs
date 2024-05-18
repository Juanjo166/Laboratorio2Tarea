namespace Ejercicio18
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

            // Obtener la letra deseada
            string letra = txtLetra.Text.Trim();

            if (letra.Length == 1)
            {
                // Encontrar las palabras que contienen la letra deseada y ordenarlas
                var palabrasFiltradas = EncontrarPalabrasPorLetraOrdenadas(palabras, letra[0]);

                // Mostrar las palabras en el ListBox
                foreach (var palabra in palabrasFiltradas)
                {
                    listBoxResultados.Items.Add(palabra);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una única letra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<string> EncontrarPalabrasPorLetraOrdenadas(List<string> palabras, char letra)
        {
            var palabrasFiltradas = palabras.Where(p => p.Contains(letra))
                                            .OrderByDescending(p => p.Length)
                                            .ThenByDescending(p => p)
                                            .ToList();
            return palabrasFiltradas;
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
