namespace Aplicacion
{
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;
            }
        }
        private static int c;
        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            if (c == 10)
            {
                this.Opacity--;
                if (this.Opacity == 0)
                {
                    this.Close();
                }
            }
        }
    }
}