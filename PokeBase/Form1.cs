using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvPokemon.DataSource = Pokemon.listarTodos();
        }

        private void dgvPokemon_Click(object sender, EventArgs e)
        {
            Pokemon p = (Pokemon)dgvPokemon.SelectedRows[0].DataBoundItem;
            lblHabilidades.Text = Habilidades.buscar(p.id);
            lblFraquezas.Text = Fraquezas.buscar(p.id);
            lblTipo.Text = Tipos.buscar(p.id);
        }
    }
}
