namespace Ejercicio3
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
            // Limpiar el Box
            listBoxResultados.Items.Clear();


            string inputNumeros = textBoxNumeros.Text;
            var numeros = inputNumeros.Split(',').Select(n => int.TryParse(n.Trim(), out int num) ? num : (int?)null).Where(n => n.HasValue).Select(n => n.Value).ToList();

            // Obtener el divisor del TextBox
            if (int.TryParse(textBoxDivisor.Text, out int divisor) && divisor != 0)
            {
                // Filtrar los números que son divisibles por el divisor
                var numerosFiltrados = FiltrarNumerosPorDivisor(numeros, divisor);

                // Mostrar los números filtrados 
                foreach (var numero in numerosFiltrados)
                {
                    listBoxResultados.Items.Add(numero);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un divisor válido (diferente de cero).");
            }
        }


        private List<int> FiltrarNumerosPorDivisor(List<int> numeros, int divisor)
        {
            return numeros.Where(n => n % divisor == 0).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDivisor.Clear();
            textBoxNumeros.Clear();
            listBoxResultados.Items.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
