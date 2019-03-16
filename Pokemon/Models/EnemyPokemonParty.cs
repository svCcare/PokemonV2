﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class EnemyPokemonParty : IPokemonParty<IPokemon>
    {
        public IList<IPokemon> Pokemons { get; set; }

        public EnemyPokemonParty()
        {
            Pokemons = new List<IPokemon>();
        }

        public IPokemon GetFirstAlivePokemon()
        {
            return Pokemons.First(p => p.HPCurrent > 0); 
        }

        public IPokemon GetPokemon()
        {
            throw new NotImplementedException();
        }
    }
}
