namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDiferencia_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox
            listBoxResultados.Items.Clear();

            // Obtener los números del primer TextBox y separarlos por comas
            string inputConjunto1 = textBoxConjunto1.Text;
            var conjunto1 = inputConjunto1.Split(',').Select(n => int.TryParse(n.Trim(), out int num) ? num : (int?)null).Where(n => n.HasValue).Select(n => n.Value).ToList();

            // Obtener los números del segundo TextBox y separarlos por comas
            string inputConjunto2 = textBoxConjunto2.Text;
            var conjunto2 = inputConjunto2.Split(',').Select(n => int.TryParse(n.Trim(), out int num) ? num : (int?)null).Where(n => n.HasValue).Select(n => n.Value).ToList();

            // Obtener la diferencia de los conjuntos
            var diferencia = ObtenerDiferencia(conjunto1, conjunto2);

            // Mostrar los números de la diferencia en el ListBox
            foreach (var numero in diferencia)
            {
                listBoxResultados.Items.Add(numero);
            }
        }


        private List<int> ObtenerDiferencia(List<int> conjunto1, List<int> conjunto2)
        {
            return conjunto1.Except(conjunto2).ToList();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxConjunto1.Clear();
            textBoxConjunto2.Clear();
            listBoxResultados.Items.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
