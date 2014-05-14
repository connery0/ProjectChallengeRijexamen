namespace ProjectChallengeRijexamen
{
    partial class MC_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MC_Form));
            this.MC_Radio3 = new System.Windows.Forms.RadioButton();
            this.MC_Radio2 = new System.Windows.Forms.RadioButton();
            this.MC_Radio1 = new System.Windows.Forms.RadioButton();
            this.MC_picture = new System.Windows.Forms.PictureBox();
            this.MC_Progres = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProgresLabel = new System.Windows.Forms.Label();
            this.VraagTeller = new System.Windows.Forms.Label();
            this.MC_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MC_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // MC_Radio3
            // 
            this.MC_Radio3.BackColor = System.Drawing.Color.Transparent;
            this.MC_Radio3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MC_Radio3.Cursor = System.Windows.Forms.Cursors.Default;
            this.MC_Radio3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.MC_Radio3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MC_Radio3.Location = new System.Drawing.Point(402, 318);
            this.MC_Radio3.Name = "MC_Radio3";
            this.MC_Radio3.Size = new System.Drawing.Size(320, 90);
            this.MC_Radio3.TabIndex = 13;
            this.MC_Radio3.TabStop = true;
            this.MC_Radio3.Text = "Antwoord";
            this.MC_Radio3.UseVisualStyleBackColor = false;
            this.MC_Radio3.CheckedChanged += new System.EventHandler(this.MC_Radio3_CheckedChanged);
            // 
            // MC_Radio2
            // 
            this.MC_Radio2.BackColor = System.Drawing.Color.Transparent;
            this.MC_Radio2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MC_Radio2.Cursor = System.Windows.Forms.Cursors.Default;
            this.MC_Radio2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.MC_Radio2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MC_Radio2.Location = new System.Drawing.Point(402, 217);
            this.MC_Radio2.Name = "MC_Radio2";
            this.MC_Radio2.Size = new System.Drawing.Size(320, 90);
            this.MC_Radio2.TabIndex = 12;
            this.MC_Radio2.TabStop = true;
            this.MC_Radio2.Text = "Antwoord";
            this.MC_Radio2.UseVisualStyleBackColor = false;
            this.MC_Radio2.CheckedChanged += new System.EventHandler(this.MC_Radio2_CheckedChanged);
            // 
            // MC_Radio1
            // 
            this.MC_Radio1.BackColor = System.Drawing.Color.Transparent;
            this.MC_Radio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MC_Radio1.Cursor = System.Windows.Forms.Cursors.Default;
            this.MC_Radio1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.MC_Radio1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MC_Radio1.Location = new System.Drawing.Point(402, 119);
            this.MC_Radio1.Name = "MC_Radio1";
            this.MC_Radio1.Size = new System.Drawing.Size(320, 90);
            this.MC_Radio1.TabIndex = 11;
            this.MC_Radio1.TabStop = true;
            this.MC_Radio1.Text = "Antwoord";
            this.MC_Radio1.UseVisualStyleBackColor = false;
            this.MC_Radio1.CheckedChanged += new System.EventHandler(this.MC_Radio1_CheckedChanged);
            // 
            // MC_picture
            // 
            this.MC_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MC_picture.Cursor = System.Windows.Forms.Cursors.Default;
            this.MC_picture.ImageLocation = "";
            this.MC_picture.Location = new System.Drawing.Point(62, 165);
            this.MC_picture.Name = "MC_picture";
            this.MC_picture.Size = new System.Drawing.Size(274, 220);
            this.MC_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MC_picture.TabIndex = 10;
            this.MC_picture.TabStop = false;
            // 
            // MC_Progres
            // 
            this.MC_Progres.Location = new System.Drawing.Point(11, 431);
            this.MC_Progres.MarqueeAnimationSpeed = 0;
            this.MC_Progres.Name = "MC_Progres";
            this.MC_Progres.Size = new System.Drawing.Size(567, 23);
            this.MC_Progres.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MC_Progres.TabIndex = 9;
            this.MC_Progres.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Antwoord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProgresLabel
            // 
            this.ProgresLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgresLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProgresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgresLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ProgresLabel.Location = new System.Drawing.Point(579, 421);
            this.ProgresLabel.Name = "ProgresLabel";
            this.ProgresLabel.Size = new System.Drawing.Size(42, 43);
            this.ProgresLabel.TabIndex = 15;
            this.ProgresLabel.Text = "00M 00S";
            this.ProgresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgresLabel.Visible = false;
            // 
            // VraagTeller
            // 
            this.VraagTeller.AutoSize = true;
            this.VraagTeller.BackColor = System.Drawing.Color.Transparent;
            this.VraagTeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VraagTeller.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VraagTeller.Location = new System.Drawing.Point(682, 2);
            this.VraagTeller.Name = "VraagTeller";
            this.VraagTeller.Size = new System.Drawing.Size(54, 20);
            this.VraagTeller.TabIndex = 16;
            this.VraagTeller.Text = "00/00";
            this.VraagTeller.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MC_Label
            // 
            this.MC_Label.BackColor = System.Drawing.Color.Transparent;
            this.MC_Label.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.MC_Label.ForeColor = System.Drawing.Color.Transparent;
            this.MC_Label.Location = new System.Drawing.Point(12, 22);
            this.MC_Label.Name = "MC_Label";
            this.MC_Label.Size = new System.Drawing.Size(710, 114);
            this.MC_Label.TabIndex = 17;
            this.MC_Label.Text = "label1";
            // 
            // MC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ProjectChallengeRijexamen.Properties.Resources.Test__750x502_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.MC_Label);
            this.Controls.Add(this.VraagTeller);
            this.Controls.Add(this.ProgresLabel);
            this.Controls.Add(this.MC_Radio3);
            this.Controls.Add(this.MC_Radio2);
            this.Controls.Add(this.MC_Radio1);
            this.Controls.Add(this.MC_picture);
            this.Controls.Add(this.MC_Progres);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MC_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proefexamen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MC_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.MC_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MC_Radio3;
        private System.Windows.Forms.RadioButton MC_Radio2;
        private System.Windows.Forms.RadioButton MC_Radio1;
        private System.Windows.Forms.PictureBox MC_picture;
        private System.Windows.Forms.ProgressBar MC_Progres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ProgresLabel;
        private System.Windows.Forms.Label VraagTeller;
        private System.Windows.Forms.Label MC_Label;
    }
}