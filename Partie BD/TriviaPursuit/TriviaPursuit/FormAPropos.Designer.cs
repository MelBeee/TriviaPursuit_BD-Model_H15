namespace TriviaPursuit
{
   partial class FormAPropos
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAPropos));
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.BTN_Fermer = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
         this.pictureBox1.Image = global::TriviaPursuit.Properties.Resources.LogoTrivial_Diamond;
         this.pictureBox1.Location = new System.Drawing.Point(84, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(122, 91);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 6;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(74, 106);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(147, 29);
         this.label1.TabIndex = 7;
         this.label1.Text = "Trivial Diamond";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label2
         // 
         this.label2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(9, 134);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(273, 129);
         this.label2.TabIndex = 8;
         this.label2.Text = resources.GetString("label2.Text");
         this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(32, 260);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(227, 43);
         this.label3.TabIndex = 9;
         this.label3.Text = "Fait par Mélissa Boucher et \r\nCharlie Laplante";
         this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // BTN_Fermer
         // 
         this.BTN_Fermer.Location = new System.Drawing.Point(107, 304);
         this.BTN_Fermer.Name = "BTN_Fermer";
         this.BTN_Fermer.Size = new System.Drawing.Size(75, 23);
         this.BTN_Fermer.TabIndex = 10;
         this.BTN_Fermer.Text = "Fermer";
         this.BTN_Fermer.UseVisualStyleBackColor = true;
         this.BTN_Fermer.Click += new System.EventHandler(this.BTN_Fermer_Click);
         // 
         // FormAPropos
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(40)))));
         this.ClientSize = new System.Drawing.Size(289, 337);
         this.Controls.Add(this.BTN_Fermer);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormAPropos";
         this.Text = "À Propos";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button BTN_Fermer;
   }
}