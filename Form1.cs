namespace PW_LAB_4
{
    //Program usuwa tylko DOKLADNIE zielone i czarne kolory
    //Na githubie zalaczylem obraz do testow
    public partial class Form1 : Form
    {
        int width;
        int height;
        Bitmap bit2;
        public Form1()
        {
            InitializeComponent();
            width = height = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                pictureBox1.Image = bit;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                width = bit.Width;
                height = bit.Height;
                bit2 = bit;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int y = 0; y < height;y++)
            {
                for(int x = 0; x < width;x++)
                {
                    Color p = bit2.GetPixel(x,y);
                    if(!( p.B == 0 && p.R ==0 && p.G == 0))
                    {
                        bit2.SetPixel(x,y,Color.FromArgb(1,255,255,255));
                    }
                }
            }
            pictureBox1.Image = bit2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bit2.GetPixel(x, y);
                    if (p.B == 0 && p.R == 0 && p.G == 255)
                    {
                        bit2.SetPixel(x, y, Color.FromArgb(1, 255, 255, 255));
                    }
                }
            }
            pictureBox1.Image = bit2;
        }
    }
    
}