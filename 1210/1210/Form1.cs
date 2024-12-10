namespace _1210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            up = down = left = right = false;
            switch (e.KeyCode)
            {

                case Keys.Up:
                    up = true;

                    break;

                case Keys.Down:
                    down = true;

                    break;

                case Keys.Left:
                    left = true;

                    break;

                case Keys.Right:
                    right = true;
                    up = down = left = false;
                    break;
            }

        }
        int speed = 1;
        int score = 0;
        bool[] isp = { false, false, false, false, false, false};
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pac.Location.Y >= 10 && pac.Location.Y <= 230 || pac.Location.X >= 1 && pac.Location.X <= 550)
            {
                if (up)
                {
                    pac.Top -= 1;
                    if (pac.Location.Y < 12) { up = false; }
                }

                if (down)
                {
                    pac.Top += 1;
                    if (pac.Location.Y > 228) { down = false; }
                }

                if (left)
                {
                    pac.Left -= 1;
                    if (pac.Location.X < 3) { left = false; }
                }

                if (right)
                {
                    pac.Left += 1;
                    if (pac.Location.X > 548) { right = false; }
                }

            }

            if (pac.Bounds.IntersectsWith(p0.Bounds))
            {
                p0.Visible = false;
                if (!isp[0])
                {
                    score = score + 20;
                    isp[0] = true;
                }
            }
            if (pac.Bounds.IntersectsWith(p1.Bounds))
            {
                p1.Visible = false;
                if (!isp[1])
                {
                    score = score + 20;
                    isp[1] = true;
                }
            }
            if (pac.Bounds.IntersectsWith(p2.Bounds))
            {
                p2.Visible = false;
                if (!isp[2])
                {
                    score = score + 20;
                    isp[2] = true;
                }
            }
            if (pac.Bounds.IntersectsWith(p3.Bounds))
            {
                p3.Visible = false;
                if (!isp[3])
                {
                    score = score + 20;
                    isp[3] = true;
                }
            }
            if (pac.Bounds.IntersectsWith(p4.Bounds))
            {
                p4.Visible = false;
                if (!isp[4])
                {
                    score = score + 20;
                    isp[4] = true;
                }
            }
            if (pac.Bounds.IntersectsWith(p5.Bounds))
            {
                p5.Visible = false;
                if (!isp[5])
                {
                    score = score + 20;
                    isp[5] = true;
                }
            }


            label1.Text = "Score " + score;
            label2.Text = "X:" + pac.Location.X + "Y:" + pac.Location.Y;



        }
    }
}