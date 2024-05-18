namespace Ejercicio_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();

            // Obtener los números del TextBox y separarlos por comas o espacios
            string inputNumeros = txtNumeros.Text;
            var numeros = inputNumeros.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(n => int.Parse(n.Trim())).ToList();

            // Obtener los números ordenados de menor a mayor y sin duplicados
            var numerosFiltrados = ObtenerNumerosOrdenadosSinDuplicados(numeros);

            // Mostrar los números en el ListBox
            foreach (var numero in numerosFiltrados)
            {
                listBoxResultados.Items.Add(numero);
            }
        }

        private List<int> ObtenerNumerosOrdenadosSinDuplicados(List<int> numeros)
        {
            var numerosFiltrados = numeros.Distinct()
                                          .OrderBy(n => n)
                                          .ToList();
            return numerosFiltrados;
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
