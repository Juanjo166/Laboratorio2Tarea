namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
            listBoxResultados.Items.Clear();

            // Obtener los números, separarlos por comas o espacios
            string inputNumeros = txtNumeros.Text;
            var numeros = inputNumeros.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(n => int.Parse(n)).ToList();

            // Ordenar 
            var numerosOrdenados = OrdenarNumeros(numeros);

            // Mostrar el resultado
            foreach (var numero in numerosOrdenados)
            {
                listBoxResultados.Items.Add(numero);
            }
        }

        private List<int> OrdenarNumeros(List<int> numeros)
        {
            numeros.Sort();
            return numeros;
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
