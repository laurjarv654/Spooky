namespace Spooky
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
            this.mainStory = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.voiceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainStory
            // 
            this.mainStory.BackColor = System.Drawing.Color.Transparent;
            this.mainStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainStory.ForeColor = System.Drawing.Color.Red;
            this.mainStory.Location = new System.Drawing.Point(10, 249);
            this.mainStory.Name = "mainStory";
            this.mainStory.Size = new System.Drawing.Size(766, 115);
            this.mainStory.TabIndex = 2;
            this.mainStory.Text = "label2";
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.BackColor = System.Drawing.Color.Transparent;
            this.option2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.option2.Location = new System.Drawing.Point(270, 397);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(46, 17);
            this.option2.TabIndex = 3;
            this.option2.Text = "label1";
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.BackColor = System.Drawing.Color.Transparent;
            this.option1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.option1.Location = new System.Drawing.Point(24, 397);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(46, 17);
            this.option1.TabIndex = 4;
            this.option1.Text = "label3";
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.BackColor = System.Drawing.Color.Transparent;
            this.option3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.option3.Location = new System.Drawing.Point(24, 440);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(46, 17);
            this.option3.TabIndex = 5;
            this.option3.Text = "label1";
            // 
            // voiceLabel
            // 
            this.voiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.voiceLabel.ForeColor = System.Drawing.Color.Red;
            this.voiceLabel.Location = new System.Drawing.Point(10, 12);
            this.voiceLabel.Name = "voiceLabel";
            this.voiceLabel.Size = new System.Drawing.Size(306, 220);
            this.voiceLabel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Spooky.Properties.Resources.living_room2;
            this.pictureBox1.Image = global::Spooky.Properties.Resources.living_room;
            this.pictureBox1.Location = new System.Drawing.Point(366, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(816, 514);
            this.Controls.Add(this.voiceLabel);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.mainStory);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mainStory;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.Label voiceLabel;
    }
}

