namespace WindowsFormsApplication1
{
    partial class TheorieViewer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.theorie = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "De rijbaan",
            "De rijstroken",
            "Het fietspad",
            "De autosnelweg",
            "De autoweg",
            "Speciale plaatsen",
            "De voetgangers",
            "De bestuurrders",
            "Personenauto",
            "Lading-zitplaatsen",
            "De lichten",
            "Snelheid",
            "Stopafstand",
            "Kruisen",
            "Inhalen(1)",
            "Inhalen(2)",
            "Bevoegde personen",
            "Verkeerslichten",
            "Kruispunten borden",
            "Voorrang van rechts",
            "Voorrang/afslaan",
            "Trein - tram - bus",
            "Verboden rijrichting",
            "Verplichte richting",
            "Parkeren(1)",
            "Parkeren(2)",
            "Parkeren(3)",
            "Alcohol - drugs",
            "Ongeval",
            "Milieu",
            "Techniek"});
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 433);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Onderwerpen";
            // 
            // theorie
            // 
            this.theorie.AutoSize = true;
            this.theorie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.theorie.Location = new System.Drawing.Point(10, 34);
            this.theorie.Name = "theorie";
            this.theorie.Size = new System.Drawing.Size(159, 13);
            this.theorie.TabIndex = 3;
            this.theorie.Text = "Kies een onderwerp in het menu";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.theorie);
            this.panel1.Location = new System.Drawing.Point(190, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 433);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TheorieViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(892, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "TheorieViewer";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TheorieViewer_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label theorie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

