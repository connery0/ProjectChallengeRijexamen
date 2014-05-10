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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.M_knop1 = new System.Windows.Forms.Button();
            this.M_knop2 = new System.Windows.Forms.Button();
            this.M_knop3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // M_knop1
            // 
            resources.ApplyResources(this.M_knop1, "M_knop1");
            this.M_knop1.Name = "M_knop1";
            this.M_knop1.UseVisualStyleBackColor = true;
            this.M_knop1.Click += new System.EventHandler(this.M_knop1_Click);
            // 
            // M_knop2
            // 
            resources.ApplyResources(this.M_knop2, "M_knop2");
            this.M_knop2.Name = "M_knop2";
            this.M_knop2.UseVisualStyleBackColor = true;
            this.M_knop2.Click += new System.EventHandler(this.M_knop2_Click);
            // 
            // M_knop3
            // 
            resources.ApplyResources(this.M_knop3, "M_knop3");
            this.M_knop3.Name = "M_knop3";
            this.M_knop3.UseVisualStyleBackColor = true;
            this.M_knop3.Click += new System.EventHandler(this.M_knop3_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.M_knop3);
            this.Controls.Add(this.M_knop2);
            this.Controls.Add(this.M_knop1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button M_knop1;
        private System.Windows.Forms.Button M_knop2;
        private System.Windows.Forms.Button M_knop3;


    }
}

