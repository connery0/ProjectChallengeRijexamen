namespace ProjectChallengeRijexamen
{
    partial class DnD_Start
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Text_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Naam2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Naam1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 49);
            this.button2.TabIndex = 16;
            this.button2.Text = "Foute vragen oefenen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(443, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "Volgende";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Text_Label
            // 
            this.Text_Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.Text_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Label.Location = new System.Drawing.Point(5, 212);
            this.Text_Label.Name = "Text_Label";
            this.Text_Label.Size = new System.Drawing.Size(719, 77);
            this.Text_Label.TabIndex = 14;
            this.Text_Label.Text = "Klik op volgende om met de test te beginnen";
            this.Text_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Naam:";
            // 
            // Naam2
            // 
            this.Naam2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naam2.Location = new System.Drawing.Point(427, 134);
            this.Naam2.Name = "Naam2";
            this.Naam2.Size = new System.Drawing.Size(285, 32);
            this.Naam2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Voornaam:";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gelieve uw Naam en voornaam in te vullen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Naam1
            // 
            this.Naam1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naam1.Location = new System.Drawing.Point(127, 132);
            this.Naam1.Name = "Naam1";
            this.Naam1.Size = new System.Drawing.Size(223, 32);
            this.Naam1.TabIndex = 9;
            // 
            // DnD_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Naam2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naam1);
            this.Name = "DnD_Start";
            this.Text = "Drag n Drop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Text_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Naam2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Naam1;
    }
}