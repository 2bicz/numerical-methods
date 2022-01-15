using System;
using System.Drawing;
using System.Windows.Forms;

namespace numerical_methods_Newton
{
    public partial class FormPreload : Form
    {
        public FormPreload()
        {
            InitializeComponent();
        }

        // paski ładowania
        private void timerLoadingScreen_Tick(object sender, EventArgs e)
        {
            panelProgressTop.Width += 5;
            panelProgressBottom.Size = new Size(panelProgressBottom.Width + 5, panelProgressBottom.Height);
            panelProgressBottom.Location = new Point(panelProgressBottom.Location.X - 5, panelProgressBottom.Location.Y);

            if(panelProgressTop.Width >= panelTopLoadBar.Width)
            {
                timerLoadingScreen.Stop();
                FormNewtonMethod formNewton = new FormNewtonMethod();
                formNewton.Show();
                this.Hide();
            }
        }
    }
}
