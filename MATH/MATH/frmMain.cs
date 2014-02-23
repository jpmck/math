/*
Program by James McKenna

PURPOSE:    Create a Windows application using Visual C# that will test fourth grade students
            on basic math problems, and that will keep track of their progress.

ALGORITHM:
            New Problem Button
             * Generate a new problem using two random numbers, then set student up with
               appropriate form controls to answer the problem (answer text box and Check
               Answer button).
               - Use IF/ELSE IF to determine type of operation, and minimum and maximum
                 variables to determine problem type, and set answer variable for later
                 use.
               - Prep the form appropriately to allow for answer input (enable/disable/
                 hide/show appropriate objects).  -{Using CheckClearing() method}-

            Answer Button
             * Check student's answer/guess against answer variable established during New
               Problem button coding.  Give feedback and update appropriate stats for grades.
               - Use TryParse to catch bad input.
               - Use IF/ELSE IF to determine action needed for answer vs. guess.
               - Prep form in same fashion as New Problem button (enable/disable, etc.).
                 -{Using NewProbClearing() method()}-
               - Update stats for right/wrong/total/percent and show on form.

            Clear Button
             * Do actions to clear the form for new user, by resetting all appropraite objects
               and variables.
               - Use CheckClearing() and NewProbClearing() methods to do some of clearing.
               - Manually clear out other objects as needed and reset variables as needed.

            Exit Button
             * Prompt user if they wish to exit the program, and allow them to do so if OK.

McKENNA'S BONUS STUFF:
             * There are a lot, and I'm not listing them all!
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MATH
{
    public partial class frmMain : Form
    {
        // Create new object from Media class
        private SoundPlayer player;
        
        public frmMain()
        {
            InitializeComponent();
        }

        /* Declare variables needed  for multiple events     */
        int randMin = 0,    // min num for random num generator
            randMax = 13,   // max  "   "    "     "     "
            answer,         // answer to problem
            rightStat,      // number correctly answered
            wrongStat,      // number wrong answers
            timer,          // number for timer
            streak;         // number for streak
        decimal percent;    // number used for percentage
        bool locked = false,// lock for teacher control
             rightStreak = false,   // on a right streak?
             wrongStreak = false;   // on a wrong streak?
        string password;    // password for teacher control

        // Create new object from Random class
        Random RandomGenerator = new Random();

        // Create new forms
        frmSplash Splasher = new frmSplash();
        frmMusic Music = new frmMusic();
        frmToadGame Toad = new frmToadGame();
        

        /* Generate a new math problem.                        */
        private void btnNewProb_Click(object sender, EventArgs e)
        {
            // Set "random variables" to next random num with Random object
            int randX = RandomGenerator.Next(randMin, randMax);
            int randY = RandomGenerator.Next(randMin, randMax);
            
            // If Addition radio button is checked...
            if (radAdd.Checked)
            {
                // Set answer for addition problem and output question to Problem label
                answer = randX + randY;
                lblProblem.Text = randX.ToString() + " + " + randY.ToString() + " =";
            }

            // Else if Subtraction radio button is checked...
            else if (radSub.Checked)
            {
                // If first random number is larger, use "regular" order...
                if (randX > randY)
                {
                    // Set answer for subtraction problem and output question to Problem label
                    answer = randX - randY;
                    lblProblem.Text = randX.ToString() + " - " + randY.ToString() + " =";
                }

                // Else if second random number is larger, use "reverse" order...
                else if (randY > randX)
                {
                    // Set answer for subtraction problem and output question to Problem label
                    answer = randY - randX;
                    lblProblem.Text = randY.ToString() + " - " + randX.ToString() + " =";
                }
            }

            // Else if Mutiplication radio button is checked...
            else if (radMult.Checked)
            {
                // Set answer for multiplication problem and output question to Problem label
                answer = randX * randY;
                lblProblem.Text = randX.ToString() + " \x00D7 " + randY.ToString() + " =";
            }

            // Set focus on Answer textbox and enable it (reenabled after first problem done)
            txtAnswer.Enabled = true;
            txtAnswer.Clear();
            txtAnswer.Focus();

            // Clears stuff for a new problem
            NewProbClearing();

            // Disable "New Problem" button (no cheating by looking for an easier problem)
            btnNewProb.Enabled = false;

            // Enable Answer textbox and hide start hint
            txtAnswer.Enabled = true;
            lblStart.Hide();

            player = new SoundPlayer();
            player.Stream = Properties.Resources.sndLevelClear;
            player.Play();

        }

        /* Enable Check button.                                     */
        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
        }

        /* Check answer versus program's answer.             */
        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Declare variable for student's guess/answer            
            int guess;

            // Create a new SoundPlayer
            player = new SoundPlayer();

            // If Answer textbox text string parses...
            if (int.TryParse(txtAnswer.Text, out guess))
            {

                // If answer is correct...
                if (guess == answer)
                {
                    // Give "positive" output and picture, and increase right answer stat
                    lblCorrect.Text = "Right!\n" + lblProblem.Text + " " + answer.ToString("N0");
                    lblCorrect.ForeColor = System.Drawing.Color.Green;
                    picRight.Show();
                    rightStat++;

                    //player = new SoundPlayer();
                    player.Stream = Properties.Resources.sndThreeCards;
                    player.Play();

                    /* Next set of lines control the "streak" for how many right or wrong */
                    // If neither a right streak or wrong steak (form defaults)...
                    if (rightStreak == false && wrongStreak == false)
                    {
                        rightStreak = true;
                        wrongStreak = false;
                    }
                    
                    // If on a right streak... 
                    if (rightStreak)
                    {
                        // Increase streak number and ensure not a wrong streak
                        streak++;
                        wrongStreak = false;
                    }

                    // Else if on a right streak... 
                    else if (wrongStreak)
                    {
                        // Set streak number to 1 and switch streak from right to wrong
                        streak = 1;
                        wrongStreak = false;
                        rightStreak = true;
                    }
                }

                // Else if answer is wrong...
                else
                {
                    // Give "negative" output and picture, and increase wrong answer stat
                    lblCorrect.Text = "Wrong!\n" + lblProblem.Text + " " + answer.ToString("N0");
                    lblCorrect.ForeColor = System.Drawing.Color.Red;
                    picWrong.Show();
                    wrongStat++;

                    //player = new SoundPlayer();
                    player.Stream = Properties.Resources.sndDeath;
                    player.Play();

                    /* Next set of lines control the "streak" for how many right or wrong */
                    // If neither a right streak or wrong steak (form defaults)...
                    if (rightStreak == false && wrongStreak == false)
                    {
                        rightStreak = true;
                        wrongStreak = false;
                    }

                    // If on a wrong streak... 
                    if (wrongStreak)
                    {
                        // Increase streak number and ensure not a right streak
                        streak++;
                        rightStreak = false;
                    }
                    
                    // Else if on a right streak... 
                    else if (rightStreak)
                    {
                        // Set streak number to 1 and switch streak from right to wrong
                        streak = 1;
                        rightStreak = false;
                        wrongStreak = true;
                    }
                }

                // Calculate percentage right and prep form for new problem
                percent = (decimal)rightStat / (rightStat + wrongStat);
                CheckClearing();

                // if a right streak of 5, congratulate them
                if (rightStreak == true & streak == 5 & picWinner.Visible == false)
                {
                    lblCorrect.Text = "5 in a row!  Good job, pizano!\n" + lblProblem.Text + " " + answer.ToString("N0");
                    picMario.Show();
                }

                // if a right streak of 10, congratulate them
                else if (rightStreak == true & streak == 10 & picToad.Visible == false & picWinner.Visible == false)
                {
                    lblCorrect.Text = "10 in a row!  Hey, there's Toad!\n" + lblProblem.Text + " " + answer.ToString("N0");
                    picToad.Show();
                }

                // if they go through 20 problems and have an "A" grade, congratulate them
                else if ((rightStat + wrongStat) == 20 & percent > .9m & picWinner.Visible == false)
                {
                    lblCorrect.Text = "20 problems and you got " + (percent * 100).ToString("N0") + "% right!  A music box appears!\n" + lblProblem.Text + " " + answer.ToString("N0");
                    picMusic.Show();
                }

                // if they got the last one right, they've done 25 or more problems, they have an "A", and they haven't already won, then they win!
                else if (rightStreak == true & (rightStat + wrongStat) >= 25 & percent > .9m & picWinner.Visible == false)
                {
                    lblCorrect.Text = "You saved the Princess!  (You can keep playing if you want.)\n" + lblProblem.Text + " " + answer.ToString("N0");
                    picWinner.Show();
                    picMario.Hide();
                    picToad.Hide();
                    picMusic.Hide();
                    picWrong.Hide();
                    picRight.Hide();

                    player.Stream = Properties.Resources.sndWinner;
                    player.Play();
                }
            }
            
            // Else if Answer textbox text string does not parse...
            else
            {
                // Throw error, clear bogus entry, refocus on Answer textbox
                lblCorrect.ForeColor = System.Drawing.Color.Red;
                lblCorrect.Text = "\x0022" + txtAnswer.Text + "\x0022 isn't a number!\nPlease enter a number for your answer.";
                txtAnswer.Clear();
                txtAnswer.Focus();
                btnCheck.Enabled = false;
            }
        }

        /* Set operand range.                                */
        private void btnRange_Click(object sender, EventArgs e)
        {
            // If RangeMin and RangeMax textbox texts are parsable...
            if (int.TryParse(txtRangeMin.Text, out randMin) && int.TryParse(txtRangeMax.Text, out randMax))
            {
                // If max and min are reversed.
                if (randMin > randMax)
                {
                    // "Correct" values by reversing, throw warning and fix input boxes
                    int randTemp = randMin;     // false "min" in temp storage
                    randMin = randMax;      // false "max" moved to min... now correct
                    randMax = randTemp;     // correct "max" moved from temp to max... now correct
                    MessageBox.Show(txtRangeMin.Text + " cannot be the minimum value if " + txtRangeMax.Text + " is the maximum!\n" +
                        txtRangeMax.Text + " and " + txtRangeMin.Text + " set as minimum and maximum operand values.",
                        "Min/Max Corrected and Set", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRangeMin.Text = randMin.ToString();
                    txtRangeMax.Text = randTemp.ToString();
                }

                // Else give confirmation of new max and mins
                else MessageBox.Show(txtRangeMin.Text + " and " + txtRangeMax.Text + " set as minimum and maximum operand values.",
                        "Min/Max Set", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // (to up "max" to requested max number)
                randMax++;      
            }

            else
            {
                // Throw error and undo invalid entry
                MessageBox.Show("Either \x0022" + txtRangeMin.Text + "\x0022 or \x0022" + txtRangeMax.Text +
                    "\x0022 is not a number.\nPlease enter whole numbers as the minimum and maximum operands.",
                   "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRangeMin.Undo();
                txtRangeMax.Undo();
            }
        }
        
        /* Starts and stops the timer                                 */
        private void chkTimer_CheckedChanged(object sender, EventArgs e)
        {
            // If it's checked start it...
            if (chkTimer.Checked) tmrMainTimer.Enabled = true;
            
            // Else, stop it
            else tmrMainTimer.Enabled = false;
        }
        
        /* Increments timer and increments timer label          */
        private void tmrMainTimer_Tick(object sender, EventArgs e)
        {
            // Change the label each tick, and increment timer variable
            lblTimer.Text = (++timer).ToString("N0") + " sec.";
        }

        /* Reset the timer                                        */
        private void btnTimerReset_Click(object sender, EventArgs e)
        {
            // Perform timer clearing method
            TimerClearing();
        }

        /*Locks or unlocks the settings                     */
        private void btnLock_Click(object sender, EventArgs e)
        {
            // if boolean value locked is true...
            if (locked)
            {
                // try to unlock...
                // if password matches, unlock teacher controls
                if (password == txtPassword.Text)
                {
                    // throw confirmation, set bool locked as false, clear password box                    
                    MessageBox.Show("Settings unlocked.  Please use a new password to relock the settings.",
                        "Settings Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    locked = false;
                    txtPassword.Clear();
                    
                    // enable settings controls
                    grpOperation.Enabled = true;
                    grpRange.Enabled = true;
                    grpTimer.Enabled = true;
                    btnResetAll.Enabled = true;

                    btnLock.Text = "Lock";
                    txtPassword.Focus();
                }
                
                // else, tell them password doesn't match
                else
                {
                    // throw error, clear entry and refocus
                    MessageBox.Show("Invalid password entered.  Please re-enter password to unlock settings.",
                        "Settings Locked", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }

            // else if (locked is false) ...
            else
            {
                // catch null strings as passwords                
                if (txtPassword.Text.Length == 0)
                {
                    // Throw error and refocus on password box
                    MessageBox.Show("You cannot have a blank password.",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }

                // set password string and lock out teacher controls
                else
                {
                    // set password string
                    password = txtPassword.Text;
                    
                    // throw confirmation that password is set, and clear password box
                    MessageBox.Show("New password accepted.  Settings will now be locked.  Please remember password!",
                       "Settings Locked", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPassword.Clear();
                    
                    // set boolean locked to true
                    locked = true;

                    // lock out the form by disabling settings controls
                    grpOperation.Enabled = false;
                    grpRange.Enabled = false;
                    grpTimer.Enabled = false;
                    btnResetAll.Enabled = false;

                    btnLock.Text = "Unlock";
                    txtPassword.Focus();
                }
            }

        }
        
        /* Resets the entire form                               */
        private void btnResetAll_Click(object sender, EventArgs e)
        {
            // Clear appropriate values for variables
            randMin = 0;
            randMax = 13;
            rightStat = 0;
            wrongStat = 0;
            percent = 0;
            timer = 0;
            streak = 0;
            rightStreak = false;
            wrongStreak = false;

            // Revert to Addition as default operation
            radAdd.Checked = true;

            //Reset what's shown in min/max option boxes
            txtRangeMin.Text = "0";
            txtRangeMax.Text = "12";

            // Reset timer
            TimerClearing();
                                    
            // Prep form for new question and redo start label
            CheckClearing();
            NewProbClearing();
            lblProblem.Text = "=";
            lblStart.Show();
            txtAnswer.Clear();
            btnCheck.Enabled = false;   // * See below...

            /* Needs to be done again if txtAnswer_TextChanged triggers btnCheck as enabled
             * even though method is already called in CheckClearing method... ?  Weird...  */

            // hide all pictures for unlocked bonuses
            picMario.Hide();
            picToad.Hide();
            picMusic.Hide();
            picWinner.Hide();

            // Append steak to 0
            lblStat.Text += "\n0";
        }

        /* Shows the "About" form                            */
        private void btnAbout_Click(object sender, EventArgs e)
        {
            // create a new instance of the About form and show it
            frmAbout AboutBox = new frmAbout();
            AboutBox.Show();
        }

        /* Exits the form but asks first                    */
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Create a dialog asking if they want to quit
            DialogResult ExitResult = MessageBox.Show("Are you sure you want to quit?",
                       "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            // if they quit, thank them for a playing your game!
            if (ExitResult == DialogResult.Yes)
            {
                player = new SoundPlayer();
                player.Stream = Properties.Resources.sm64_thank_you;
                player.Play();

                // sleep for as long as the sound plays so you can hear it...
                System.Threading.Thread.Sleep(2250);
                // then close the form
                this.Close();
            }
        }

        /* Clears info after clicking "Check" */
        private void CheckClearing()
        {
            // Disable "Check Answer" button and Answer textbox
            btnCheck.Enabled = false;
            txtAnswer.Enabled = false;

            // Reenable "New Problem" button and focus on it
            btnNewProb.Enabled = true;
            btnNewProb.Focus();

            // Update student stats
            lblStat.Text = wrongStat.ToString() + "\n" + rightStat.ToString() + "\n" +
                (rightStat + wrongStat).ToString() + "\n" + percent.ToString("P1");
            if (rightStreak) lblStat.Text += "\n" + streak.ToString() + " correct";
            if (wrongStreak) lblStat.Text += "\n" + streak.ToString() + " incorrect";
        }

        /* Clear info after clicking "New Problem" */
        private void NewProbClearing()
        {
            // Hide any "Right/Wrong" pictures and answers
            picRight.Hide();
            picWrong.Hide();
            lblCorrect.Text = "";

            // disable check button
            btnCheck.Enabled = false;
        }

        /* Clears timer info as needed */
        private void TimerClearing()
        {
            // Disable time, uncheck the box, and reset timer label
            tmrMainTimer.Enabled = false;
            chkTimer.Checked = false;
            lblTimer.Text = "0 sec.";
        }

        /* Make the toad game form appear                   */
        private void picToad_Click(object sender, EventArgs e)
        {
            // create a new instance of the Toad Game form and show it
            Toad.Show();
        }

        /* Make the music player form appear                 */
        private void picMusic_Click(object sender, EventArgs e)
        {
            // create a new instance of the Music form and show it            
            Music.Show();
        }

        /* On load, make the Splash screen form show       */
        private void frmMain_Load(object sender, EventArgs e)
        {
            // create a new instance of the Splash form and show it
            Splasher.ShowDialog();
        }

        private void picMario_Click(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.sndTail;
            player.Play();
        }
    }
}
