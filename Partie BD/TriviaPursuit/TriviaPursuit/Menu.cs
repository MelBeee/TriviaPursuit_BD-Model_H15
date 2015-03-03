using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TriviaPursuit
{
    public partial class Menu : Form
    {
        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Déclaration des variables
        //////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Form loading
        //////////////////////////////////////////////////////////////////////////////////////////////
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            Connexion();
        }
        private void Connexion()
        {
            try
            {

            }
            catch (Exception ex)
            {
                GestionErreur(ex);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Commencer une partie 
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void BTN_CommencerPartie_MouseDown(object sender, MouseEventArgs e)
        {
            BTN_StartGame.ForeColor = Color.Purple;
        }
        private void BTN_CommencerPartie_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_StartGame.ForeColor = Color.Black;
            Cursor.Current = Cursors.Hand;
        }
        private void BTN_CommencerPartie_MouseLeave(object sender, EventArgs e)
        {
            BTN_StartGame.ForeColor = Color.White;
            Cursor.Current = Cursors.Arrow;
        }
        private void BTN_StartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            FormSettingsGame form = new FormSettingsGame();

            if (form.ShowDialog() == DialogResult.Abort)
                this.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Gestion des questions (Ajouter)
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void BTN_AddQuestion_MouseDown(object sender, MouseEventArgs e)
        {
            BTN_AddQuestion.ForeColor = Color.DarkRed;
        }
        private void BTN_AddQuestion_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_AddQuestion.ForeColor = Color.White;
            PB_AddQuestion.Image = Properties.Resources.plus_outline;
            Cursor.Current = Cursors.Hand;
        }
        private void BTN_AddQuestion_MouseLeave(object sender, EventArgs e)
        {
            BTN_AddQuestion.ForeColor = Color.Black;
            PB_AddQuestion.Image = Properties.Resources.plus;
            Cursor.Current = Cursors.Arrow;
        }
        private void BTN_AddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }
        private void PB_AddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }
        private void AddQuestion()
        {
            FormAjoutQuestion form = new FormAjoutQuestion();

            if (form.ShowDialog() == DialogResult.Abort)
                this.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Gestion des questions (Supprimer)
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void BTN_DeleteQuestion_MouseDown(object sender, MouseEventArgs e)
        {
            BTN_DeleteQuestion.ForeColor = Color.DarkRed;
        }
        private void BTN_DeleteQuestion_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_DeleteQuestion.ForeColor = Color.White;
            PB_DeleteQuestion.Image = Properties.Resources.minus_outline;
            Cursor.Current = Cursors.Hand;
        }
        private void BTN_DeleteQuestion_MouseLeave(object sender, EventArgs e)
        {
            BTN_DeleteQuestion.ForeColor = Color.Black;
            PB_DeleteQuestion.Image = Properties.Resources.minus;
            Cursor.Current = Cursors.Arrow;
        }
        private void BTN_DeleteQuestion_Click(object sender, EventArgs e)
        {
            DeleteQuestion();
        }
        private void PB_DeleteQuestion_Click(object sender, EventArgs e)
        {
            DeleteQuestion();
        }
        private void DeleteQuestion()
        {
            FormSupressionQuestion form = new FormSupressionQuestion();

            if (form.ShowDialog() == DialogResult.Abort)
                this.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Afficher les statistiques
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void BTN_Stats_MouseDown(object sender, MouseEventArgs e)
        {
            BTN_Stats.ForeColor = Color.Green;
        }
        private void BTN_Stats_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_Stats.ForeColor = Color.Black;
            PB_Stats.Image = Properties.Resources.chart_line_outline;
            Cursor.Current = Cursors.Hand;
        }
        private void BTN_Stats_MouseLeave(object sender, EventArgs e)
        {
            BTN_Stats.ForeColor = Color.White;
            PB_Stats.Image = Properties.Resources.chart_line;
            Cursor.Current = Cursors.Arrow;
        }
        private void BTN_Stats_Click(object sender, EventArgs e)
        {
            Stats();
        }
        private void PB_Stats_Click(object sender, EventArgs e)
        {
            Stats();
        }
        private void Stats()
        {
            FormStatistiques form = new FormStatistiques();

            if (form.ShowDialog() == DialogResult.Abort)
                this.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Quitter le jeu 
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void BTN_QuitGame_MouseDown(object sender, MouseEventArgs e)
        {
            BTN_QuitGame.ForeColor = Color.Yellow;
        }
        private void BTN_QuitGame_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_QuitGame.ForeColor = Color.White;
            PB_QuitGame.Image = Properties.Resources.export_outline;
            Cursor.Current = Cursors.Hand;
        }
        private void BTN_QuitGame_MouseLeave(object sender, EventArgs e)
        {
            BTN_QuitGame.ForeColor = Color.Black;
            PB_QuitGame.Image = Properties.Resources.export;
            Cursor.Current = Cursors.Arrow;
        }
        private void BTN_QuitGame_Click(object sender, EventArgs e)
        {
            Quitter();
        }
        private void PB_QuitGame_Click(object sender, EventArgs e)
        {
            Quitter();
        }
        private void Quitter()
        {
            this.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Afficher les informations A Propos 
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void BTN_APropos_MouseDown(object sender, MouseEventArgs e)
        {
            BTN_APropos.ForeColor = Color.OrangeRed;
        }
        private void BTN_APropos_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_APropos.ForeColor = Color.Black;
            PB_APropos.Image = Properties.Resources.info_large_outline;
            Cursor.Current = Cursors.Hand;
        }
        private void BTN_APropos_MouseLeave(object sender, EventArgs e)
        {
            BTN_APropos.ForeColor = Color.White;
            PB_APropos.Image = Properties.Resources.info_large;
            Cursor.Current = Cursors.Arrow;
        }
        private void BTN_APropos_Click(object sender, EventArgs e)
        {
            APropos();
        }
        private void PB_APropos_Click(object sender, EventArgs e)
        {
            APropos();
        }
        private void APropos()
        {
            FormAPropos form = new FormAPropos();

            form.Show();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Gestion Joueurs (Ajouter)
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void LB_AddPlayers_MouseDown(object sender, MouseEventArgs e)
        {
            LB_AddPlayers.ForeColor = Color.FromArgb(0, 115, 200);
        }
        private void LB_AddPlayers_MouseLeave(object sender, EventArgs e)
        {
            LB_AddPlayers.ForeColor = Color.Black;
            PB_AddPlayers.Image = Properties.Resources.plus;
            Cursor.Current = Cursors.Arrow;
        }
        private void LB_AddPlayers_MouseMove(object sender, MouseEventArgs e)
        {
            LB_AddPlayers.ForeColor = Color.White;
            PB_AddPlayers.Image = Properties.Resources.plus_outline;
            Cursor.Current = Cursors.Hand;
        }
        private void LB_AddPlayers_Click(object sender, EventArgs e)
        {
            AddPlayers();
        }
        private void PB_AddPlayers_Click(object sender, EventArgs e)
        {
            AddPlayers();
        }
        private void AddPlayers()
        {
            FormGestionJoueurs form = new FormGestionJoueurs();

            form.Text = "Ajout de joueurs";

            if (form.ShowDialog() == DialogResult.Abort)
                this.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Gestion Joueurs (Supprimer)
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void LB_DeletePlayers_MouseDown(object sender, MouseEventArgs e)
        {
            LB_DeletePlayers.ForeColor = Color.FromArgb(0, 115, 200);
        }
        private void LB_DeletePlayers_MouseLeave(object sender, EventArgs e)
        {
            LB_DeletePlayers.ForeColor = Color.Black;
            PB_DeletePlayers.Image = Properties.Resources.minus;
            Cursor.Current = Cursors.Arrow;
        }
        private void LB_DeletePlayers_MouseMove(object sender, MouseEventArgs e)
        {
            LB_DeletePlayers.ForeColor = Color.White;
            PB_DeletePlayers.Image = Properties.Resources.minus_outline;
            Cursor.Current = Cursors.Hand;
        }
        private void PB_DeletePlayers_Click(object sender, EventArgs e)
        {
            DeletePlayers();
        }
        private void LB_DeletePlayers_Click(object sender, EventArgs e)
        {
            DeletePlayers();
        }
        private void DeletePlayers()
        {
            FormGestionJoueurs form = new FormGestionJoueurs();

            form.Text = "Suppression de joueurs";

            if (form.ShowDialog() == DialogResult.Abort)
                this.Close();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Gestion des erreurs 
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void GestionErreur(Exception ex)
        {
            FormErreur form = new FormErreur();

            if (form.ShowDialog() == DialogResult.Abort)
            {
                this.Close();
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Easter Egg (Logo qui jappe)
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void PB_Logo_Click(object sender, EventArgs e)
        {
            var player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.ChienQuiJappe;
            player.Play();
        }
        private void PB_Logo_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Arrow;
        }
        private void PB_Logo_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

    }
}
