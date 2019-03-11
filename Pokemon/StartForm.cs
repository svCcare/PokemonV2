﻿using Pokemon.Factory;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class StartForm : Form
    {
        List<PictureBox> pictures = new List<PictureBox>();
        List<IPokemon> pokemonList = new List<IPokemon>();
        int teamSize = 1;
        public StartForm()
        {
            InitializeComponent();
            LoadPicturesToList();
            StartRandomizing(1);
        }

        private void StartRandomizing(int pokeNumber)
        {
            teamSize = pokeNumber;
            if (ValidateLevel())
            {
                foreach (PictureBox pictureBox in pictures)
                {
                    pictureBox.Image = null;
                }

                for (int i = 0; i < pokeNumber; i++)
                {
                    int level = Convert.ToInt32(tbLevel.Text);
                    IPokemon pokemon = PokemonFactory.CreatePokemon(level);
                    pokemonList[i] = pokemon;
                    pictures[i].Image = ImageHelper.GetImageById(false, pokemon.ID);
                }
            }
            else
            {
                MessageBox.Show("Please insert level of generated pokemon first");
            }

        }

        private void LoadPicturesToList()
        {
            pictures.Add(pictureBox1);
            pictures.Add(pictureBox2);
            pictures.Add(pictureBox3);
            pictures.Add(pictureBox4);
            pictures.Add(pictureBox5);
            pictures.Add(pictureBox6);
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            if (rbOnePoke.Checked) StartRandomizing(1);
            if (rbThreePoke.Checked) StartRandomizing(3);
            if (rbSixPoke.Checked) StartRandomizing(6);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pokemonList[0] != null)
            {
                if (ValidateLevel())
                {
                    BattleForm battleForm = new BattleForm(pokemonList, teamSize);
                    battleForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else
            {
                MessageBox.Show("Team not selected");
            }
        }

        private void tbLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbLevel_Validated(object sender, EventArgs e)
        {
            ValidateLevel();
        }

        private bool ValidateLevel()
        {
            if (Int32.TryParse(tbLevel.Text, out int level))
            {
                if (level > 100 || level <= 0)
                {
                    MessageBox.Show("Level must be higher than 0 or 100 and less");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Incorrect level format (Only numbers)");
                return false;
            }
            return true;
        }
    }
}
