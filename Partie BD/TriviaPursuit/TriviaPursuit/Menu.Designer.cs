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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label6 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(176, 59);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(110, 58);
         this.label1.TabIndex = 0;
         this.label1.Text = "Commencer\r\nune partie";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.label1.Click += new System.EventHandler(this.label1_Click);
         this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
         this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
         this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Black;
         this.label2.Location = new System.Drawing.Point(193, 337);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(76, 58);
         this.label2.TabIndex = 1;
         this.label2.Text = "Quitter\r\nle jeu";
         this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.Transparent;
         this.label3.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Black;
         this.label3.Location = new System.Drawing.Point(312, 124);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(135, 58);
         this.label3.TabIndex = 2;
         this.label3.Text = "Ajouter\r\ndes questions";
         this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.White;
         this.label4.Location = new System.Drawing.Point(333, 278);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(93, 29);
         this.label4.TabIndex = 3;
         this.label4.Text = "À Propos";
         this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.Transparent;
         this.label5.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.White;
         this.label5.Location = new System.Drawing.Point(24, 277);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(122, 29);
         this.label5.TabIndex = 4;
         this.label5.Text = "Statistiques";
         this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.Image = global::TriviaPursuit.Properties.Resources.LogoTrivial_Diamond;
         this.pictureBox1.Location = new System.Drawing.Point(170, 182);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(122, 91);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 5;
         this.pictureBox1.TabStop = false;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.BackColor = System.Drawing.Color.Transparent;
         this.label6.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.Black;
         this.label6.Location = new System.Drawing.Point(18, 124);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(135, 58);
         this.label6.TabIndex = 6;
         this.label6.Text = "Supprimer\r\ndes questions";
         this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = global::TriviaPursuit.Properties.Resources.BackGroundMenu;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(462, 462);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Menu";
         this.Text = "Trivial Diamond";
         this.Load += new System.EventHandler(this.Menu_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label6;
   }
}

