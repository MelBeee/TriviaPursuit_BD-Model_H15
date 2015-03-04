namespace TriviaPursuit
{
    partial class FormGestionJoueurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionJoueurs));
         this.TB_NomJoueur = new System.Windows.Forms.TextBox();
         this.BTN_Annuler = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.BTN_Appliquer = new System.Windows.Forms.Button();
         this.CB_Joueurs = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // TB_NomJoueur
         // 
         this.TB_NomJoueur.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_NomJoueur.Location = new System.Drawing.Point(61, 20);
         this.TB_NomJoueur.Margin = new System.Windows.Forms.Padding(2);
         this.TB_NomJoueur.MaxLength = 20;
         this.TB_NomJoueur.Name = "TB_NomJoueur";
         this.TB_NomJoueur.Size = new System.Drawing.Size(121, 27);
         this.TB_NomJoueur.TabIndex = 0;
         this.TB_NomJoueur.TextChanged += new System.EventHandler(this.TB_NomJoueur_TextChanged);
         // 
         // BTN_Annuler
         // 
         this.BTN_Annuler.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Annuler.Location = new System.Drawing.Point(100, 66);
         this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(2);
         this.BTN_Annuler.Name = "BTN_Annuler";
         this.BTN_Annuler.Size = new System.Drawing.Size(71, 28);
         this.BTN_Annuler.TabIndex = 1;
         this.BTN_Annuler.Text = "Annuler";
         this.BTN_Annuler.UseVisualStyleBackColor = true;
         this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(11, 21);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(46, 22);
         this.label1.TabIndex = 2;
         this.label1.Text = "Nom :";
         // 
         // BTN_Appliquer
         // 
         this.BTN_Appliquer.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Appliquer.Location = new System.Drawing.Point(24, 66);
         this.BTN_Appliquer.Margin = new System.Windows.Forms.Padding(2);
         this.BTN_Appliquer.Name = "BTN_Appliquer";
         this.BTN_Appliquer.Size = new System.Drawing.Size(71, 28);
         this.BTN_Appliquer.TabIndex = 3;
         this.BTN_Appliquer.Text = "Appliquer";
         this.BTN_Appliquer.UseVisualStyleBackColor = true;
         this.BTN_Appliquer.Click += new System.EventHandler(this.BTN_Appliquer_Click);
         // 
         // CB_Joueurs
         // 
         this.CB_Joueurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.CB_Joueurs.Font = new System.Drawing.Font("Buxton Sketch", 12F);
         this.CB_Joueurs.FormattingEnabled = true;
         this.CB_Joueurs.Location = new System.Drawing.Point(61, 19);
         this.CB_Joueurs.Name = "CB_Joueurs";
         this.CB_Joueurs.Size = new System.Drawing.Size(121, 28);
         this.CB_Joueurs.TabIndex = 4;
         this.CB_Joueurs.SelectedIndexChanged += new System.EventHandler(this.CB_Joueurs_SelectedIndexChanged);
         // 
         // FormGestionJoueurs
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
         this.ClientSize = new System.Drawing.Size(194, 106);
         this.Controls.Add(this.CB_Joueurs);
         this.Controls.Add(this.BTN_Appliquer);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.BTN_Annuler);
         this.Controls.Add(this.TB_NomJoueur);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(2);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormGestionJoueurs";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Suppression de joueurs";
         this.Load += new System.EventHandler(this.FormGestionJoueurs_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_NomJoueur;
        private System.Windows.Forms.Button BTN_Annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Appliquer;
        private System.Windows.Forms.ComboBox CB_Joueurs;
    }
}