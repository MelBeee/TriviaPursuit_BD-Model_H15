using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TriviaPursuit
{
    public partial class FormGestionJoueurs : Form
    {
       // variable contenant la connection a la bd 
       OracleConnection oraconn = new OracleConnection();

       public FormGestionJoueurs(OracleConnection oraconnPrincipale)
        {
            InitializeComponent();
            oraconn = oraconnPrincipale;
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGestionJoueurs_Load(object sender, EventArgs e)
        {
           
        }
    }
}
