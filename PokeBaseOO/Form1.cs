using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pokebase;


namespace PokeBaseOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtNumPokemon.Text);
            label1.Text = Pokebase.SelecionarPokemon(cod);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Pokebase.ListarCategorias();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtNumPokemon.Text);
            label1.Text = Pokebase.SelecionarCategoria(cod);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtNumPokemon.Text);
            label1.Text = Pokebase.SelecionarTiposPokemon(cod);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = Pokebase.ListarTipos();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtNumPokemon.Text);
            label1.Text = Pokebase.SelecionarHabilidadesPokemon(cod);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = Pokebase.ListarHabilidades();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            int cod = Convert.ToInt32(txtNumPokemon.Text);
            label1.Text = Pokebase.SelecionarFraquezasPokemon(cod);
        }

        private void btnListarPokemons_Click(object sender, EventArgs e)
        {
            label1.Text = Pokebase.ListarPokemons();
        }
    }
}
