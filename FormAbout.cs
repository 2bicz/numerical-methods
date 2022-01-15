using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace numerical_methods_Newton
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void iconButtonWikipedia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pl.wikipedia.org/wiki/Metoda_Newtona");
        }

        private void iconButtonGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/2bicz/numerical-methods");
            
        }

        private void iconButtonMxparser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mathparser.org");
        }
    }
}
