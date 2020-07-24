using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainForm : Form
    {
        int width, height,size, bombCount;
        List<(int, int)> openedPositions = new List<(int, int)>();
        Map map;
        bool isFirstClick = true;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isFirstClick)
            {
                isFirstClick = false;
                map.InitializeMap(e.Y, e.X);
            }

            Bitmap canvas = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(canvas);
            Font fnt = new Font("MS UI Gothic", 20);

            OpenAvailableArea((e.Y / size) * size, (e.X / size) * size);
            Console.WriteLine(openedPositions.Count());
            foreach ((int, int) item in openedPositions)
            {
                if (map[item.Item1, item.Item2].IsNumber())
                {
                    g.DrawString($"{map[item.Item1, item.Item2].bombCount}", fnt, Brushes.Black, item.Item2, item.Item1);
                }else if (map[item.Item1, item.Item2].IsNone())
                {
                    g.DrawString($"○", fnt, Brushes.Black, item.Item2, item.Item1);

                }
            }

            /*foreach ((int, int, Cell) item in map.GetPositionCellPair())
            {
                if (item.Item3.IsBomb())
                {
                    g.DrawString($"X", fnt, Brushes.Red, item.Item2, item.Item1);
                }
                else if (item.Item3.IsNumber())
                {
                    g.DrawString($"{item.Item3.bombCount}", fnt, Brushes.Black, item.Item2, item.Item1);
                }
            }*/
            g.Dispose();
            pictureBox1.Image = canvas;

            DrawCell();
            //FillCell(e.X, e.Y);
        }

        private void OpenAvailableArea(int j, int i) {
            
            // 表示するセルをリストに登録して、表示はあとから一括する
            if (!map[j, i].IsBomb())
            {
                if (!openedPositions.Contains((j, i)))
                {
                    openedPositions.Add((j, i));
                }
                //g.DrawString($"{map[j, i].bombCount}", font, Brushes.Black, i, j);
                for (int x=-1; x<=1; x++)
                {
                    for(int y=-1; y<=1; y++)
                    {
                        if(x == 0 && y == 0)
                        {
                            continue;
                        }

                        if((x+y)%2 == 1 && j+y*size < height && 0<= j+y*size && i+x*size < width && 0<= i+x*size)
                        {
                            if (!openedPositions.Contains((j + y*size, i + x*size)))
                            {
                                openedPositions.Add((j + y*size, i + x*size));
                                OpenAvailableArea(j + y*size, i + x*size);
                            }
                        }
                    }
                }
            }
        }

        public MainForm(int height, int width, int size, int bombCount)
        {
            InitializeComponent();
            this.Height = height + 40;
            this.Width = width + 60;
            this.width = width;
            this.height = height;
            pictureBox1.Height = height;
            pictureBox1.Width = width;
            this.size = size;
            this.bombCount = bombCount;
            map = new Map(width, height, size, bombCount);
            DrawCell();

        }

        private void DrawCell()
        {
            int i, j;
            Bitmap canvas;

            if (pictureBox1.Image == null)
            {
                 canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            else
            {
                 canvas = new Bitmap(pictureBox1.Image);
            }
            
            Graphics g = Graphics.FromImage(canvas);

            for(i=0; i<width/size; i++)
            {
                g.DrawLine(Pens.Black, i*size, 0, i*size, Height);
            }

            for (j = 0; j < height/size; j++)
            {
                g.DrawLine(Pens.Black, 0, j*size, Width, j* size);
            }

            g.Dispose();
            pictureBox1.Image = canvas;
        }

        private void FillCell(int x, int y)
        {
            int centerX = (2*(x / size) + 1) * size / 2;
            int centerY = (2*(y / size) + 1) * size / 2;

            Bitmap canvas = new Bitmap(pictureBox1.Image);
            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(Brushes.Red, new Rectangle(centerX - size/2, centerY- size/2, size, size));
            g.Dispose();
            pictureBox1.Image = canvas;
        }
    }
}
