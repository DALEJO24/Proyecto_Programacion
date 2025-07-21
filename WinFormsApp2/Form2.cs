using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputadorasWF
{
    public partial class Form2 : Form
    {
        public ListComputadoras ListComputadoras = new ListComputadoras();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCadena_Click(object sender, EventArgs e)
        {
            dgvCadena.Visible = true;
            dgvCadena.DataSource = ListComputadoras.ModeloEmpiezaL(txtCadena.Text);
        }

        private void btnAnioC_Click(object sender, EventArgs e)
        {
            dgvAnioC.Visible = true;
            dgvAnioC.DataSource = ListComputadoras.AnioIgual(mtxtAnioC.Text);
        }

        private void btnMemoriaR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El total de computadoras con memoria Ram con mas de dos cifras es: " + ListComputadoras.RamCifras());
        }
    }
}

}
