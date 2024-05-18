namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPalindromos_Click(object sender, EventArgs e)
        {
            // Limpiar el ListBox
            listBoxResultados.Items.Clear();

            // Obtener y separarlas por comas o espacios
            string inputPalabras = textBoxPalabras.Text;
            var palabras = inputPalabras.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Obtener 
            var palindromos = ObtenerPalindromos(palabras);

            // Mostrar
            foreach (var palindromo in palindromos)
            {
                listBoxResultados.Items.Add(palindromo);
            }
        }


        private List<string> ObtenerPalindromos(List<string> palabras)
        {
            return palabras.Where(p => EsPalindromo(p)).ToList();
        }

        private bool EsPalindromo(string palabra)
        {
            var reversed = new string(palabra.ToLower().Reverse().ToArray());
            return palabra.ToLower() == reversed;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPalabras.Clear();
            listBoxResultados.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
