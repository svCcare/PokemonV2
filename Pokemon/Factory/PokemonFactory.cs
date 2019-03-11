﻿using Pokemon.Factory;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Factory
{
    public static class PokemonFactory
    {
        public static IPokemon CreatePokemon()
        {
            return new Pokemon();
        }

        public static IPokemon CreatePokemon(int level, int id = 0)
        {
            IPokemon pokemon = new Pokemon();
            pokemon.Level = level;

            if (id > 0)
            {
                // obtaining the one specific pokemon
                pokemon = PokemonList.Pokemons.Where(p => p.Key == id).FirstOrDefault().Value;
            }
            else
            {
                // filtering the overall list of pokemons by level, we don't want lvl 5 charizard
                var availablePokemons = PokemonList.Pokemons.Where(p => p.Value.MinimalLevel <= level);
                // selecting random entry from filtred list
                pokemon = availablePokemons
                            .ElementAt(GenerateRandomNumber.GetRandomNumber(0, availablePokemons.Count()))
                            .Value;
            }

            pokemon.Stats = PokemonStatsFactory.CreateStats(level, pokemon.Stats);
            pokemon.Attacks = PokemonAttacksFactory.GetAttacks(pokemon);

            return pokemon;
        } 
    }
}