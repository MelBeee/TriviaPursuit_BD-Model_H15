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
      public Menu()
      {
         InitializeComponent();
      }

      private void Menu_Load(object sender, EventArgs e)
      {

      }

      private void label1_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_StartGame.ForeColor = Color.Black;
      }

      private void label1_MouseLeave(object sender, EventArgs e)
      {
         BTN_StartGame.ForeColor = Color.White;
      }

      private void label1_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_StartGame.ForeColor = Color.Purple;
      }

      private void BTN_APropos_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_APropos.ForeColor = Color.Black;
         PB_APropos.Image = Properties.Resources.info_large_outline;
      }

      private void BTN_APropos_MouseLeave(object sender, EventArgs e)
      {
         BTN_APropos.ForeColor = Color.White;
         PB_APropos.Image = Properties.Resources.info_large;
      }

      private void BTN_APropos_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_APropos.ForeColor = Color.OrangeRed;
      }

      private void BTN_APropos_Click(object sender, EventArgs e)
      {
         APropos();
      }

      private void BTN_AddQuestion_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_AddQuestion.ForeColor = Color.DarkRed;
      }

      private void BTN_AddQuestion_MouseLeave(object sender, EventArgs e)
      {
         BTN_AddQuestion.ForeColor = Color.Black;
         PB_AddQuestion.Image = Properties.Resources.plus;
      }

      private void BTN_AddQuestion_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_AddQuestion.ForeColor = Color.White;
         PB_AddQuestion.Image = Properties.Resources.plus_outline;
      }

      private void BTN_QuitGame_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_QuitGame.ForeColor = Color.Yellow;
      }

      private void BTN_QuitGame_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_QuitGame.ForeColor = Color.White;
         PB_QuitGame.Image = Properties.Resources.export_outline;
      }

      private void BTN_QuitGame_MouseLeave(object sender, EventArgs e)
      {
         BTN_QuitGame.ForeColor = Color.Black;
         PB_QuitGame.Image = Properties.Resources.export;
      }

      private void BTN_Stats_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_Stats.ForeColor = Color.Green;
      }

      private void BTN_Stats_MouseLeave(object sender, EventArgs e)
      {
         BTN_Stats.ForeColor = Color.White;
         PB_Stats.Image = Properties.Resources.chart_line;
      }

      private void BTN_Stats_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_Stats.ForeColor = Color.Black;
         PB_Stats.Image = Properties.Resources.chart_line_outline;
      }

      private void BTN_DeleteQuestion_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_DeleteQuestion.ForeColor = Color.White;
         PB_DeleteQuestion.Image = Properties.Resources.minus_outline;
      }

      private void BTN_DeleteQuestion_MouseLeave(object sender, EventArgs e)
      {
         BTN_DeleteQuestion.ForeColor = Color.Black;
         PB_DeleteQuestion.Image = Properties.Resources.minus;
      }

      private void BTN_DeleteQuestion_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_DeleteQuestion.ForeColor = Color.FromArgb(0,115,200);
      }

      private void BTN_QuitGame_Click(object sender, EventArgs e)
      {
         Quitter();
      }

      private void BTN_AddQuestion_Click(object sender, EventArgs e)
      {
         AddQuestion();
      }

      private void BTN_StartGame_Click(object sender, EventArgs e)
      {
         StartGame();
      }

      private void BTN_DeleteQuestion_Click(object sender, EventArgs e)
      {
         DeleteQuestion();
      }

      private void BTN_Stats_Click(object sender, EventArgs e)
      {
         Stats();
      }

      private void PB_Logo_Click(object sender, EventArgs e)
      {
         var player = new System.Media.SoundPlayer();
         player.Stream = Properties.Resources.ChienQuiJappe;
         player.Play();
      }

      private void PB_AddQuestion_Click(object sender, EventArgs e)
      {
         AddQuestion();
      }

      private void PB_APropos_Click(object sender, EventArgs e)
      {
         APropos();
      }

      private void PB_QuitGame_Click(object sender, EventArgs e)
      {
         Quitter();
      }

      private void PB_Stats_Click(object sender, EventArgs e)
      {
         Stats();
      }

      private void PB_DeleteQuestion_Click(object sender, EventArgs e)
      {
         DeleteQuestion();
      }

      private void DeleteQuestion()
      {

      }

      private void AddQuestion()
      {
         FormAjoutQuestion form = new FormAjoutQuestion();

         if (form.ShowDialog() == DialogResult.Abort)
            this.Close();
      }

      private void StartGame()
      {

      }

      private void APropos()
      {
         FormAPropos form = new FormAPropos();

         form.Show();
      }

      private void Quitter()
      {
         this.Close();
      }

      private void Stats()
      {
         FormStatistiques form = new FormStatistiques();

         form.Show();
      }


      /*
         FormErreur form = new FormErreur();

         if(form.ShowDialog() == DialogResult.Abort)
         {
            this.Close();
         }
       */

   }
}
