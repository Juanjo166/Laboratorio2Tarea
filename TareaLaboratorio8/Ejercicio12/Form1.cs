namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenarDesc_Click(object sender, EventArgs e)
        {
            
            listBoxResultados.Items.Clear();

            // Obtener , separarlos por comas o espacios
            string inputNumeros = txtNumeros.Text;
            var numeros = inputNumeros.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(n => int.Parse(n)).ToList();

            // Ordenar descendente
            var numerosOrdenadosDesc = OrdenarNumerosDesc(numeros);

            // Mostrar el resultado
            foreach (var numero in numerosOrdenadosDesc)
            {
                listBoxResultados.Items.Add(numero);
            }
        }

        private List<int> OrdenarNumerosDesc(List<int> numeros)
        {
            return numeros.OrderByDescending(n => n).ToList();
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
