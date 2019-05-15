using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokebase;

namespace PokeBase
{
    class Tipos
    {
        public static string buscar(int id)
        {
            return pokebase.Pokebase.SelecionarTiposPokemon(id);
        }
    }
}
