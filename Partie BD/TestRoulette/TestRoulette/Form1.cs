using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRoulette
{
    public partial class Form1 : Form
    {
        Color CategorieJeuVideo = Color.FromArgb(255, 0, 0);
        Color CategorieCulinaire = Color.FromArgb(30, 180, 75);
        Color CategorieAnimaux = Color.FromArgb(0, 160, 255);
        Color CategorieMusique = Color.FromArgb(255, 255, 0);
        Color CategorieBlanc = Color.White;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            Random rd = new Random();

                number = rd.Next(1, 6);
                //System.Threading.Thread.Sleep(500);
                switch (number)
                {
                    case 1:
                        panel1.BackColor = CategorieJeuVideo;
                        break;
                    case 2:
                        panel1.BackColor = CategorieCulinaire;
                        break;
                    case 3:
                        panel1.BackColor = CategorieAnimaux;
                        break;
                    case 4:
                        panel1.BackColor = CategorieMusique;
                        break;
                    case 5:
                        panel1.BackColor = CategorieBlanc;
                        break;
                    default:
                        panel1.BackColor = CategorieBlanc;
                        break;
                }
            
        }
    }
}
