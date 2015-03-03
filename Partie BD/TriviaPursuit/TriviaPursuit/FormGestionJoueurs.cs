using System;
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
    public partial class FormGestionJoueurs : Form
    {
        public FormGestionJoueurs()
        {
            InitializeComponent();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
