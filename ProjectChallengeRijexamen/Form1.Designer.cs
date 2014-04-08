namespace ProjectChallengeRijexamen
{
    partial class Form1
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
            this.antwoord1 = new System.Windows.Forms.RadioButton();
            this.antwoord2 = new System.Windows.Forms.RadioButton();
            this.antwoord3 = new System.Windows.Forms.RadioButton();
            this.antwoord4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Vraagbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // antwoord1
            // 
            this.antwoord1.AutoSize = true;
            this.antwoord1.Location = new System.Drawing.Point(12, 76);
            this.antwoord1.Name = "antwoord1";
            this.antwoord1.Size = new System.Drawing.Size(79, 17);
            this.antwoord1.TabIndex = 0;
            this.antwoord1.TabStop = true;
            this.antwoord1.Text = "Antwoord 1";
            this.antwoord1.UseVisualStyleBackColor = true;
            // 
            // antwoord2
            // 
            this.antwoord2.AutoSize = true;
            this.antwoord2.Location = new System.Drawing.Point(12, 109);
            this.antwoord2.Name = "antwoord2";
            this.antwoord2.Size = new System.Drawing.Size(79, 17);
            this.antwoord2.TabIndex = 1;
            this.antwoord2.TabStop = true;
            this.antwoord2.Text = "Antwoord 2";
            this.antwoord2.UseVisualStyleBackColor = true;
            // 
            // antwoord3
            // 
            this.antwoord3.AutoSize = true;
            this.antwoord3.Location = new System.Drawing.Point(12, 137);
            this.antwoord3.Name = "antwoord3";
            this.antwoord3.Size = new System.Drawing.Size(79, 17);
            this.antwoord3.TabIndex = 2;
            this.antwoord3.TabStop = true;
            this.antwoord3.Text = "Antwoord 3";
            this.antwoord3.UseVisualStyleBackColor = true;
            // 
            // antwoord4
            // 
            this.antwoord4.AutoSize = true;
            this.antwoord4.Location = new System.Drawing.Point(12, 164);
            this.antwoord4.Name = "antwoord4";
            this.antwoord4.Size = new System.Drawing.Size(79, 17);
            this.antwoord4.TabIndex = 3;
            this.antwoord4.TabStop = true;
            this.antwoord4.Text = "Antwoord 4";
            this.antwoord4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "controleer / volgende";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vraagbox
            // 
            this.Vraagbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vraagbox.Location = new System.Drawing.Point(2, 2);
            this.Vraagbox.Multiline = true;
            this.Vraagbox.Name = "Vraagbox";
            this.Vraagbox.ReadOnly = true;
            this.Vraagbox.Size = new System.Drawing.Size(323, 70);
            this.Vraagbox.TabIndex = 5;
            this.Vraagbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Moire", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(12, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(162, 40);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Juist";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start / reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Vraagbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.antwoord4);
            this.Controls.Add(this.antwoord3);
            this.Controls.Add(this.antwoord2);
            this.Controls.Add(this.antwoord1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton antwoord1;
        private System.Windows.Forms.RadioButton antwoord2;
        private System.Windows.Forms.RadioButton antwoord3;
        private System.Windows.Forms.RadioButton antwoord4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Vraagbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;

    }
}

