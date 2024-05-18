namespace Ejercicio._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProcesar_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear();

            // Obtener el texto del TextBox y separar los números por comas
            string input = textBoxInput.Text;
            var numeros = input.Split(',').Select(n => int.TryParse(n, out int num) ? num : (int?)null).Where(n => n.HasValue).Select(n => n.Value).ToList();

            // Obtener los números primos
            var numerosPrimos = ObtenerNumerosPrimos(numeros);

            // Mostrar los resultados en el box
            foreach (var primo in numerosPrimos)
            {
                listBoxPrimos.Items.Add(primo);
            }
        }


        private List<int> ObtenerNumerosPrimos(List<int> numeros)
        {
            var primos = new List<int>();
            foreach (var numero in numeros)
            {
                if (EsPrimo(numero))
                {
                    primos.Add(numero);
                }
            }
            return primos;
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            if (numero == 2)
            {
                return true;
            }
            if (numero % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            listBoxPrimos.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
