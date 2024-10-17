namespace Cola_Doble_Dinamica
{
    public partial class Form1 : Form
    {
        ColaDoble cola;

        public Form1()
        {
            InitializeComponent();
            cola = new ColaDoble();

        }






        private void btnInsertarFrente_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtValue.Text, out valor))
            {
                cola.InsertarFrente(valor);
                MessageBox.Show($"Se ha insertado {valor} al front.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Introduce un n�mero v�lido.");
            }
            MostrarColaEnListBox();
            txtValue.Clear();
        }

        private void btnInsertarFinal_Click(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtValue.Text, out valor))
            {
                cola.InsertarFinal(valor);
                MessageBox.Show($"Se ha insertado {valor} al rear.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Introduce un n�mero v�lido.");
            }
            MostrarColaEnListBox();
            txtValue.Clear();
        }

        private void btnEliminarFrente_Click(object sender, EventArgs e)
        {
            try
            {
                int valorEliminado = cola.EliminarFrente();
                MessageBox.Show($"Se ha eliminado {valorEliminado} del front.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MostrarColaEnListBox();

        }

        private void btnEliminarFinal_Click(object sender, EventArgs e)
        {
            try
            {
                int valorEliminado = cola.EliminarFinal();
                MessageBox.Show($"Se ha eliminado {valorEliminado} del rear.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MostrarColaEnListBox();
        }

        private void btnVerFrente_Click(object sender, EventArgs e)
        {
            try
            {
                int valorFrente = cola.VerFrente();
                MessageBox.Show($"El valor en el front es {valorFrente}.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerFinal_Click(object sender, EventArgs e)
        {
            try
            {
                int valorFinal = cola.VerFinal();
                MessageBox.Show($"El valor en el rear es {valorFinal}.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void MostrarColaEnListBox()
        {
            listBoxCola.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos elementos

            if (cola.EstaVacia())
            {
                MessageBox.Show("La cola est� vac�a.");
                return;
            }



            List<int> elementos = cola.ObtenerElementos(); // Obtener los elementos de la cola

            foreach (int elemento in elementos)
            {
                listBoxCola.Items.Add(elemento); // A�adir cada elemento al ListBox
            }


        }

        private void btnSize_Click(object sender, EventArgs e)
        {
           int size= cola.Count();

            MessageBox.Show($"La Cola Doble tiene un tama�o de {size}");

        }



        


    }
}
