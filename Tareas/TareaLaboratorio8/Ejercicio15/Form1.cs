namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarPrimos_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();

            // Obtener y separarlos por comas o espacios
            string inputNumeros = txtNumeros.Text;
            var numeros = inputNumeros.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(n => int.Parse(n)).ToList();

            // Encontrar primos y ordenarlos
            var numerosPrimos = EncontrarPrimosOrdenados(numeros);

            // Mostrar el resultado
            foreach (var numero in numerosPrimos)
            {
                listBoxResultados.Items.Add(numero);
            }
        }

        private List<int> EncontrarPrimosOrdenados(List<int> numeros)
        {
            var primos = numeros.Where(n => EsPrimo(n)).OrderBy(n => n).ToList();
            return primos;
        }

        private bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeros.Clear();
            listBoxResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
