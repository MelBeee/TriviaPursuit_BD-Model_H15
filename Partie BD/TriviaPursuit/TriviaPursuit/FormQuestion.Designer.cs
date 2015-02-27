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
         this.SuspendLayout();
         // 
         // LB_Choix1
         // 
         this.LB_Choix1.BackColor = System.Drawing.Color.PaleGoldenrod;
         this.LB_Choix1.Font = new System.Drawing.Font("Buxton Sketch", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Choix1.Location = new System.Drawing.Point(58, 224);
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
         this.LB_Choix2.Location = new System.Drawing.Point(58, 86);
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
         this.LB_Choix3.Location = new System.Drawing.Point(58, 132);
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
         this.LB_Choix4.Location = new System.Drawing.Point(58, 178);
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
         // FormQuestion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(226)))), ((int)(((byte)(69)))));
         this.ClientSize = new System.Drawing.Size(404, 273);
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
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label LB_Choix1;
      private System.Windows.Forms.Label LB_Choix2;
      private System.Windows.Forms.Label LB_Choix3;
      private System.Windows.Forms.Label LB_Choix4;
      private System.Windows.Forms.Label label1;
   }
}