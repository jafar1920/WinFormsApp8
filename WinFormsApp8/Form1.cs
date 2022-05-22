namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Label label = sender as Label;

            Random random=new Random();

            int x = random.Next(0, 800);
            int y = random.Next(0, 480);

            label.Location = new Point(x, y);
        }
    }
}