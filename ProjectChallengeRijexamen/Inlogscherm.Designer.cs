namespace ProjectChallengeRijexamen
{
    partial class Inlogscherm
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
            this.TextboxAchternaam = new System.Windows.Forms.TextBox();
            this.TextboxNaam = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnAnnuleren = new System.Windows.Forms.Button();
            this.BtnAanmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextboxAchternaam
            // 
            this.TextboxAchternaam.Location = new System.Drawing.Point(103, 38);
            this.TextboxAchternaam.Name = "TextboxAchternaam";

            this.TextboxAchternaam.PasswordChar = '*';

            this.TextboxAchternaam.Size = new System.Drawing.Size(169, 20);
            this.TextboxAchternaam.TabIndex = 6;
            // 
            // TextboxNaam
            // 
            this.TextboxNaam.Location = new System.Drawing.Point(103, 12);
            this.TextboxNaam.Name = "TextboxNaam";
            this.TextboxNaam.Size = new System.Drawing.Size(169, 20);
            this.TextboxNaam.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(33, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Achternaam";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(62, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Naam";
            // 
            // BtnAnnuleren
            // 
            this.BtnAnnuleren.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnAnnuleren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnnuleren.Location = new System.Drawing.Point(187, 64);
            this.BtnAnnuleren.Name = "BtnAnnuleren";
            this.BtnAnnuleren.Size = new System.Drawing.Size(85, 23);
            this.BtnAnnuleren.TabIndex = 10;
            this.BtnAnnuleren.Text = "Aflsluiten";
            this.BtnAnnuleren.UseVisualStyleBackColor = false;
            // 
            // BtnAanmelden
            // 
            this.BtnAanmelden.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnAanmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAanmelden.Location = new System.Drawing.Point(103, 64);
            this.BtnAanmelden.Name = "BtnAanmelden";
            this.BtnAanmelden.Size = new System.Drawing.Size(78, 23);
            this.BtnAanmelden.TabIndex = 9;
            this.BtnAanmelden.Text = "Aanmelden";
            this.BtnAanmelden.UseVisualStyleBackColor = false;

            this.BtnAanmelden.Click += new System.EventHandler(this.BtnAanmelden_Click);

            this.BtnAanmelden.Click += new System.EventHandler(this.BtnAanmelden_Click);
  this.BtnAanmelden.Click += new System.EventHandler(this.BtnAanmelden_Click);

            // 
            // Inlogscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.TextboxAchternaam);
            this.Controls.Add(this.TextboxNaam);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnAnnuleren);
            this.Controls.Add(this.BtnAanmelden);
            this.Name = "Inlogscherm";
            this.Text = "Inlogscherm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextboxAchternaam;
        internal System.Windows.Forms.TextBox TextboxNaam;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnAnnuleren;
        internal System.Windows.Forms.Button BtnAanmelden;
    }
}