using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;


namespace TradingCardApp
{
    public partial class Form1 : Form
    {
        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            LoadPlayers(); // Initialize the players list
            BindPlayerList(); // Bind the list to the ListBox
        }

        // DISPLAY the players data
        private void LoadPlayers()
        {
            players = new List<Player>
            {
                new Player { Name = "Mohamed Salah", Team = "Liverpool", Photo = "Images/Salah.jpg", Goals = 11, Assists = 7, Appearances = 51, Age = 32 },
                new Player { Name = "Frederico Chiesa", Team = "Liverpool", Photo = "Images/Chiesa.jpg", Goals = 1, Assists = 0, Appearances = 1, Age = 28 },
                new Player { Name = "Luis Diaz", Team = "Liverpool", Photo = "Images/Diaz.jpg", Goals = 5, Assists = 2, Appearances = 51, Age = 27 },
                new Player { Name = "Sergio Busquets", Team = "Inter Miami", Photo = "Images/Busquets.jpg", Goals = 1, Assists = 4, Appearances = 54, Age = 36 },
                new Player { Name = "Lionel Messi", Team = "Inter Miami", Photo = "Images/Messi.jpg", Goals = 6, Assists = 3, Appearances = 9, Age = 37 },
                new Player { Name = "Bradley Barcola", Team = "Inter Miami", Photo = "Images/Barcola.jpg", Goals = 10, Assists = 2, Appearances = 37, Age = 22 },
                new Player { Name = "Diogo Dalot", Team = "Man United", Photo = "Images/Dalot.jpg", Goals = 1, Assists = 1, Appearances = 13, Age = 25 },
                new Player { Name = "Amad Diallo", Team = "Man United", Photo = "Images/Diallo.jpg", Goals = 1, Assists = 5, Appearances = 11, Age = 22 },
                new Player { Name = "Jonny Evans", Team = "Man United", Photo = "Images/Evans.jpg", Goals = 0, Assists = 0, Appearances = 6, Age = 36 },
                new Player { Name = "Marcus Rashford", Team = "Man United", Photo = "Images/Rashford.jpg", Goals = 4, Assists = 1, Appearances = 13, Age = 27 },
            };
        }

        // BIND the player names to the ListBoxplayers
        private void BindPlayerList()
        {
            listBoxPlayers.DataSource = players.Select(p => p.Name).ToList();
        }

        // Event handler for ListBox selection
        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RETRIEVE the selected player's name
            var selectedName = listBoxPlayers.SelectedItem?.ToString();
            var selectedPlayer = players.FirstOrDefault(p => p.Name == selectedName);

            if (selectedPlayer != null)
            {
                //UPDATES  UI with the selected player's details
                labelName.Text = selectedPlayer.Name;
                labelTeam.Text = selectedPlayer.Team;
                pictureBox1.Image = Image.FromFile(selectedPlayer.Photo);
                labelGoals.Text = $"Goals: {selectedPlayer.Goals}";
                labelAssists.Text = $"Assists: {selectedPlayer.Assists}";
                labelAppearances.Text = $"Appearances: {selectedPlayer.Appearances}";
                labelAge.Text = $"Age: {selectedPlayer.Age}";
            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(200, 200);

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}



   