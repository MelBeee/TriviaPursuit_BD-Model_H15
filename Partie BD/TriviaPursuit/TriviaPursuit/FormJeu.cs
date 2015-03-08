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

// gainsboro / indigo

namespace TriviaPursuit
{
    public partial class FormJeu : Form
    {
        // variable contenant la connection a la bd 
        OracleConnection oraconn = new OracleConnection();
        string Joueur1;
        string Joueur2;
        string Joueur3;
        string Joueur4;

        public FormJeu(OracleConnection oraconnPrincipale, string J1 = "", string J2 = "", string J3 = "", string J4 = "")
        {
            Joueur1 = J1;
            Joueur2 = J2;
            Joueur3 = J3;
            Joueur4 = J4;
            InitializeComponent();
            oraconn = oraconnPrincipale;
        }

        private void BTN_Surrender_Click(object sender, EventArgs e)
        {

        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            LoadGroupBox();
        }

        private void LoadGroupBox()
        {
            GB_J1.Text = Joueur1;
            GB_J2.Text = Joueur2;

            if (Joueur3 != "")
            {
                GB_J3.Text = Joueur3;
            }
            else
            {
                GB_J3.Visible = false;
                GB_J3.Enabled = false;
            }
            if(Joueur4 != "")
            {
                GB_J4.Text = Joueur4;
            }
            else
            {
                GB_J4.Visible = false;
                GB_J4.Enabled = false;
            }
        }

        private void BTN_Rules_Click(object sender, EventArgs e)
        {
            FormReglements form = new FormReglements();

            form.Show();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////
        //    Gestion des erreurs 
        //////////////////////////////////////////////////////////////////////////////////////////////
        private void GestionErreur(OracleException ex)
        {
            FormErreur form = new FormErreur(ex);

            if (form.ShowDialog() == DialogResult.Abort)
            {
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
