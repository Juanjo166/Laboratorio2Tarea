namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnagramas_Click(object sender, EventArgs e)
        {
            // Limpiar 
            listBoxResultados.Items.Clear();

            // Obtener y separarlas por comas o espacios
            string inputPalabras = textBoxPalabras.Text;
            var palabras = inputPalabras.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Obtener los anagramas
            var anagramas = ObtenerAnagramas(palabras);

            // Mostrar 
            foreach (var anagrama in anagramas)
            {
                listBoxResultados.Items.Add(anagrama);
            }
        }


        private List<string> ObtenerAnagramas(List<string> palabras)
        {
            var gruposAnagramas = new Dictionary<string, List<string>>();

            foreach (var palabra in palabras)
            {
                var clave = new string(palabra.ToLower().OrderBy(c => c).ToArray());

                if (!gruposAnagramas.ContainsKey(clave))
                {
                    gruposAnagramas[clave] = new List<string>();
                }
                gruposAnagramas[clave].Add(palabra);
            }

            var anagramas = new List<string>();

            foreach (var grupo in gruposAnagramas.Values)
            {
                if (grupo.Count > 1)
                {
                    anagramas.AddRange(grupo);
                }
            }

            return anagramas;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPalabras.Clear();
            listBoxResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
