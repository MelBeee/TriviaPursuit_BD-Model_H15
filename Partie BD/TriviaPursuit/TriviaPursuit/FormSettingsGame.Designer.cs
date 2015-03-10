namespace TriviaPursuit
{
   partial class FormSettingsGame
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
         this.TB_P1 = new System.Windows.Forms.TextBox();
         this.TB_P2 = new System.Windows.Forms.TextBox();
         this.TB_P3 = new System.Windows.Forms.TextBox();
         this.TB_P4 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.BTN_Start = new System.Windows.Forms.Button();
         this.BTN_Cancel = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // TB_P1
         // 
         this.TB_P1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_P1.Location = new System.Drawing.Point(71, 76);
         this.TB_P1.Name = "TB_P1";
         this.TB_P1.Size = new System.Drawing.Size(128, 27);
         this.TB_P1.TabIndex = 5;
         // 
         // TB_P2
         // 
         this.TB_P2.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_P2.Location = new System.Drawing.Point(71, 106);
         this.TB_P2.Name = "TB_P2";
         this.TB_P2.Size = new System.Drawing.Size(128, 27);
         this.TB_P2.TabIndex = 6;
         // 
         // TB_P3
         // 
         this.TB_P3.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_P3.Location = new System.Drawing.Point(71, 136);
         this.TB_P3.Name = "TB_P3";
         this.TB_P3.Size = new System.Drawing.Size(128, 27);
         this.TB_P3.TabIndex = 7;
         // 
         // TB_P4
         // 
         this.TB_P4.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_P4.Location = new System.Drawing.Point(71, 166);
         this.TB_P4.Name = "TB_P4";
         this.TB_P4.Size = new System.Drawing.Size(128, 27);
         this.TB_P4.TabIndex = 8;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(33, 76);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(33, 23);
         this.label1.TabIndex = 9;
         this.label1.Text = "P1 :";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(28, 107);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(38, 23);
         this.label2.TabIndex = 10;
         this.label2.Text = "P2 :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(26, 137);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(39, 23);
         this.label3.TabIndex = 11;
         this.label3.Text = "P3 :";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(28, 167);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(38, 23);
         this.label4.TabIndex = 12;
         this.label4.Text = "P4 :";
         // 
         // label5
         // 
         this.label5.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.Black;
         this.label5.Location = new System.Drawing.Point(10, 5);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(209, 27);
         this.label5.TabIndex = 13;
         this.label5.Text = "Entrez le nom des joueurs";
         this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // BTN_Start
         // 
         this.BTN_Start.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Start.Location = new System.Drawing.Point(29, 202);
         this.BTN_Start.Name = "BTN_Start";
         this.BTN_Start.Size = new System.Drawing.Size(82, 27);
         this.BTN_Start.TabIndex = 14;
         this.BTN_Start.Text = "Commencer";
         this.BTN_Start.UseVisualStyleBackColor = true;
         this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
         // 
         // BTN_Cancel
         // 
         this.BTN_Cancel.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Cancel.Location = new System.Drawing.Point(117, 202);
         this.BTN_Cancel.Name = "BTN_Cancel";
         this.BTN_Cancel.Size = new System.Drawing.Size(82, 27);
         this.BTN_Cancel.TabIndex = 15;
         this.BTN_Cancel.Text = "Annuler";
         this.BTN_Cancel.UseVisualStyleBackColor = true;
         this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
         // 
         // label6
         // 
         this.label6.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.LightCyan;
         this.label6.Location = new System.Drawing.Point(11, 32);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(206, 45);
         this.label6.TabIndex = 16;
         this.label6.Text = "Le nombre de noms entré équivaut au nombre de joueurs. ";
         this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // FormSettingsGame
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSeaGreen;
         this.ClientSize = new System.Drawing.Size(229, 236);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.BTN_Cancel);
         this.Controls.Add(this.BTN_Start);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.TB_P4);
         this.Controls.Add(this.TB_P3);
         this.Controls.Add(this.TB_P2);
         this.Controls.Add(this.TB_P1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormSettingsGame";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Paramètres de la partie";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox TB_P1;
      private System.Windows.Forms.TextBox TB_P2;
      private System.Windows.Forms.TextBox TB_P3;
      private System.Windows.Forms.TextBox TB_P4;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button BTN_Start;
      private System.Windows.Forms.Button BTN_Cancel;
      private System.Windows.Forms.Label label6;

   }
}