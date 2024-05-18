namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarPalindromos_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();

            // Obtener las palabras del TextBox y separarlas por comas o espacios
            string inputPalabras = txtPalabras.Text;
            var palabras = inputPalabras.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(p => p.Trim()).ToList();

            // Encontrar las palabras palíndromas y ordenarlas
            var palabrasPalindromas = EncontrarPalindromosOrdenados(palabras);

            // Mostrar las palabras palíndromas en el ListBox
            foreach (var palabra in palabrasPalindromas)
            {
                listBoxResultados.Items.Add(palabra);
            }
        }


        private List<string> EncontrarPalindromosOrdenados(List<string> palabras)
        {
            var palindromos = palabras.Where(p => EsPalindromo(p))
                                      .OrderBy(p => p.Length)
                                      .ThenBy(p => p)
                                      .ToList();
            return palindromos;
        }

        private bool EsPalindromo(string palabra)
        {
            int len = palabra.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (palabra[i] != palabra[len - i - 1])
                    return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabras.Clear();
            listBoxResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
