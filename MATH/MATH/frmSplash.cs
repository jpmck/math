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
    public partial class frmSplash : Form
    {
        private SoundPlayer player;
        
        public frmSplash()
        {
            InitializeComponent();
        }

        /* Close the form                                           */
        private void picBoxInvisible_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Play the intro sound on load                      */
        private void frmSplash_Load(object sender, EventArgs e)
        {
            player = new SoundPlayer();
            player.Stream = Properties.Resources.sm64Mario;
            player.Play();
        }
    }
}
