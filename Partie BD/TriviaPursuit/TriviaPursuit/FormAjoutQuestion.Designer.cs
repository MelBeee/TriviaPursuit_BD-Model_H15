namespace TriviaPursuit
{
   partial class FormAjoutQuestion
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutQuestion));
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.TB_REPONSE = new System.Windows.Forms.TextBox();
         this.TB_CHOIX1 = new System.Windows.Forms.TextBox();
         this.TB_CHOIX2 = new System.Windows.Forms.TextBox();
         this.TB_CHOIX3 = new System.Windows.Forms.TextBox();
         this.TB_QUESTION = new System.Windows.Forms.TextBox();
         this.CB_CATEGORIE = new System.Windows.Forms.ComboBox();
         this.BTN_Ajouter = new System.Windows.Forms.Button();
         this.BTN_Annuler = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 30);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(82, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Question :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(17, 89);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(77, 23);
         this.label2.TabIndex = 1;
         this.label2.Text = "Réponse :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(30, 119);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 23);
         this.label3.TabIndex = 2;
         this.label3.Text = "Choix 1 :";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(25, 149);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(69, 23);
         this.label4.TabIndex = 3;
         this.label4.Text = "Choix 2 :";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(24, 179);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(70, 23);
         this.label5.TabIndex = 4;
         this.label5.Text = "Choix 3 :";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(10, 209);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(84, 23);
         this.label6.TabIndex = 5;
         this.label6.Text = "Catégorie :";
         // 
         // TB_REPONSE
         // 
         this.TB_REPONSE.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_REPONSE.Location = new System.Drawing.Point(100, 85);
         this.TB_REPONSE.MaxLength = 80;
         this.TB_REPONSE.Name = "TB_REPONSE";
         this.TB_REPONSE.Size = new System.Drawing.Size(258, 27);
         this.TB_REPONSE.TabIndex = 2;
         this.TB_REPONSE.TextChanged += new System.EventHandler(this.TB_REPONSE_TextChanged);
         // 
         // TB_CHOIX1
         // 
         this.TB_CHOIX1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_CHOIX1.Location = new System.Drawing.Point(100, 115);
         this.TB_CHOIX1.MaxLength = 80;
         this.TB_CHOIX1.Name = "TB_CHOIX1";
         this.TB_CHOIX1.Size = new System.Drawing.Size(258, 27);
         this.TB_CHOIX1.TabIndex = 3;
         this.TB_CHOIX1.TextChanged += new System.EventHandler(this.TB_CHOIX1_TextChanged);
         // 
         // TB_CHOIX2
         // 
         this.TB_CHOIX2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_CHOIX2.Location = new System.Drawing.Point(100, 145);
         this.TB_CHOIX2.MaxLength = 80;
         this.TB_CHOIX2.Name = "TB_CHOIX2";
         this.TB_CHOIX2.Size = new System.Drawing.Size(258, 27);
         this.TB_CHOIX2.TabIndex = 4;
         this.TB_CHOIX2.TextChanged += new System.EventHandler(this.TB_CHOIX2_TextChanged);
         // 
         // TB_CHOIX3
         // 
         this.TB_CHOIX3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_CHOIX3.Location = new System.Drawing.Point(100, 175);
         this.TB_CHOIX3.MaxLength = 80;
         this.TB_CHOIX3.Name = "TB_CHOIX3";
         this.TB_CHOIX3.Size = new System.Drawing.Size(258, 27);
         this.TB_CHOIX3.TabIndex = 5;
         this.TB_CHOIX3.TextChanged += new System.EventHandler(this.TB_CHOIX3_TextChanged);
         // 
         // TB_QUESTION
         // 
         this.TB_QUESTION.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_QUESTION.Location = new System.Drawing.Point(100, 12);
         this.TB_QUESTION.MaxLength = 120;
         this.TB_QUESTION.Multiline = true;
         this.TB_QUESTION.Name = "TB_QUESTION";
         this.TB_QUESTION.Size = new System.Drawing.Size(258, 70);
         this.TB_QUESTION.TabIndex = 1;
         this.TB_QUESTION.TextChanged += new System.EventHandler(this.TB_QUESTION_TextChanged);
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
         this.CB_CATEGORIE.Location = new System.Drawing.Point(100, 205);
         this.CB_CATEGORIE.Name = "CB_CATEGORIE";
         this.CB_CATEGORIE.Size = new System.Drawing.Size(258, 28);
         this.CB_CATEGORIE.TabIndex = 6;
         // 
         // BTN_Ajouter
         // 
         this.BTN_Ajouter.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Ajouter.Location = new System.Drawing.Point(106, 243);
         this.BTN_Ajouter.Name = "BTN_Ajouter";
         this.BTN_Ajouter.Size = new System.Drawing.Size(80, 25);
         this.BTN_Ajouter.TabIndex = 12;
         this.BTN_Ajouter.Text = "Ajouter";
         this.BTN_Ajouter.UseVisualStyleBackColor = true;
         this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
         // 
         // BTN_Annuler
         // 
         this.BTN_Annuler.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Annuler.Location = new System.Drawing.Point(187, 243);
         this.BTN_Annuler.Name = "BTN_Annuler";
         this.BTN_Annuler.Size = new System.Drawing.Size(80, 25);
         this.BTN_Annuler.TabIndex = 13;
         this.BTN_Annuler.Text = "Annuler";
         this.BTN_Annuler.UseVisualStyleBackColor = true;
         this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
         // 
         // FormAjoutQuestion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
         this.ClientSize = new System.Drawing.Size(372, 274);
         this.Controls.Add(this.BTN_Annuler);
         this.Controls.Add(this.BTN_Ajouter);
         this.Controls.Add(this.CB_CATEGORIE);
         this.Controls.Add(this.TB_QUESTION);
         this.Controls.Add(this.TB_CHOIX3);
         this.Controls.Add(this.TB_CHOIX2);
         this.Controls.Add(this.TB_CHOIX1);
         this.Controls.Add(this.TB_REPONSE);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormAjoutQuestion";
         this.Text = "Ajout de Question";
         this.Load += new System.EventHandler(this.FormAjoutQuestion_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox TB_REPONSE;
      private System.Windows.Forms.TextBox TB_CHOIX1;
      private System.Windows.Forms.TextBox TB_CHOIX2;
      private System.Windows.Forms.TextBox TB_CHOIX3;
      private System.Windows.Forms.TextBox TB_QUESTION;
      private System.Windows.Forms.ComboBox CB_CATEGORIE;
      private System.Windows.Forms.Button BTN_Ajouter;
      private System.Windows.Forms.Button BTN_Annuler;
   }
}