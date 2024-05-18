namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarNoDuplicados_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();

            // Obtener y separarlos por comas o espacios LOS NUMEROS
            string inputNumeros = txtNumeros.Text;
            var numeros = inputNumeros.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(n => int.Parse(n)).ToList();

            // Encontrar los no duplicados
            var numerosNoDuplicados = EncontrarNoDuplicados(numeros);

            // Mostrar EL RESULTADO
            foreach (var numero in numerosNoDuplicados)
            {
                listBoxResultados.Items.Add(numero);
            }
        }

        private List<int> EncontrarNoDuplicados(List<int> numeros)
        {
            return numeros.GroupBy(n => n)
                          .Where(g => g.Count() == 1)
                          .Select(g => g.Key)
                          .ToList();
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
