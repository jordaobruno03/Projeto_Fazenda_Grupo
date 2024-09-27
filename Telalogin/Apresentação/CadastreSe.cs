using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telalogin.Apresentação
{
    public partial class CadastreSe : Form
    {
        public CadastreSe()
        {
            InitializeComponent();
        }

        private void btnVoltarCadastro_Click(object sender, EventArgs e)
        {
            TelaInicial tela = new TelaInicial();
            tela.Show();
            this.Hide();
        }
    }
}
