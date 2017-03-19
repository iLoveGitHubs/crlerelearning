using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Robotics
{
    public class ImageCreate
    {
        //M hàng, N cột
        //deltaX, deltaY là độ dài của tương ứng của một đơn vị ô vuông
        private int M, N, deltaX, deltaY;
        private int[,] A;

        public ImageCreate(int m, int n, int[,] matrix){
            A = new int[m, n];
            M = m;
            N = n;
            deltaX = 600 / M;
            deltaY = 900 / N;
            for(int i=0;i<M;i++)
                for(int j=0;j<N;j++)
                    A[i,j] = matrix[i,j];
        }

        public ImageCreate()
        {

        }

        public Graphics Draw_Dot_Graphics(int x, int y, int size, Color color, Graphics g)
        {
            Pen p = new Pen(color, size);
            g.DrawEllipse(p, x, y, 1, 1);
            return g;
        }

        public Graphics Draw_Line_Graphics(float x1, float y1, float x2, float y2, int size, Color color, Graphics g)
        {
            Pen p = new Pen(color);
            p.Width = size;
            g.DrawLine(p, x1, y1, x2, y2);
            return g;
        }

        public Graphics Draw_Rangce_Graphics(float x1, float y1, float heigh, float width, Color color, Graphics g)
        {
            SolidBrush b = new SolidBrush(color);
            g.FillRectangle(b, x1, y1, width, heigh);
            return g;
        }

        public Graphics Draw_Bitmap_Graphics(float x, float y, string path, Graphics g)
        {
            Bitmap bitmap = new Bitmap(path);
            g.DrawImage(bitmap, x, y);
            return g;
        }

        public Graphics Draw_String_Graphics(float x, float y, float size, string str, Graphics g)
        {
            Font f = new Font("Times New Roman", size);
            Brush br = new SolidBrush(Color.Blue);
            g.DrawString(str, f, br, x, y);
            return g;
        }

        public void Create(string path)
        {
            Graphics g;
            Bitmap myBitmap = new Bitmap(910, 610, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            g = Graphics.FromImage(myBitmap);
            g.Clear(Color.White);
            //Ve truc toa do Oxy
            for (int i = 0; i <= M; i++)
                Draw_Line_Graphics(5, 5 + i * deltaX, 905, 5 + i * deltaX, 2, Color.Blue, g);
            for (int i = 0; i <= N; i++)
                Draw_Line_Graphics(5 + i * deltaY, 5, 5 + i * deltaY, 605, 2, Color.Blue, g);

            //Ve them chuong ngai vat
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N;j++ )
                {
                    if (A[i, j] == 1)
                    {
                        
                    }
                    else
                        if (A[i, j] == 0)
                        {
                            Draw_Bitmap_Graphics(5 + j * deltaX + 1, 5 + i * deltaY + 1, "gach/gach11.jpg", g);
                        }
                }

            g.Dispose();
            myBitmap.Save(path);
        }
    }
}
