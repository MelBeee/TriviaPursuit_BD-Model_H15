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
         PB_APropos.Visible = true;  
      }

      private void BTN_APropos_MouseLeave(object sender, EventArgs e)
      {
         BTN_APropos.ForeColor = Color.White;
         PB_APropos.Visible = false; 
      }

      private void BTN_APropos_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_APropos.ForeColor = Color.OrangeRed;
      }

      private void BTN_APropos_Click(object sender, EventArgs e)
      {
         FormAPropos form = new FormAPropos();

         form.ShowDialog();
      }

      private void BTN_AddQuestion_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_AddQuestion.ForeColor = Color.DarkRed;
      }

      private void BTN_AddQuestion_MouseLeave(object sender, EventArgs e)
      {
         BTN_AddQuestion.ForeColor = Color.Black;
         PB_AddQuestion.Visible = false; 
      }

      private void BTN_AddQuestion_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_AddQuestion.ForeColor = Color.White;
         PB_AddQuestion.Visible = true;  
      }

      private void BTN_QuitGame_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_QuitGame.ForeColor = Color.Yellow;
      }

      private void BTN_QuitGame_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_QuitGame.ForeColor = Color.White;
         PB_QuitGame.Visible = true;  
      }

      private void BTN_QuitGame_MouseLeave(object sender, EventArgs e)
      {
         BTN_QuitGame.ForeColor = Color.Black;
         PB_QuitGame.Visible = false; 
      }

      private void BTN_Stats_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_Stats.ForeColor = Color.Green;
      }

      private void BTN_Stats_MouseLeave(object sender, EventArgs e)
      {
         BTN_Stats.ForeColor = Color.White;
         PB_Stats.Visible = false; 
      }

      private void BTN_Stats_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_Stats.ForeColor = Color.Black;
         PB_Stats.Visible = true; 
      }

      private void BTN_DeleteQuestion_MouseMove(object sender, MouseEventArgs e)
      {
         BTN_DeleteQuestion.ForeColor = Color.White;
         PB_DeleteQuestion.Visible = true;  
      }

      private void BTN_DeleteQuestion_MouseLeave(object sender, EventArgs e)
      {
         BTN_DeleteQuestion.ForeColor = Color.Black;
         PB_DeleteQuestion.Visible = false; 
      }

      private void BTN_DeleteQuestion_MouseDown(object sender, MouseEventArgs e)
      {
         BTN_DeleteQuestion.ForeColor = Color.FromArgb(0,115,200);
      }

      private void BTN_QuitGame_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void BTN_AddQuestion_Click(object sender, EventArgs e)
      {

      }

      private void BTN_StartGame_Click(object sender, EventArgs e)
      {

      }

      private void BTN_DeleteQuestion_Click(object sender, EventArgs e)
      {

      }

      private void BTN_Stats_Click(object sender, EventArgs e)
      {

      }

      private void PB_Logo_Click(object sender, EventArgs e)
      {
         System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"ChienQuiJappe.wav");
         player.Play();
      }
   }
}
