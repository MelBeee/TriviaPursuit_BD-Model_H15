namespace TriviaPursuit
{
   partial class FormSupressionQuestion
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupressionQuestion));
         this.BTN_Annuler = new System.Windows.Forms.Button();
         this.CB_CATEGORIE = new System.Windows.Forms.ComboBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.BTN_PRECEDENT = new System.Windows.Forms.Button();
         this.LB_REPONSE = new System.Windows.Forms.Label();
         this.BTN_SUIVANT = new System.Windows.Forms.Button();
         this.LB_QUESTION = new System.Windows.Forms.Label();
         this.LB_CHOIX1 = new System.Windows.Forms.Label();
         this.LB_ID = new System.Windows.Forms.Label();
         this.LB_CHOIX2 = new System.Windows.Forms.Label();
         this.LB_CHOIX3 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.BTN_Supprimer = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // BTN_Annuler
         // 
         this.BTN_Annuler.Font = new System.Drawing.Font("Buxton Sketch", 13F);
         this.BTN_Annuler.Location = new System.Drawing.Point(158, 274);
         this.BTN_Annuler.Name = "BTN_Annuler";
         this.BTN_Annuler.Size = new System.Drawing.Size(89, 31);
         this.BTN_Annuler.TabIndex = 26;
         this.BTN_Annuler.Text = "Annuler";
         this.BTN_Annuler.UseVisualStyleBackColor = true;
         this.BTN_Annuler.Click += new System.EventHandler(this.button1_Click);
         // 
         // CB_CATEGORIE
         // 
         this.CB_CATEGORIE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.CB_CATEGORIE.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.CB_CATEGORIE.FormattingEnabled = true;
         this.CB_CATEGORIE.Items.AddRange(new object[] {
            "Jeu vidéo",
            "Culinaire",
            "Animaux",
            "Musique"});
         this.CB_CATEGORIE.Location = new System.Drawing.Point(114, 10);
         this.CB_CATEGORIE.Name = "CB_CATEGORIE";
         this.CB_CATEGORIE.Size = new System.Drawing.Size(159, 28);
         this.CB_CATEGORIE.TabIndex = 25;
         this.CB_CATEGORIE.SelectedIndexChanged += new System.EventHandler(this.CB_CATEGORIE_SelectedIndexChanged);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(24, 13);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(84, 23);
         this.label6.TabIndex = 24;
         this.label6.Text = "Catégorie :";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(6, 40);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(70, 20);
         this.label1.TabIndex = 19;
         this.label1.Text = "Question :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(47, 18);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(29, 20);
         this.label2.TabIndex = 28;
         this.label2.Text = "ID :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(18, 133);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(58, 20);
         this.label3.TabIndex = 30;
         this.label3.Text = "Choix 2 :";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(17, 157);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(59, 20);
         this.label4.TabIndex = 29;
         this.label4.Text = "Choix 3 :";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(10, 84);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(66, 20);
         this.label5.TabIndex = 32;
         this.label5.Text = "Réponse :";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.BTN_PRECEDENT);
         this.groupBox1.Controls.Add(this.LB_REPONSE);
         this.groupBox1.Controls.Add(this.BTN_SUIVANT);
         this.groupBox1.Controls.Add(this.LB_QUESTION);
         this.groupBox1.Controls.Add(this.LB_CHOIX1);
         this.groupBox1.Controls.Add(this.LB_ID);
         this.groupBox1.Controls.Add(this.LB_CHOIX2);
         this.groupBox1.Controls.Add(this.LB_CHOIX3);
         this.groupBox1.Controls.Add(this.label5);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.label7);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.Location = new System.Drawing.Point(12, 45);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(287, 217);
         this.groupBox1.TabIndex = 33;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "11 résultats";
         // 
         // BTN_PRECEDENT
         // 
         this.BTN_PRECEDENT.Font = new System.Drawing.Font("Buxton Sketch", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_PRECEDENT.Location = new System.Drawing.Point(107, 186);
         this.BTN_PRECEDENT.Name = "BTN_PRECEDENT";
         this.BTN_PRECEDENT.Size = new System.Drawing.Size(33, 23);
         this.BTN_PRECEDENT.TabIndex = 36;
         this.BTN_PRECEDENT.Text = "<<";
         this.BTN_PRECEDENT.UseVisualStyleBackColor = true;
         this.BTN_PRECEDENT.Click += new System.EventHandler(this.BTN_PRECEDENT_Click);
         // 
         // LB_REPONSE
         // 
         this.LB_REPONSE.AutoSize = true;
         this.LB_REPONSE.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_REPONSE.Location = new System.Drawing.Point(77, 84);
         this.LB_REPONSE.Name = "LB_REPONSE";
         this.LB_REPONSE.Size = new System.Drawing.Size(63, 20);
         this.LB_REPONSE.TabIndex = 38;
         this.LB_REPONSE.Text = "La poule !";
         // 
         // BTN_SUIVANT
         // 
         this.BTN_SUIVANT.Font = new System.Drawing.Font("Buxton Sketch", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_SUIVANT.Location = new System.Drawing.Point(146, 186);
         this.BTN_SUIVANT.Name = "BTN_SUIVANT";
         this.BTN_SUIVANT.Size = new System.Drawing.Size(33, 23);
         this.BTN_SUIVANT.TabIndex = 35;
         this.BTN_SUIVANT.Text = ">>";
         this.BTN_SUIVANT.UseVisualStyleBackColor = true;
         this.BTN_SUIVANT.Click += new System.EventHandler(this.BTN_SUIVANT_Click);
         // 
         // LB_QUESTION
         // 
         this.LB_QUESTION.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_QUESTION.Location = new System.Drawing.Point(77, 41);
         this.LB_QUESTION.Name = "LB_QUESTION";
         this.LB_QUESTION.Size = new System.Drawing.Size(204, 44);
         this.LB_QUESTION.TabIndex = 33;
         this.LB_QUESTION.Text = "Poule ou l\'oeuf en premier  ? ";
         // 
         // LB_CHOIX1
         // 
         this.LB_CHOIX1.AutoSize = true;
         this.LB_CHOIX1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_CHOIX1.Location = new System.Drawing.Point(77, 108);
         this.LB_CHOIX1.Name = "LB_CHOIX1";
         this.LB_CHOIX1.Size = new System.Drawing.Size(50, 20);
         this.LB_CHOIX1.TabIndex = 37;
         this.LB_CHOIX1.Text = "L\'oeuf !";
         // 
         // LB_ID
         // 
         this.LB_ID.AutoSize = true;
         this.LB_ID.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_ID.Location = new System.Drawing.Point(77, 18);
         this.LB_ID.Name = "LB_ID";
         this.LB_ID.Size = new System.Drawing.Size(29, 20);
         this.LB_ID.TabIndex = 34;
         this.LB_ID.Text = "102";
         // 
         // LB_CHOIX2
         // 
         this.LB_CHOIX2.AutoSize = true;
         this.LB_CHOIX2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_CHOIX2.Location = new System.Drawing.Point(77, 133);
         this.LB_CHOIX2.Name = "LB_CHOIX2";
         this.LB_CHOIX2.Size = new System.Drawing.Size(104, 20);
         this.LB_CHOIX2.TabIndex = 36;
         this.LB_CHOIX2.Text = "Aucun réponse ! ";
         // 
         // LB_CHOIX3
         // 
         this.LB_CHOIX3.AutoSize = true;
         this.LB_CHOIX3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_CHOIX3.Location = new System.Drawing.Point(77, 157);
         this.LB_CHOIX3.Name = "LB_CHOIX3";
         this.LB_CHOIX3.Size = new System.Drawing.Size(116, 20);
         this.LB_CHOIX3.TabIndex = 35;
         this.LB_CHOIX3.Text = "Mystère de la vie ! ";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(22, 108);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(54, 20);
         this.label7.TabIndex = 31;
         this.label7.Text = "Choix 1 :";
         // 
         // BTN_Supprimer
         // 
         this.BTN_Supprimer.Font = new System.Drawing.Font("Buxton Sketch", 13F);
         this.BTN_Supprimer.Location = new System.Drawing.Point(63, 274);
         this.BTN_Supprimer.Name = "BTN_Supprimer";
         this.BTN_Supprimer.Size = new System.Drawing.Size(89, 31);
         this.BTN_Supprimer.TabIndex = 27;
         this.BTN_Supprimer.Text = "Supprimer";
         this.BTN_Supprimer.UseVisualStyleBackColor = true;
         this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
         // 
         // FormSupressionQuestion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
         this.ClientSize = new System.Drawing.Size(310, 316);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.BTN_Supprimer);
         this.Controls.Add(this.BTN_Annuler);
         this.Controls.Add(this.CB_CATEGORIE);
         this.Controls.Add(this.label6);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormSupressionQuestion";
         this.Text = "Suppression de Questions";
         this.Load += new System.EventHandler(this.FormSupressionQuestion_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button BTN_Annuler;
      private System.Windows.Forms.ComboBox CB_CATEGORIE;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Button BTN_Supprimer;
      private System.Windows.Forms.Button BTN_PRECEDENT;
      private System.Windows.Forms.Label LB_REPONSE;
      private System.Windows.Forms.Button BTN_SUIVANT;
      private System.Windows.Forms.Label LB_QUESTION;
      private System.Windows.Forms.Label LB_CHOIX1;
      private System.Windows.Forms.Label LB_ID;
      private System.Windows.Forms.Label LB_CHOIX2;
      private System.Windows.Forms.Label LB_CHOIX3;
   }
}