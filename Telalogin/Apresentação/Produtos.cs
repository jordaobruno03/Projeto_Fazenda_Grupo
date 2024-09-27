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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            Visualizar_e_Modificar_Produtos Visualizar_Modificar = new Visualizar_e_Modificar_Produtos();
            Visualizar_Modificar.Show();
            this.Hide();
        }
    }
}
