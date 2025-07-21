namespace ComputadorasWF
{
    public partial class Form1 : Form
    {
        ListComputadoras ListComputadoras = new ListComputadoras();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Computadora computadora = new Computadora();
            computadora.Marca = txtMarca.Text;
            computadora.Modelo = txtModelo.Text;
            computadora.Anio = mskAnioF.Text;
            computadora.MemoriaR = Convert.ToInt16(txtMemoriaR.Text);
            computadora.CapDisco = txtCapacidadD.Text;
            ListComputadoras.Agregar(computadora);
            MessageBox.Show("Datos guardados satisfactoriamente");
            Limpiar();
        }
        private void Limpiar()
        {
            txtMarca.Text = " ";
            txtModelo.Text = " ";
            mskAnioF.Text = " ";
            txtMemoriaR.Text = " ";
            txtCapacidadD.Text = " ";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvComputadoras.DataSource = ListComputadoras.Lista;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ListComputadoras = ListComputadoras;
            form2.Show();
        }
    }
}
