namespace MATH
{
    partial class frmMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusic));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pic1UP = new System.Windows.Forms.PictureBox();
            this.picTreasure = new System.Windows.Forms.PictureBox();
            this.picDead = new System.Windows.Forms.PictureBox();
            this.picLevel = new System.Windows.Forms.PictureBox();
            this.picTail = new System.Windows.Forms.PictureBox();
            this.picThreeCards = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1UP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThreeCards)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(16, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(440, 46);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Press one of the icons below to play one of the sounds from\r\nthis game.";
            // 
            // pic1UP
            // 
            this.pic1UP.Image = global::MATH.Properties.Resources._1UP;
            this.pic1UP.Location = new System.Drawing.Point(77, 58);
            this.pic1UP.Name = "pic1UP";
            this.pic1UP.Size = new System.Drawing.Size(48, 48);
            this.pic1UP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic1UP.TabIndex = 1;
            this.pic1UP.TabStop = false;
            this.pic1UP.Click += new System.EventHandler(this.pic1UP_Click);
            // 
            // picTreasure
            // 
            this.picTreasure.Image = global::MATH.Properties.Resources.chest;
            this.picTreasure.Location = new System.Drawing.Point(131, 58);
            this.picTreasure.Name = "picTreasure";
            this.picTreasure.Size = new System.Drawing.Size(48, 48);
            this.picTreasure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTreasure.TabIndex = 2;
            this.picTreasure.TabStop = false;
            this.picTreasure.Click += new System.EventHandler(this.picTreasure_Click);
            // 
            // picDead
            // 
            this.picDead.Image = global::MATH.Properties.Resources.dead;
            this.picDead.Location = new System.Drawing.Point(185, 58);
            this.picDead.Name = "picDead";
            this.picDead.Size = new System.Drawing.Size(48, 48);
            this.picDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDead.TabIndex = 3;
            this.picDead.TabStop = false;
            this.picDead.Click += new System.EventHandler(this.picDead_Click);
            // 
            // picLevel
            // 
            this.picLevel.Image = global::MATH.Properties.Resources.levelClear;
            this.picLevel.Location = new System.Drawing.Point(239, 58);
            this.picLevel.Name = "picLevel";
            this.picLevel.Size = new System.Drawing.Size(48, 48);
            this.picLevel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLevel.TabIndex = 4;
            this.picLevel.TabStop = false;
            this.picLevel.Click += new System.EventHandler(this.picLevel_Click);
            // 
            // picTail
            // 
            this.picTail.Image = global::MATH.Properties.Resources.tail;
            this.picTail.Location = new System.Drawing.Point(293, 58);
            this.picTail.Name = "picTail";
            this.picTail.Size = new System.Drawing.Size(48, 48);
            this.picTail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTail.TabIndex = 5;
            this.picTail.TabStop = false;
            this.picTail.Click += new System.EventHandler(this.picTail_Click);
            // 
            // picThreeCards
            // 
            this.picThreeCards.Image = global::MATH.Properties.Resources.threeCards;
            this.picThreeCards.Location = new System.Drawing.Point(347, 58);
            this.picThreeCards.Name = "picThreeCards";
            this.picThreeCards.Size = new System.Drawing.Size(48, 48);
            this.picThreeCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picThreeCards.TabIndex = 6;
            this.picThreeCards.TabStop = false;
            this.picThreeCards.Click += new System.EventHandler(this.picThreeCards_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(386, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(473, 156);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picThreeCards);
            this.Controls.Add(this.picTail);
            this.Controls.Add(this.picLevel);
            this.Controls.Add(this.picDead);
            this.Controls.Add(this.picTreasure);
            this.Controls.Add(this.pic1UP);
            this.Controls.Add(this.lblInstructions);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMusic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mario\'s Music Box";
            ((System.ComponentModel.ISupportInitialize)(this.pic1UP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTreasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThreeCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox pic1UP;
        private System.Windows.Forms.PictureBox picTreasure;
        private System.Windows.Forms.PictureBox picDead;
        private System.Windows.Forms.PictureBox picLevel;
        private System.Windows.Forms.PictureBox picTail;
        private System.Windows.Forms.PictureBox picThreeCards;
        private System.Windows.Forms.Button btnClose;
    }
}