namespace TriviaPursuit
{
    partial class FormReglements
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReglements));
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.BTN_Close = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Buxton Sketch", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(49, 7);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(185, 29);
         this.label1.TabIndex = 0;
         this.label1.Text = "Règlements du jeu";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Black;
         this.label2.Location = new System.Drawing.Point(43, 40);
         this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(197, 26);
         this.label2.TabIndex = 1;
         this.label2.Text = "Commencer une partie";
         this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Black;
         this.label3.Location = new System.Drawing.Point(52, 236);
         this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(178, 26);
         this.label3.TabIndex = 2;
         this.label3.Text = "Terminer une partie";
         this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label4
         // 
         this.label4.Font = new System.Drawing.Font("Buxton Sketch", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(13, 66);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(257, 45);
         this.label4.TabIndex = 3;
         this.label4.Text = "Pour jouer une partie, il faut être entre 2 et 4 joueurs. ";
         this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label5
         // 
         this.label5.Font = new System.Drawing.Font("Buxton Sketch", 12.75F);
         this.label5.Location = new System.Drawing.Point(13, 262);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(257, 81);
         this.label5.TabIndex = 4;
         this.label5.Text = "Pour gagner, il faut qu\'un joueur ait répondu correctement à 3 questions de chaqu" +
    "e catégorie.";
         this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label6
         // 
         this.label6.Font = new System.Drawing.Font("Buxton Sketch", 12.75F);
         this.label6.Location = new System.Drawing.Point(13, 113);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(257, 67);
         this.label6.TabIndex = 5;
         this.label6.Text = "Chacun leur tour, le jeu va choisir au hasard une catégorie pour laquelle le joue" +
    "ur devra répondre à une question.";
         this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label7
         // 
         this.label7.Font = new System.Drawing.Font("Buxton Sketch", 12.75F);
         this.label7.Location = new System.Drawing.Point(13, 184);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(256, 50);
         this.label7.TabIndex = 6;
         this.label7.Text = "Le tour du joueur se continue tant qu\'il répond correctement aux questions.";
         this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // BTN_Close
         // 
         this.BTN_Close.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BTN_Close.Location = new System.Drawing.Point(200, 336);
         this.BTN_Close.Name = "BTN_Close";
         this.BTN_Close.Size = new System.Drawing.Size(75, 25);
         this.BTN_Close.TabIndex = 7;
         this.BTN_Close.Text = "Fermer";
         this.BTN_Close.UseVisualStyleBackColor = true;
         this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
         // 
         // FormReglements
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.MediumVioletRed;
         this.ClientSize = new System.Drawing.Size(284, 370);
         this.Controls.Add(this.BTN_Close);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(2);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FormReglements";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "FormReglements";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_Close;
    }
}