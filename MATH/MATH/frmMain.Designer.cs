namespace MATH
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnNewProb = new System.Windows.Forms.Button();
			this.grpOperation = new System.Windows.Forms.GroupBox();
			this.radMult = new System.Windows.Forms.RadioButton();
			this.radSub = new System.Windows.Forms.RadioButton();
			this.radAdd = new System.Windows.Forms.RadioButton();
			this.lblSettings = new System.Windows.Forms.Label();
			this.grpRange = new System.Windows.Forms.GroupBox();
			this.btnRange = new System.Windows.Forms.Button();
			this.lblMax = new System.Windows.Forms.Label();
			this.txtRangeMax = new System.Windows.Forms.TextBox();
			this.lblRangeMin = new System.Windows.Forms.Label();
			this.lblRangeTo = new System.Windows.Forms.Label();
			this.txtRangeMin = new System.Windows.Forms.TextBox();
			this.grpTimer = new System.Windows.Forms.GroupBox();
			this.lblTimer = new System.Windows.Forms.Label();
			this.btnTimerReset = new System.Windows.Forms.Button();
			this.chkTimer = new System.Windows.Forms.CheckBox();
			this.grpStats = new System.Windows.Forms.GroupBox();
			this.lblStat = new System.Windows.Forms.Label();
			this.lblStatLabel = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.lblStart = new System.Windows.Forms.Label();
			this.btnResetAll = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblProblem = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.lblCorrect = new System.Windows.Forms.Label();
			this.picWrong = new System.Windows.Forms.PictureBox();
			this.picRight = new System.Windows.Forms.PictureBox();
			this.tmrMainTimer = new System.Windows.Forms.Timer(this.components);
			this.grpTeacherControl = new System.Windows.Forms.GroupBox();
			this.btnLock = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnAbout = new System.Windows.Forms.Button();
			this.picMario = new System.Windows.Forms.PictureBox();
			this.picToad = new System.Windows.Forms.PictureBox();
			this.picMusic = new System.Windows.Forms.PictureBox();
			this.picWinner = new System.Windows.Forms.PictureBox();
			this.grpOperation.SuspendLayout();
			this.grpRange.SuspendLayout();
			this.grpTimer.SuspendLayout();
			this.grpStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picWrong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
			this.grpTeacherControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picToad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMusic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picWinner)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNewProb
			// 
			this.btnNewProb.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnNewProb.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewProb.Location = new System.Drawing.Point(327, 67);
			this.btnNewProb.Name = "btnNewProb";
			this.btnNewProb.Size = new System.Drawing.Size(147, 37);
			this.btnNewProb.TabIndex = 1;
			this.btnNewProb.Text = "&New Problem";
			this.btnNewProb.UseVisualStyleBackColor = false;
			this.btnNewProb.Click += new System.EventHandler(this.btnNewProb_Click);
			// 
			// grpOperation
			// 
			this.grpOperation.Controls.Add(this.radMult);
			this.grpOperation.Controls.Add(this.radSub);
			this.grpOperation.Controls.Add(this.radAdd);
			this.grpOperation.Location = new System.Drawing.Point(787, 35);
			this.grpOperation.Name = "grpOperation";
			this.grpOperation.Size = new System.Drawing.Size(200, 100);
			this.grpOperation.TabIndex = 7;
			this.grpOperation.TabStop = false;
			this.grpOperation.Text = "Operation";
			// 
			// radMult
			// 
			this.radMult.AutoSize = true;
			this.radMult.Location = new System.Drawing.Point(6, 67);
			this.radMult.Name = "radMult";
			this.radMult.Size = new System.Drawing.Size(97, 17);
			this.radMult.TabIndex = 2;
			this.radMult.Text = "Multiplication";
			this.radMult.UseVisualStyleBackColor = true;
			// 
			// radSub
			// 
			this.radSub.AutoSize = true;
			this.radSub.Location = new System.Drawing.Point(6, 44);
			this.radSub.Name = "radSub";
			this.radSub.Size = new System.Drawing.Size(85, 17);
			this.radSub.TabIndex = 1;
			this.radSub.Text = "Subtraction";
			this.radSub.UseVisualStyleBackColor = true;
			// 
			// radAdd
			// 
			this.radAdd.AutoSize = true;
			this.radAdd.Checked = true;
			this.radAdd.Location = new System.Drawing.Point(6, 21);
			this.radAdd.Name = "radAdd";
			this.radAdd.Size = new System.Drawing.Size(70, 17);
			this.radAdd.TabIndex = 0;
			this.radAdd.TabStop = true;
			this.radAdd.Text = "Addition";
			this.radAdd.UseVisualStyleBackColor = true;
			// 
			// lblSettings
			// 
			this.lblSettings.AutoSize = true;
			this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSettings.Location = new System.Drawing.Point(784, 9);
			this.lblSettings.Name = "lblSettings";
			this.lblSettings.Size = new System.Drawing.Size(49, 13);
			this.lblSettings.TabIndex = 6;
			this.lblSettings.Text = "Settings";
			// 
			// grpRange
			// 
			this.grpRange.Controls.Add(this.btnRange);
			this.grpRange.Controls.Add(this.lblMax);
			this.grpRange.Controls.Add(this.txtRangeMax);
			this.grpRange.Controls.Add(this.lblRangeMin);
			this.grpRange.Controls.Add(this.lblRangeTo);
			this.grpRange.Controls.Add(this.txtRangeMin);
			this.grpRange.Location = new System.Drawing.Point(787, 151);
			this.grpRange.Name = "grpRange";
			this.grpRange.Size = new System.Drawing.Size(200, 100);
			this.grpRange.TabIndex = 8;
			this.grpRange.TabStop = false;
			this.grpRange.Text = "Operand Range";
			// 
			// btnRange
			// 
			this.btnRange.Location = new System.Drawing.Point(119, 71);
			this.btnRange.Name = "btnRange";
			this.btnRange.Size = new System.Drawing.Size(75, 23);
			this.btnRange.TabIndex = 5;
			this.btnRange.Text = "C&hange";
			this.btnRange.UseVisualStyleBackColor = true;
			this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
			// 
			// lblMax
			// 
			this.lblMax.AutoSize = true;
			this.lblMax.Location = new System.Drawing.Point(64, 46);
			this.lblMax.Name = "lblMax";
			this.lblMax.Size = new System.Drawing.Size(27, 13);
			this.lblMax.TabIndex = 4;
			this.lblMax.Text = "max";
			this.lblMax.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtRangeMax
			// 
			this.txtRangeMax.Location = new System.Drawing.Point(66, 21);
			this.txtRangeMax.MaxLength = 2;
			this.txtRangeMax.Name = "txtRangeMax";
			this.txtRangeMax.Size = new System.Drawing.Size(25, 22);
			this.txtRangeMax.TabIndex = 2;
			this.txtRangeMax.Text = "12";
			this.txtRangeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblRangeMin
			// 
			this.lblRangeMin.AutoSize = true;
			this.lblRangeMin.Location = new System.Drawing.Point(6, 46);
			this.lblRangeMin.Name = "lblRangeMin";
			this.lblRangeMin.Size = new System.Drawing.Size(26, 13);
			this.lblRangeMin.TabIndex = 3;
			this.lblRangeMin.Text = "min";
			this.lblRangeMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblRangeTo
			// 
			this.lblRangeTo.AutoSize = true;
			this.lblRangeTo.Location = new System.Drawing.Point(37, 24);
			this.lblRangeTo.Name = "lblRangeTo";
			this.lblRangeTo.Size = new System.Drawing.Size(24, 13);
			this.lblRangeTo.TabIndex = 1;
			this.lblRangeTo.Text = " to ";
			// 
			// txtRangeMin
			// 
			this.txtRangeMin.Location = new System.Drawing.Point(6, 21);
			this.txtRangeMin.MaxLength = 2;
			this.txtRangeMin.Name = "txtRangeMin";
			this.txtRangeMin.Size = new System.Drawing.Size(25, 22);
			this.txtRangeMin.TabIndex = 0;
			this.txtRangeMin.Text = "1";
			this.txtRangeMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// grpTimer
			// 
			this.grpTimer.Controls.Add(this.lblTimer);
			this.grpTimer.Controls.Add(this.btnTimerReset);
			this.grpTimer.Controls.Add(this.chkTimer);
			this.grpTimer.Location = new System.Drawing.Point(787, 267);
			this.grpTimer.Name = "grpTimer";
			this.grpTimer.Size = new System.Drawing.Size(200, 100);
			this.grpTimer.TabIndex = 9;
			this.grpTimer.TabStop = false;
			this.grpTimer.Text = "Timer";
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.ForeColor = System.Drawing.Color.Red;
			this.lblTimer.Location = new System.Drawing.Point(6, 18);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(56, 22);
			this.lblTimer.TabIndex = 13;
			this.lblTimer.Text = "0 sec.";
			// 
			// btnTimerReset
			// 
			this.btnTimerReset.Location = new System.Drawing.Point(119, 71);
			this.btnTimerReset.Name = "btnTimerReset";
			this.btnTimerReset.Size = new System.Drawing.Size(75, 23);
			this.btnTimerReset.TabIndex = 1;
			this.btnTimerReset.Text = "&Reset";
			this.btnTimerReset.UseVisualStyleBackColor = true;
			this.btnTimerReset.Click += new System.EventHandler(this.btnTimerReset_Click);
			// 
			// chkTimer
			// 
			this.chkTimer.AutoSize = true;
			this.chkTimer.Location = new System.Drawing.Point(6, 75);
			this.chkTimer.Name = "chkTimer";
			this.chkTimer.Size = new System.Drawing.Size(72, 17);
			this.chkTimer.TabIndex = 0;
			this.chkTimer.Text = "Timer On";
			this.chkTimer.UseVisualStyleBackColor = true;
			this.chkTimer.CheckedChanged += new System.EventHandler(this.chkTimer_CheckedChanged);
			// 
			// grpStats
			// 
			this.grpStats.Controls.Add(this.lblStat);
			this.grpStats.Controls.Add(this.lblStatLabel);
			this.grpStats.Location = new System.Drawing.Point(787, 383);
			this.grpStats.Name = "grpStats";
			this.grpStats.Size = new System.Drawing.Size(200, 100);
			this.grpStats.TabIndex = 10;
			this.grpStats.TabStop = false;
			this.grpStats.Text = "Statistics";
			// 
			// lblStat
			// 
			this.lblStat.Location = new System.Drawing.Point(79, 18);
			this.lblStat.Name = "lblStat";
			this.lblStat.Size = new System.Drawing.Size(115, 65);
			this.lblStat.TabIndex = 1;
			this.lblStat.Text = "0\r\n0\r\n0\r\n0.0 %\r\n0";
			// 
			// lblStatLabel
			// 
			this.lblStatLabel.AutoSize = true;
			this.lblStatLabel.Location = new System.Drawing.Point(6, 18);
			this.lblStatLabel.Name = "lblStatLabel";
			this.lblStatLabel.Size = new System.Drawing.Size(67, 65);
			this.lblStatLabel.TabIndex = 0;
			this.lblStatLabel.Text = "Incorrect:\r\nCorrect:\r\nAttempted:\r\nPercentage:\r\nStreak:";
			this.lblStatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCheck
			// 
			this.btnCheck.Enabled = false;
			this.btnCheck.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheck.Location = new System.Drawing.Point(396, 122);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(147, 37);
			this.btnCheck.TabIndex = 4;
			this.btnCheck.Text = "Check &Answer";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// lblStart
			// 
			this.lblStart.AutoSize = true;
			this.lblStart.BackColor = System.Drawing.Color.Transparent;
			this.lblStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStart.Location = new System.Drawing.Point(247, 74);
			this.lblStart.Name = "lblStart";
			this.lblStart.Size = new System.Drawing.Size(70, 23);
			this.lblStart.TabIndex = 0;
			this.lblStart.Text = "Start →";
			// 
			// btnResetAll
			// 
			this.btnResetAll.Location = new System.Drawing.Point(6, 71);
			this.btnResetAll.Name = "btnResetAll";
			this.btnResetAll.Size = new System.Drawing.Size(75, 23);
			this.btnResetAll.TabIndex = 11;
			this.btnResetAll.Text = "&Clear";
			this.btnResetAll.UseVisualStyleBackColor = true;
			this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(906, 637);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblProblem
			// 
			this.lblProblem.BackColor = System.Drawing.Color.Transparent;
			this.lblProblem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProblem.Location = new System.Drawing.Point(253, 129);
			this.lblProblem.Name = "lblProblem";
			this.lblProblem.Size = new System.Drawing.Size(81, 23);
			this.lblProblem.TabIndex = 2;
			this.lblProblem.Text = "=";
			this.lblProblem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAnswer
			// 
			this.txtAnswer.Enabled = false;
			this.txtAnswer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer.Location = new System.Drawing.Point(340, 126);
			this.txtAnswer.MaxLength = 4;
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(50, 30);
			this.txtAnswer.TabIndex = 3;
			this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
			// 
			// lblCorrect
			// 
			this.lblCorrect.BackColor = System.Drawing.Color.Transparent;
			this.lblCorrect.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorrect.Location = new System.Drawing.Point(189, 175);
			this.lblCorrect.Name = "lblCorrect";
			this.lblCorrect.Size = new System.Drawing.Size(390, 46);
			this.lblCorrect.TabIndex = 5;
			this.lblCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picWrong
			// 
			this.picWrong.BackColor = System.Drawing.Color.Transparent;
			this.picWrong.Image = global::MATH.Properties.Resources.BowserNote;
			this.picWrong.Location = new System.Drawing.Point(189, 227);
			this.picWrong.Name = "picWrong";
			this.picWrong.Size = new System.Drawing.Size(390, 270);
			this.picWrong.TabIndex = 10;
			this.picWrong.TabStop = false;
			this.picWrong.Visible = false;
			// 
			// picRight
			// 
			this.picRight.BackColor = System.Drawing.Color.Transparent;
			this.picRight.Image = ((System.Drawing.Image)(resources.GetObject("picRight.Image")));
			this.picRight.Location = new System.Drawing.Point(189, 227);
			this.picRight.Name = "picRight";
			this.picRight.Size = new System.Drawing.Size(390, 270);
			this.picRight.TabIndex = 11;
			this.picRight.TabStop = false;
			this.picRight.Visible = false;
			// 
			// tmrMainTimer
			// 
			this.tmrMainTimer.Interval = 1000;
			this.tmrMainTimer.Tick += new System.EventHandler(this.tmrMainTimer_Tick);
			// 
			// grpTeacherControl
			// 
			this.grpTeacherControl.Controls.Add(this.btnLock);
			this.grpTeacherControl.Controls.Add(this.lblPassword);
			this.grpTeacherControl.Controls.Add(this.txtPassword);
			this.grpTeacherControl.Controls.Add(this.btnResetAll);
			this.grpTeacherControl.Location = new System.Drawing.Point(787, 499);
			this.grpTeacherControl.Name = "grpTeacherControl";
			this.grpTeacherControl.Size = new System.Drawing.Size(200, 100);
			this.grpTeacherControl.TabIndex = 13;
			this.grpTeacherControl.TabStop = false;
			this.grpTeacherControl.Text = "Teacher Control";
			// 
			// btnLock
			// 
			this.btnLock.Location = new System.Drawing.Point(119, 71);
			this.btnLock.Name = "btnLock";
			this.btnLock.Size = new System.Drawing.Size(75, 23);
			this.btnLock.TabIndex = 12;
			this.btnLock.Text = "&Lock";
			this.btnLock.UseVisualStyleBackColor = true;
			this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(6, 18);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(56, 13);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(6, 34);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(100, 22);
			this.txtPassword.TabIndex = 0;
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(793, 637);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 23);
			this.btnAbout.TabIndex = 14;
			this.btnAbout.Text = "&About";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// picMario
			// 
			this.picMario.BackColor = System.Drawing.Color.Transparent;
			this.picMario.Image = global::MATH.Properties.Resources.marioGo;
			this.picMario.Location = new System.Drawing.Point(4, 416);
			this.picMario.Name = "picMario";
			this.picMario.Size = new System.Drawing.Size(260, 180);
			this.picMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMario.TabIndex = 15;
			this.picMario.TabStop = false;
			this.picMario.Visible = false;
			this.picMario.Click += new System.EventHandler(this.picMario_Click);
			// 
			// picToad
			// 
			this.picToad.BackColor = System.Drawing.Color.Transparent;
			this.picToad.Image = global::MATH.Properties.Resources.toadGo;
			this.picToad.Location = new System.Drawing.Point(561, 498);
			this.picToad.Name = "picToad";
			this.picToad.Size = new System.Drawing.Size(48, 81);
			this.picToad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picToad.TabIndex = 16;
			this.picToad.TabStop = false;
			this.picToad.Visible = false;
			this.picToad.Click += new System.EventHandler(this.picToad_Click);
			// 
			// picMusic
			// 
			this.picMusic.BackColor = System.Drawing.Color.Transparent;
			this.picMusic.Image = global::MATH.Properties.Resources.musicBox;
			this.picMusic.Location = new System.Drawing.Point(681, 384);
			this.picMusic.Name = "picMusic";
			this.picMusic.Size = new System.Drawing.Size(48, 48);
			this.picMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picMusic.TabIndex = 17;
			this.picMusic.TabStop = false;
			this.picMusic.Visible = false;
			this.picMusic.Click += new System.EventHandler(this.picMusic_Click);
			// 
			// picWinner
			// 
			this.picWinner.BackColor = System.Drawing.Color.Transparent;
			this.picWinner.Image = global::MATH.Properties.Resources.winner;
			this.picWinner.Location = new System.Drawing.Point(0, 381);
			this.picWinner.Name = "picWinner";
			this.picWinner.Size = new System.Drawing.Size(768, 210);
			this.picWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picWinner.TabIndex = 18;
			this.picWinner.TabStop = false;
			this.picWinner.Visible = false;
			// 
			// frmMain
			// 
			this.AcceptButton = this.btnCheck;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::MATH.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CancelButton = this.btnNewProb;
			this.ClientSize = new System.Drawing.Size(995, 667);
			this.Controls.Add(this.picMusic);
			this.Controls.Add(this.picToad);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.grpTeacherControl);
			this.Controls.Add(this.lblStart);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.lblProblem);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.btnNewProb);
			this.Controls.Add(this.picRight);
			this.Controls.Add(this.picWrong);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblCorrect);
			this.Controls.Add(this.grpStats);
			this.Controls.Add(this.grpTimer);
			this.Controls.Add(this.grpRange);
			this.Controls.Add(this.lblSettings);
			this.Controls.Add(this.grpOperation);
			this.Controls.Add(this.picMario);
			this.Controls.Add(this.picWinner);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1015, 710);
			this.MinimumSize = new System.Drawing.Size(1015, 710);
			this.Name = "frmMain";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mario Math 3";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.grpOperation.ResumeLayout(false);
			this.grpOperation.PerformLayout();
			this.grpRange.ResumeLayout(false);
			this.grpRange.PerformLayout();
			this.grpTimer.ResumeLayout(false);
			this.grpTimer.PerformLayout();
			this.grpStats.ResumeLayout(false);
			this.grpStats.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picWrong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
			this.grpTeacherControl.ResumeLayout(false);
			this.grpTeacherControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picToad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMusic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picWinner)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProb;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.RadioButton radMult;
        private System.Windows.Forms.RadioButton radSub;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.GroupBox grpRange;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtRangeMax;
        private System.Windows.Forms.Label lblRangeMin;
        private System.Windows.Forms.Label lblRangeTo;
        private System.Windows.Forms.TextBox txtRangeMin;
        private System.Windows.Forms.GroupBox grpTimer;
        private System.Windows.Forms.Button btnTimerReset;
        private System.Windows.Forms.CheckBox chkTimer;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblStatLabel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.PictureBox picWrong;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Timer tmrMainTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox grpTeacherControl;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.PictureBox picMario;
        public System.Windows.Forms.PictureBox picToad;
        private System.Windows.Forms.PictureBox picMusic;
        private System.Windows.Forms.PictureBox picWinner;
    }
}

