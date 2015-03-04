namespace TriviaPursuit
{
   partial class FormQuestion
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
         this.LB_Choix1 = new System.Windows.Forms.Label();
         this.LB_Choix2 = new System.Windows.Forms.Label();
         this.LB_Choix3 = new System.Windows.Forms.Label();
         this.LB_Choix4 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.PN_MSGRep = new System.Windows.Forms.Panel();
         this.BTN_Continuer = new System.Windows.Forms.Button();
         this.LB_MSGRep = new System.Windows.Forms.Label();
         this.PN_MSGRep.SuspendLayout();
         this.SuspendLayout();
         // 
         // LB_Choix1
         // 
         this.LB_Choix1.BackColor = System.Drawing.Color.PaleGoldenrod;
         this.LB_Choix1.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Choix1.Location = new System.Drawing.Point(58, 87);
         this.LB_Choix1.Name = "LB_Choix1";
         this.LB_Choix1.Size = new System.Drawing.Size(288, 38);
         this.LB_Choix1.TabIndex = 1;
         this.LB_Choix1.Text = "L\'oeuf";
         this.LB_Choix1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.LB_Choix1.Click += new System.EventHandler(this.LB_Choix1_Click);
         this.LB_Choix1.MouseLeave += new System.EventHandler(this.LB_Choix1_MouseLeave);
         this.LB_Choix1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Choix1_MouseMove);
         // 
         // LB_Choix2
         // 
         this.LB_Choix2.BackColor = System.Drawing.Color.PaleGoldenrod;
         this.LB_Choix2.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Choix2.Location = new System.Drawing.Point(58, 133);
         this.LB_Choix2.Name = "LB_Choix2";
         this.LB_Choix2.Size = new System.Drawing.Size(288, 38);
         this.LB_Choix2.TabIndex = 2;
         this.LB_Choix2.Text = "La Poule";
         this.LB_Choix2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.LB_Choix2.Click += new System.EventHandler(this.LB_Choix2_Click);
         this.LB_Choix2.MouseLeave += new System.EventHandler(this.LB_Choix2_MouseLeave);
         this.LB_Choix2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Choix2_MouseMove);
         // 
         // LB_Choix3
         // 
         this.LB_Choix3.BackColor = System.Drawing.Color.PaleGoldenrod;
         this.LB_Choix3.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Choix3.Location = new System.Drawing.Point(58, 179);
         this.LB_Choix3.Name = "LB_Choix3";
         this.LB_Choix3.Size = new System.Drawing.Size(288, 38);
         this.LB_Choix3.TabIndex = 3;
         this.LB_Choix3.Text = "La question ne sera jamais jamais répondu";
         this.LB_Choix3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.LB_Choix3.Click += new System.EventHandler(this.LB_Choix3_Click);
         this.LB_Choix3.MouseLeave += new System.EventHandler(this.LB_Choix3_MouseLeave);
         this.LB_Choix3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Choix3_MouseMove);
         // 
         // LB_Choix4
         // 
         this.LB_Choix4.BackColor = System.Drawing.Color.PaleGoldenrod;
         this.LB_Choix4.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Choix4.Location = new System.Drawing.Point(58, 225);
         this.LB_Choix4.Name = "LB_Choix4";
         this.LB_Choix4.Size = new System.Drawing.Size(288, 38);
         this.LB_Choix4.TabIndex = 4;
         this.LB_Choix4.Text = "Mystère de la vie";
         this.LB_Choix4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.LB_Choix4.Click += new System.EventHandler(this.LB_Choix4_Click);
         this.LB_Choix4.MouseLeave += new System.EventHandler(this.LB_Choix4_MouseLeave);
         this.LB_Choix4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_Choix4_MouseMove);
         // 
         // label1
         // 
         this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(380, 69);
         this.label1.TabIndex = 0;
         this.label1.Text = "Est-ce que la poule ou l\'oeuf en premier ? ";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // PN_MSGRep
         // 
         this.PN_MSGRep.Controls.Add(this.BTN_Continuer);
         this.PN_MSGRep.Controls.Add(this.LB_MSGRep);
         this.PN_MSGRep.Location = new System.Drawing.Point(0, 0);
         this.PN_MSGRep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.PN_MSGRep.Name = "PN_MSGRep";
         this.PN_MSGRep.Size = new System.Drawing.Size(404, 273);
         this.PN_MSGRep.TabIndex = 5;
         this.PN_MSGRep.Visible = false;
         // 
         // BTN_Continuer
         // 
         this.BTN_Continuer.Location = new System.Drawing.Point(166, 240);
         this.BTN_Continuer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.BTN_Continuer.Name = "BTN_Continuer";
         this.BTN_Continuer.Size = new System.Drawing.Size(71, 21);
         this.BTN_Continuer.TabIndex = 1;
         this.BTN_Continuer.Text = "Continuer";
         this.BTN_Continuer.UseVisualStyleBackColor = true;
         this.BTN_Continuer.Click += new System.EventHandler(this.BTN_Continuer_Click);
         // 
         // LB_MSGRep
         // 
         this.LB_MSGRep.Font = new System.Drawing.Font("Buxton Sketch", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_MSGRep.Location = new System.Drawing.Point(9, 7);
         this.LB_MSGRep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_MSGRep.Name = "LB_MSGRep";
         this.LB_MSGRep.Size = new System.Drawing.Size(386, 257);
         this.LB_MSGRep.TabIndex = 0;
         this.LB_MSGRep.Text = "Bonne réponse !";
         this.LB_MSGRep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // FormQuestion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(226)))), ((int)(((byte)(69)))));
         this.ClientSize = new System.Drawing.Size(404, 273);
         this.Controls.Add(this.PN_MSGRep);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.LB_Choix4);
         this.Controls.Add(this.LB_Choix3);
         this.Controls.Add(this.LB_Choix2);
         this.Controls.Add(this.LB_Choix1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormQuestion";
         this.Text = "FormQuestion";
         this.Load += new System.EventHandler(this.FormQuestion_Load);
         this.PN_MSGRep.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label LB_Choix1;
      private System.Windows.Forms.Label LB_Choix2;
      private System.Windows.Forms.Label LB_Choix3;
      private System.Windows.Forms.Label LB_Choix4;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel PN_MSGRep;
      private System.Windows.Forms.Label LB_MSGRep;
      private System.Windows.Forms.Button BTN_Continuer;
   }
}