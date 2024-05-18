namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncontrarDuplicados_Click(object sender, EventArgs e)
        {
            
            listBoxResultados.Items.Clear();

            // Obtener los números , separarlos por comas o espacios
            string inputNumeros = txtNumeros.Text;
            var numeros = inputNumeros.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(n => int.Parse(n)).ToList();

            // Encontrar duplicados
            var numerosDuplicados = EncontrarDuplicados(numeros);

            // Mostrar el resultado
            foreach (var numero in numerosDuplicados)
            {
                listBoxResultados.Items.Add(numero);
            }
        }

        private List<int> EncontrarDuplicados(List<int> numeros)
        {
            return numeros.GroupBy(n => n)
                          .Where(g => g.Count() > 1)
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
