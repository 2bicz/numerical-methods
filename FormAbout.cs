using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerical_methods_Newton
{
    public partial class formAbout : Form
    {
        private static formAbout _instance;

        public static formAbout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new formAbout();
                return _instance;
            }
        }

        public formAbout()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonWikipedia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pl.wikipedia.org/wiki/Metoda_Newtona#Opis_metody");
        }

        private void iconButtonGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/2bicz/numerical-methods");
            
        }

        private void iconButtonMxparser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mathparser.org");
        }

        private void userControlAbout_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
            //this.Anchor = AnchorStyles.None;
        }
    }
}
