﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaPursuit
{
   public partial class FormJeu : Form
   {
      public FormJeu()
      {
         InitializeComponent();
      }

      private void BTN_Surrender_Click(object sender, EventArgs e)
      {

      }

      private void FormJeu_Load(object sender, EventArgs e)
      {

      }

      private void BTN_Rules_Click(object sender, EventArgs e)
      {
          FormReglements form = new FormReglements();

          form.Show();
      }
   }
}
