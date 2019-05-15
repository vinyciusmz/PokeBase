using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokebase;

namespace PokeBase
{
    class Pokemon
    {
        public string nome { get; set; }
        public int id { get; set; }
        public string desc { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        public int evoluiDe { get; set; }
       
        public static List<Pokemon> listarTodos()
        {
            string retorno = pokebase.Pokebase.ListarPokemons();
            string[] splitLine = retorno.Split('\n');
            List<Pokemon> pokemons = new List<Pokemon>();
            for(int i = 0; i < splitLine.Length; i++)
            {
                Pokemon pokemon = new Pokemon();
                string[] props = splitLine[i].Split('#');
                pokemon.id = Convert.ToInt32(props[0]);
                pokemon.nome = props[1];
                pokemon.desc = props[2];
                pokemon.altura = props[3];
                pokemon.peso = props[4];
                pokemon.evoluiDe = Convert.ToInt32(props[5]);
                pokemons.Add(pokemon);
            }

            return pokemons;

        }
    }
}
