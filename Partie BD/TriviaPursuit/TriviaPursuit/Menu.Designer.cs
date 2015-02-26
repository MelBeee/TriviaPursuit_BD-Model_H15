namespace TriviaPursuit
{
   partial class Menu
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
         this.BTN_StartGame = new System.Windows.Forms.Label();
         this.BTN_QuitGame = new System.Windows.Forms.Label();
         this.BTN_AddQuestion = new System.Windows.Forms.Label();
         this.BTN_APropos = new System.Windows.Forms.Label();
         this.BTN_Stats = new System.Windows.Forms.Label();
         this.PB_Logo = new System.Windows.Forms.PictureBox();
         this.BTN_DeleteQuestion = new System.Windows.Forms.Label();
         this.PB_AddQuestion = new System.Windows.Forms.PictureBox();
         this.PB_Stats = new System.Windows.Forms.PictureBox();
         this.PB_QuitGame = new System.Windows.Forms.PictureBox();
         this.PB_APropos = new System.Windows.Forms.PictureBox();
         this.PB_DeleteQuestion = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_AddQuestion)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Stats)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_QuitGame)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_APropos)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_DeleteQuestion)).BeginInit();
         this.SuspendLayout();
         // 
         // BTN_StartGame
         // 
         this.BTN_StartGame.AutoSize = true;
         this.BTN_StartGame.BackColor = System.Drawing.Color.Transparent;
         this.BTN_StartGame.Font = new System.Drawing.Font("Buxton Sketch", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_StartGame.ForeColor = System.Drawing.Color.White;
         this.BTN_StartGame.Location = new System.Drawing.Point(160, 37);
         this.BTN_StartGame.Name = "BTN_StartGame";
         this.BTN_StartGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.BTN_StartGame.Size = new System.Drawing.Size(144, 78);
         this.BTN_StartGame.TabIndex = 0;
         this.BTN_StartGame.Text = "Commencer\r\nune partie";
         this.BTN_StartGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.BTN_StartGame.Click += new System.EventHandler(this.BTN_StartGame_Click);
         this.BTN_StartGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_CommencerPartie_MouseDown);
         this.BTN_StartGame.MouseLeave += new System.EventHandler(this.BTN_CommencerPartie_MouseLeave);
         this.BTN_StartGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_CommencerPartie_MouseMove);
         // 
         // BTN_QuitGame
         // 
         this.BTN_QuitGame.AutoSize = true;
         this.BTN_QuitGame.BackColor = System.Drawing.Color.Transparent;
         this.BTN_QuitGame.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_QuitGame.ForeColor = System.Drawing.Color.Black;
         this.BTN_QuitGame.Location = new System.Drawing.Point(194, 360);
         this.BTN_QuitGame.Name = "BTN_QuitGame";
         this.BTN_QuitGame.Size = new System.Drawing.Size(76, 58);
         this.BTN_QuitGame.TabIndex = 1;
         this.BTN_QuitGame.Text = "Quitter\r\nle jeu";
         this.BTN_QuitGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.BTN_QuitGame.Click += new System.EventHandler(this.BTN_QuitGame_Click);
         this.BTN_QuitGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_QuitGame_MouseDown);
         this.BTN_QuitGame.MouseLeave += new System.EventHandler(this.BTN_QuitGame_MouseLeave);
         this.BTN_QuitGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_QuitGame_MouseMove);
         // 
         // BTN_AddQuestion
         // 
         this.BTN_AddQuestion.AutoSize = true;
         this.BTN_AddQuestion.BackColor = System.Drawing.Color.Transparent;
         this.BTN_AddQuestion.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_AddQuestion.ForeColor = System.Drawing.Color.Black;
         this.BTN_AddQuestion.Location = new System.Drawing.Point(315, 93);
         this.BTN_AddQuestion.Name = "BTN_AddQuestion";
         this.BTN_AddQuestion.Size = new System.Drawing.Size(135, 58);
         this.BTN_AddQuestion.TabIndex = 2;
         this.BTN_AddQuestion.Text = "Ajouter\r\ndes questions";
         this.BTN_AddQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.BTN_AddQuestion.Click += new System.EventHandler(this.BTN_AddQuestion_Click);
         this.BTN_AddQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_AddQuestion_MouseDown);
         this.BTN_AddQuestion.MouseLeave += new System.EventHandler(this.BTN_AddQuestion_MouseLeave);
         this.BTN_AddQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_AddQuestion_MouseMove);
         // 
         // BTN_APropos
         // 
         this.BTN_APropos.AutoSize = true;
         this.BTN_APropos.BackColor = System.Drawing.Color.Transparent;
         this.BTN_APropos.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_APropos.ForeColor = System.Drawing.Color.White;
         this.BTN_APropos.Location = new System.Drawing.Point(334, 315);
         this.BTN_APropos.Name = "BTN_APropos";
         this.BTN_APropos.Size = new System.Drawing.Size(93, 29);
         this.BTN_APropos.TabIndex = 3;
         this.BTN_APropos.Text = "À Propos";
         this.BTN_APropos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.BTN_APropos.Click += new System.EventHandler(this.BTN_APropos_Click);
         this.BTN_APropos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_APropos_MouseDown);
         this.BTN_APropos.MouseLeave += new System.EventHandler(this.BTN_APropos_MouseLeave);
         this.BTN_APropos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_APropos_MouseMove);
         // 
         // BTN_Stats
         // 
         this.BTN_Stats.AutoSize = true;
         this.BTN_Stats.BackColor = System.Drawing.Color.Transparent;
         this.BTN_Stats.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Stats.ForeColor = System.Drawing.Color.White;
         this.BTN_Stats.Location = new System.Drawing.Point(22, 315);
         this.BTN_Stats.Name = "BTN_Stats";
         this.BTN_Stats.Size = new System.Drawing.Size(122, 29);
         this.BTN_Stats.TabIndex = 4;
         this.BTN_Stats.Text = "Statistiques";
         this.BTN_Stats.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.BTN_Stats.Click += new System.EventHandler(this.BTN_Stats_Click);
         this.BTN_Stats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_Stats_MouseDown);
         this.BTN_Stats.MouseLeave += new System.EventHandler(this.BTN_Stats_MouseLeave);
         this.BTN_Stats.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_Stats_MouseMove);
         // 
         // PB_Logo
         // 
         this.PB_Logo.BackColor = System.Drawing.Color.Transparent;
         this.PB_Logo.Image = global::TriviaPursuit.Properties.Resources.LogoTrivial_Diamond;
         this.PB_Logo.Location = new System.Drawing.Point(171, 182);
         this.PB_Logo.Name = "PB_Logo";
         this.PB_Logo.Size = new System.Drawing.Size(122, 91);
         this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_Logo.TabIndex = 5;
         this.PB_Logo.TabStop = false;
         this.PB_Logo.Click += new System.EventHandler(this.PB_Logo_Click);
         // 
         // BTN_DeleteQuestion
         // 
         this.BTN_DeleteQuestion.AutoSize = true;
         this.BTN_DeleteQuestion.BackColor = System.Drawing.Color.Transparent;
         this.BTN_DeleteQuestion.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_DeleteQuestion.ForeColor = System.Drawing.Color.Black;
         this.BTN_DeleteQuestion.Location = new System.Drawing.Point(16, 96);
         this.BTN_DeleteQuestion.Name = "BTN_DeleteQuestion";
         this.BTN_DeleteQuestion.Size = new System.Drawing.Size(135, 58);
         this.BTN_DeleteQuestion.TabIndex = 6;
         this.BTN_DeleteQuestion.Text = "Supprimer\r\ndes questions";
         this.BTN_DeleteQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.BTN_DeleteQuestion.Click += new System.EventHandler(this.BTN_DeleteQuestion_Click);
         this.BTN_DeleteQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_DeleteQuestion_MouseDown);
         this.BTN_DeleteQuestion.MouseLeave += new System.EventHandler(this.BTN_DeleteQuestion_MouseLeave);
         this.BTN_DeleteQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_DeleteQuestion_MouseMove);
         // 
         // PB_AddQuestion
         // 
         this.PB_AddQuestion.BackColor = System.Drawing.Color.Transparent;
         this.PB_AddQuestion.Image = global::TriviaPursuit.Properties.Resources.plus;
         this.PB_AddQuestion.Location = new System.Drawing.Point(351, 154);
         this.PB_AddQuestion.Name = "PB_AddQuestion";
         this.PB_AddQuestion.Size = new System.Drawing.Size(62, 58);
         this.PB_AddQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_AddQuestion.TabIndex = 7;
         this.PB_AddQuestion.TabStop = false;
         this.PB_AddQuestion.Click += new System.EventHandler(this.PB_AddQuestion_Click);
         this.PB_AddQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_AddQuestion_MouseDown);
         this.PB_AddQuestion.MouseLeave += new System.EventHandler(this.BTN_AddQuestion_MouseLeave);
         this.PB_AddQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_AddQuestion_MouseMove);
         // 
         // PB_Stats
         // 
         this.PB_Stats.BackColor = System.Drawing.Color.Transparent;
         this.PB_Stats.Image = global::TriviaPursuit.Properties.Resources.chart_line;
         this.PB_Stats.Location = new System.Drawing.Point(52, 252);
         this.PB_Stats.Name = "PB_Stats";
         this.PB_Stats.Size = new System.Drawing.Size(63, 58);
         this.PB_Stats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_Stats.TabIndex = 10;
         this.PB_Stats.TabStop = false;
         this.PB_Stats.Click += new System.EventHandler(this.PB_Stats_Click);
         this.PB_Stats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_Stats_MouseDown);
         this.PB_Stats.MouseLeave += new System.EventHandler(this.BTN_Stats_MouseLeave);
         this.PB_Stats.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_Stats_MouseMove);
         // 
         // PB_QuitGame
         // 
         this.PB_QuitGame.BackColor = System.Drawing.Color.Transparent;
         this.PB_QuitGame.Image = global::TriviaPursuit.Properties.Resources.export;
         this.PB_QuitGame.Location = new System.Drawing.Point(201, 295);
         this.PB_QuitGame.Name = "PB_QuitGame";
         this.PB_QuitGame.Size = new System.Drawing.Size(63, 58);
         this.PB_QuitGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_QuitGame.TabIndex = 9;
         this.PB_QuitGame.TabStop = false;
         this.PB_QuitGame.Click += new System.EventHandler(this.PB_QuitGame_Click);
         this.PB_QuitGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_QuitGame_MouseDown);
         this.PB_QuitGame.MouseLeave += new System.EventHandler(this.BTN_QuitGame_MouseLeave);
         this.PB_QuitGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_QuitGame_MouseMove);
         // 
         // PB_APropos
         // 
         this.PB_APropos.BackColor = System.Drawing.Color.Transparent;
         this.PB_APropos.Image = global::TriviaPursuit.Properties.Resources.info_large;
         this.PB_APropos.Location = new System.Drawing.Point(351, 252);
         this.PB_APropos.Name = "PB_APropos";
         this.PB_APropos.Size = new System.Drawing.Size(62, 58);
         this.PB_APropos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_APropos.TabIndex = 8;
         this.PB_APropos.TabStop = false;
         this.PB_APropos.Click += new System.EventHandler(this.PB_APropos_Click);
         this.PB_APropos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_APropos_MouseDown);
         this.PB_APropos.MouseLeave += new System.EventHandler(this.BTN_APropos_MouseLeave);
         this.PB_APropos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_APropos_MouseMove);
         // 
         // PB_DeleteQuestion
         // 
         this.PB_DeleteQuestion.BackColor = System.Drawing.Color.Transparent;
         this.PB_DeleteQuestion.Image = global::TriviaPursuit.Properties.Resources.minus;
         this.PB_DeleteQuestion.Location = new System.Drawing.Point(52, 154);
         this.PB_DeleteQuestion.Name = "PB_DeleteQuestion";
         this.PB_DeleteQuestion.Size = new System.Drawing.Size(63, 58);
         this.PB_DeleteQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.PB_DeleteQuestion.TabIndex = 11;
         this.PB_DeleteQuestion.TabStop = false;
         this.PB_DeleteQuestion.Click += new System.EventHandler(this.PB_DeleteQuestion_Click);
         this.PB_DeleteQuestion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BTN_DeleteQuestion_MouseDown);
         this.PB_DeleteQuestion.MouseLeave += new System.EventHandler(this.BTN_DeleteQuestion_MouseLeave);
         this.PB_DeleteQuestion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BTN_DeleteQuestion_MouseMove);
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::TriviaPursuit.Properties.Resources.BackGroundMenu;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(462, 462);
         this.Controls.Add(this.PB_DeleteQuestion);
         this.Controls.Add(this.PB_Stats);
         this.Controls.Add(this.PB_QuitGame);
         this.Controls.Add(this.PB_APropos);
         this.Controls.Add(this.PB_AddQuestion);
         this.Controls.Add(this.BTN_DeleteQuestion);
         this.Controls.Add(this.PB_Logo);
         this.Controls.Add(this.BTN_Stats);
         this.Controls.Add(this.BTN_APropos);
         this.Controls.Add(this.BTN_AddQuestion);
         this.Controls.Add(this.BTN_QuitGame);
         this.Controls.Add(this.BTN_StartGame);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Menu";
         this.Text = "Trivial Diamond";
         this.Load += new System.EventHandler(this.Menu_Load);
         ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_AddQuestion)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_Stats)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_QuitGame)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_APropos)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.PB_DeleteQuestion)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label BTN_StartGame;
      private System.Windows.Forms.Label BTN_QuitGame;
      private System.Windows.Forms.Label BTN_AddQuestion;
      private System.Windows.Forms.Label BTN_APropos;
      private System.Windows.Forms.Label BTN_Stats;
      private System.Windows.Forms.PictureBox PB_Logo;
      private System.Windows.Forms.Label BTN_DeleteQuestion;
      private System.Windows.Forms.PictureBox PB_AddQuestion;
      private System.Windows.Forms.PictureBox PB_Stats;
      private System.Windows.Forms.PictureBox PB_QuitGame;
      private System.Windows.Forms.PictureBox PB_APropos;
      private System.Windows.Forms.PictureBox PB_DeleteQuestion;
   }
}

