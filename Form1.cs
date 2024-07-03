namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void FirstLine(int x, int y, double a, double b, Pen p)
        {
            g.DrawLine(p, x, y, (int)Math.Round(x + a * Math.Cos(b)), (int)Math.Round(y - a * Math.Sin(b)));
        }

        private void Draw(int x, int y, double a, double b, int order)
        {
            if (a > 1 && order > 0)
            {
                Pen p = new Pen(Color.Green);
                FirstLine(x, y, a, b, p);
                int newX = (int)Math.Round(x + a * Math.Cos(b));
                int newY = (int)Math.Round(y - a * Math.Sin(b));
                Draw(newX, newY, a * 0.4, b - 14 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.4, b + 14 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.4, b + 14 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.7, b + Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.3, b - 20 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.3, b + 20 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.2, b + 20 * Math.PI / 30, order - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int order;
            int length;
            if (!int.TryParse(Order.Text, out order))
            {
                MessageBox.Show("The order variable must be a number");
                return;
            }
            if (!int.TryParse(Length.Text, out length))
            {
                MessageBox.Show("The length variable must be a number");
                return;
            }
            Draw(pictureBox1.Width / 2, pictureBox1.Height, length, Math.PI / 2, order);
        }
    }
}
