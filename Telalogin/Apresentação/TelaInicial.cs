using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telalogin.Apresentação;

namespace Telalogin
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            MenuPrincipal menu = new MenuPrincipal();   
            menu.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            CadastreSe cad =new CadastreSe();   
            cad.Show();
            this.Hide();
        }

        
    }
}
