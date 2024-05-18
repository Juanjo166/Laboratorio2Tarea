namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonInterseccion_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox
            listBoxResultados.Items.Clear();

            // Obtener los números separarlos por comas
            string inputConjunto1 = textBoxConjunto1.Text;
            var conjunto1 = inputConjunto1.Split(',').Select(n => int.TryParse(n.Trim(), out int num) ? num : (int?)null).Where(n => n.HasValue).Select(n => n.Value).ToList();

            // Obtener los números del segundo separarlos por comas
            string inputConjunto2 = textBoxConjunto2.Text;
            var conjunto2 = inputConjunto2.Split(',').Select(n => int.TryParse(n.Trim(), out int num) ? num : (int?)null).Where(n => n.HasValue).Select(n => n.Value).ToList();

            // Obtener la intersección 
            var interseccion = ObtenerInterseccion(conjunto1, conjunto2);

            // Mostrar el resultado
            foreach (var numero in interseccion)
            {
                listBoxResultados.Items.Add(numero);
            }
        }

        private List<int> ObtenerInterseccion(List<int> conjunto1, List<int> conjunto2)
        {
            return conjunto1.Intersect(conjunto2).ToList();
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
