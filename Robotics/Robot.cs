using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Robotics
{
    public partial class Robot : Form
    {
        private int M = 12, N = 18;
        private int[,] A, Deg, F, TruyVet;
        private bool[,] Dinhdoi;
        private bool[,] dded;
        private int[] Hx = { -1, 0, 1, 0 };
        private int[] Hy = { 0, 1, 0, -1 };
        private int deltaX, deltaY;
        private int INDEX = -1;
        private int IndexLoangDatam = 0;
        private int indexPath = 0;

        private Graphics graphics;
        private ImageCreate imageCreate;

        private List<Point> Ngocut = new List<Point>();
        private List<Point> Queue = new List<Point>();
        private List<Point> DuongDi = new List<Point>();
        private List<Point> Path = new List<Point>();

        public Robot()
        {
            InitializeComponent();
            graphics = pictureBoxContent.CreateGraphics();
            A = new int[M, N];
            Deg = new int[M, N];
            F = new int[M, N];
            TruyVet = new int[M, N];
            Dinhdoi = new bool[M, N];
            dded = new bool[M, N];

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = 1;
                    Deg[i, j] = 0;
                    F[i, j] = -1;
                    Dinhdoi[i, j] = false;
                    dded[i, j] = false;
                    TruyVet[i, j] = -1;
                }
            deltaX = 600 / M;
            deltaY = 900 / N;
            PaintMatrix(graphics);
        }

        public void PaintMatrix(Graphics g)
        {
            ImageCreate image = new ImageCreate();
            for (int i = 0; i <= M; i++)
                g = image.Draw_Line_Graphics(5, 5 + i * deltaX, 905, 5 + i * deltaX, 2, Color.Blue, g);
            for (int i = 0; i <= N; i++)
                g = image.Draw_Line_Graphics(5 + i * deltaY, 5, 5 + i * deltaY, 605, 2, Color.Blue, g);
        }

        private void btncreateMap_Click(object sender, EventArgs e)
        {
            PaintMatrix(graphics);
            INDEX = 0;
        }

        private void pictureBoxContent_MouseClick(object sender, MouseEventArgs e)
        {
            if (INDEX == 0)
            {
                ImageCreate image = new ImageCreate();
                int y = (e.X - 5) / deltaY;
                int x = (e.Y - 5) / deltaX;
                if (A[x, y] == 1)
                {
                    A[x, y] = 0;
                    graphics = image.Draw_Rangce_Graphics(5 + y * deltaY + 1, 5 + x * deltaX + 1, deltaY - 2, deltaX - 2, Color.Black, graphics);
                }
                else
                {
                    A[x, y] = 1;
                    graphics = image.Draw_Rangce_Graphics(5 + y * deltaY + 1, 5 + x * deltaX + 1, deltaY - 2, deltaX - 2, Color.White, graphics);
                }
            }
        }

        public void CreateMap()
        {
            imageCreate = new ImageCreate(M, N, A);
            imageCreate.Create("Image/maping.png");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            INDEX = 1;
            CreateMap();
            Image myimage = new Bitmap(@"Image//maping.png");
            pictureBoxContent.BackgroundImage = myimage;
        }

        private bool check(int x, int y)
        {
            if (x < 0 || y < 0 || x >= M || y >= N)
                return false;
            else
                return true;
        }

        // Tinh so lan can
        public void DegNode()
        {
            ImageCreate image = new ImageCreate();
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    if (A[i, j] == 1)
                    {
                        int dem = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            int u = i + Hx[k];
                            int v = j + Hy[k];
                            if (check(u, v) && A[u, v] == 1)
                            {
                                dem++;
                            }
                        }
                        Deg[i, j] = dem;
                    }

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    if (A[i, j] == 1)
                    {
                        graphics = image.Draw_String_Graphics(5 + j * deltaY + 17, 5 + i * deltaX + 15, 14, Deg[i, j] + "", graphics);
                    }

            Thread.Sleep(500);
            //bool check1 = true;
            for (int i = 0; i < M; i++)
                //if (check1)
                    for (int j = 0; j < N; j++)
                        if (Deg[i, j] == 1)
                        {
                            graphics = image.Draw_Bitmap_Graphics(5 + j * deltaY + 1, 5 + i * deltaX + 1, "Image/1532_Flag_system_Blue.png", graphics);
                            Ngocut.Add(new Point(i, j));
                            //check1 = false;
                            //break;
                        }
            Thread.Sleep(500);
        }

        private void btnRuning_Click(object sender, EventArgs e)
        {
            DegNode();
        }

        private void LoangDatam()
        {
            ImageCreate image = new ImageCreate();

            Image myimage = new Bitmap("Image/maping.png");
            graphics.Clear(Color.White);
            graphics = image.Draw_Bitmap_Graphics(0, 0, "Image/maping.png", graphics);
            for (int i = 0; i < Ngocut.Count; i++)
            {
                int x = Ngocut[i].X;
                int y = Ngocut[i].Y;
                graphics = image.Draw_Bitmap_Graphics(5 + y * deltaY + 1, 5 + x * deltaX + 1, "Image/1532_Flag_system_Blue.png", graphics);
            }
            Queue.AddRange(Ngocut);
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    F[i, j] = -1;
            for (int i = 0; i < Ngocut.Count; i++)
            {
                F[Ngocut[i].X, Ngocut[i].Y] = 0;
                graphics = image.Draw_String_Graphics(5 + Ngocut[i].Y * deltaY + 17, 5 + Ngocut[i].X * deltaX + 15, 14, "0", graphics);
            }
            //Bắt đầu loang đa tâm

            int dem = 0;
            while (dem < Queue.Count)
            {
                Point p = Queue[dem];
                int x = p.X;
                int y = p.Y;
                for (int i = 0; i < 4; i++)
                {
                    int u = x + Hx[i];
                    int v = y + Hy[i];
                    if (check(u, v) && A[u, v] == 1 && F[u, v] == -1)
                    {
                        F[u, v] = F[x, y] + 1;
                        Point point = new Point(u, v);
                        Queue.Add(point);
                    }
                }
                dem++;
            }

            //Xác định đồi núi
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {
                    bool cu = true;
                    for (int k = 0; k < 4; k++)
                    {
                        int u = i + Hx[k];
                        int v = j + Hy[k];
                        if ((check(u, v) && F[u, v] > F[i, j] && A[i, j] == 1 && A[u, v] == 1) || A[i, j] == 0)
                            cu = false;
                    }
                    if (cu)
                        Dinhdoi[i, j] = true;
                    else
                        Dinhdoi[i, j] = false;
                }

            //Tìm đường đi, xuất phát từ 1 ô bất kỳ
            //DuongDi.Add(new Point(Ngocut[0].X, Ngocut[0].Y));
            //graphics = image.Draw_Bitmap_Graphics(5 + Ngocut[0].Y * deltaY + 1, 5 + Ngocut[0].X * deltaX + 1, "Image/Robot-48.png", graphics);
        }


        private void radButton1_Click(object sender, EventArgs e)
        {
            LoangDatam();
            timerLoangDaTam.Start();
            IndexLoangDatam = 0;
        }

        private void timerLoangDaTam_Tick(object sender, EventArgs e)
        {
            ImageCreate image = new ImageCreate();
            if (IndexLoangDatam < Queue.Count)
            {
                int u = Queue[IndexLoangDatam].X;
                int v = Queue[IndexLoangDatam].Y;
                if (F[u, v] < 10)
                    graphics = image.Draw_String_Graphics(5 + v * deltaY + 17, 5 + u * deltaX + 15, 14, F[u, v] + "", graphics);
                else
                    if (F[u, v] < 100)
                        graphics = image.Draw_String_Graphics(5 + v * deltaY + 12, 5 + u * deltaX + 15, 14, F[u, v] + "", graphics);
                    else
                        if (F[u, v] < 1000)
                            graphics = image.Draw_String_Graphics(5 + v * deltaY + 7, 5 + u * deltaX + 15, 14, F[u, v] + "", graphics);
                IndexLoangDatam++;
            }
            else
            {
                //In đồi núi
                for (int i = 0; i < M; i++)
                    for (int j = 0; j < N; j++)
                        if (Dinhdoi[i, j])
                        {
                            graphics = image.Draw_Bitmap_Graphics(5 + j * deltaY + 1, 5 + i * deltaX + 1, "Image/flag_red.png", graphics);
                        }
                timerLoangDaTam.Stop();
                KB();
                timerPath.Start();
            }
        }

        private bool check(int x, int y, int m, int n)
        {
            if (x < 0 || y < 0 || x >= m || y >= n)
                return false;
            else
                return true;
        }

        private int BFS(int m, int n, Point p, int[,] a)
        {
            int Sum = 0, index = 0;
            int[,] matrix = new int[m, n];
            List<Point> ListPoint = new List<Point>();
            ListPoint.Add(p);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = 0;
            while (index < ListPoint.Count)
            {
                Point temp = ListPoint[index];
                for (int k = 0; k < 4; k++)
                {
                    int u = temp.X + Hx[k];
                    int v = temp.Y + Hy[k];
                    if (check(u, v, m, n) && matrix[u, v] == 0 && A[u, v] == 1)
                    {
                        ListPoint.Add(new Point(u, v));
                        matrix[u, v] = 1;
                        Sum++;
                    }
                }
                index++;
            }
            return Sum;
        }

        private int RBFS(Point p, int m, int n, int r, int[,] truyvet, int[,] deg)
        {
            int index = 0, tong = 0;
            List<int> sumDeg = new List<int>();
            List<Point> listpoint = new List<Point>();
            listpoint.Add(p);
            sumDeg.Add(0);
            while (index < listpoint.Count && sumDeg[index] < r)
            {
                int x = listpoint[index].X;
                int y = listpoint[index].Y;
                for (int k = 0; k < 4; k++)
                {
                    int u = x + Hx[k];
                    int v = y + Hy[k];
                    if (check(u, v) && truyvet[u, v] == 1)
                    {
                        truyvet[u, v] = 0;
                        listpoint.Add(new Point(u, v));
                        sumDeg.Add(sumDeg[index] + 1);
                    }
                }
                index++;
            }
            for (int i = 0; i < listpoint.Count; i++)
                tong += deg[listpoint[i].X, listpoint[i].Y];
            for (int i = 1; i < listpoint.Count; i++)
                truyvet[listpoint[i].X, listpoint[i].Y] = 1;
            return tong;
        }

        private void KB()
        {
            ImageCreate image = new ImageCreate();
            // Can kiem tra dieu kien Ngo cut
            DuongDi.Add(Ngocut[0]);
            Path.Add(new Point(Ngocut[0].X, Ngocut[0].Y));
            graphics = image.Draw_Bitmap_Graphics(5 + Ngocut[0].Y * deltaY + 1, 5 + Ngocut[0].X * deltaX + 1, "Image/Robot-48.png", graphics);
            TruyVet[Ngocut[0].X, Ngocut[0].Y] = 0;
            int NumberPath = BFS(M, N, DuongDi[0], A);

            int NumberPathed = 0;
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    TruyVet[i, j] = A[i, j];

            while (NumberPathed < NumberPath - 1 && DuongDi.Count > 0)
            {
                Point localtion = new Point(DuongDi[DuongDi.Count - 1].X, DuongDi[DuongDi.Count - 1].Y);
                int x = localtion.X;
                int y = localtion.Y;
                TruyVet[x, y] = 0;
                int dem = 0;
                bool[] c = new bool[5];
                //Đếm xem có bao nhiêu ô có thể đi được dem
                //DisplayArray(M, N, TruyVet);
                for (int k = 0; k < 4; k++)
                {
                    int u = x + Hx[k];
                    int v = y + Hy[k];

                    if (check(u, v) && TruyVet[u, v] == 1)
                    {
                        //Console.WriteLine("u = " + u + " v = " + v + " check = " + check(u, v) + " tv = " + TruyVet[u, v]);
                        dem++;
                        c[k] = true;
                    }
                    else
                    {
                        c[k] = false;
                        /*if (check(u, v))
                            Console.WriteLine("u = " + u + " v = " + v + " check = " + check(u, v) + " tv = " + TruyVet[u, v]);
                        else
                            Console.WriteLine("u = " + u + " v = " + v + " check = " + check(u, v));*/
                    }
                }
                //Console.WriteLine("x = " + x + " y = " + y + "+dem = " + dem);
                //Luật 1: Nếu có duy nhất 1 đường thì đi đường đó
                if (dem == 1)
                {
                    int vt = -1;
                    for (int i = 0; i < 4; i++)
                        if (c[i])
                            vt = i;
                    int u = x + Hx[vt];
                    int v = y + Hy[vt];
                    //Console.WriteLine("u = " + u + " v = " + v);
                    DuongDi.Add(new Point(u, v));
                    Path.Add(new Point(u, v));
                    NumberPathed++;
                    TruyVet[u, v] = 0;
                }
                else
                    if (dem > 1)
                    {
                        //Áp dụng luật 2, chọn ô có giá trị F bé nhất
                        int[] f = new int[5];
                        for (int k = 0; k < 4; k++)
                            if (c[k])
                            {
                                int u = x + Hx[k];
                                int v = y + Hy[k];
                                f[k] = F[u, v];
                            }
                        //Console.WriteLine("f = " + f);
                        int min = 10000;
                        for (int k = 0; k < 4; k++)
                            if (c[k] && f[k] < min)
                                min = f[k];

                        bool[] cmin = new bool[5];
                        for (int k = 0; k < 4; k++)
                            if (c[k] && f[k] == min)
                                cmin[k] = true;

                        int demmin = 0;
                        for (int k = 0; k < 4; k++)
                            if (cmin[k])
                                demmin++;
                        //Console.WriteLine("demmin = " + demmin + " cmin = " + cmin);
                        //Trường hợp chỉ có một ô có giá trị F bé nhất
                        if (demmin == 1)
                        {
                            int vt = -1;
                            for (int i = 0; i < 4; i++)
                                if (cmin[i])
                                    vt = i;
                            int u = x + Hx[vt];
                            int v = y + Hy[vt];
                            //Console.WriteLine("demmin = (1) " + demmin + " u = " + u + " v = " + v);
                            DuongDi.Add(new Point(u, v));
                            Path.Add(new Point(u, v));
                            NumberPathed++;
                            TruyVet[u, v] = 0;
                        }
                        //trường hợp có nhiều ô cùng giá trị F
                        //Xét có phải là đỉnh đồi -> Ưu tiên về đỉnh đồi
                        else
                        {
                            int demdd = 0;
                            for (int k = 0; k < 4; k++)
                                if (cmin[k] && Dinhdoi[x + Hx[k], y + Hy[k]])
                                {
                                    demdd++;
                                }
                            //Console.WriteLine("demdinhdoi = " + demdd);
                            //Nếu chỉ có duy nhất 1 đỉnh đồi thì chọn đỉnh đồi
                            if (demdd == 1)
                            {
                                int vt = -1;
                                for (int i = 0; i < 4; i++)
                                    if (cmin[i] && Dinhdoi[x + Hx[i], y + Hy[i]])
                                        vt = i;
                                int u = x + Hx[vt];
                                int v = y + Hy[vt];
                                //Console.WriteLine("demdinhdoi = " + demdd + " u = " + u + " v = " + v);
                                DuongDi.Add(new Point(u, v));
                                Path.Add(new Point(u, v));
                                NumberPathed++;
                                TruyVet[u, v] = 0;
                            }
                            else
                            //Chọn đỉnh có bậc thấp hơn
                            {
                                int[] ddeg = new int[5];
                                for (int k = 0; k < 4; k++)
                                    if (cmin[k])
                                        ddeg[k] = Deg[x + Hx[k], y + Hy[k]];
                                int mindeg = 1000;
                                int vt = -1;
                                for (int k = 0; k < 4; k++)
                                    if (cmin[k] && ddeg[k] < mindeg)
                                    {
                                        mindeg = ddeg[k];
                                        vt = k;
                                    }
                                int d = 0;
                                for (int k = 0; k < 4; k++)
                                    if (cmin[k] && ddeg[k] == mindeg)
                                        d++;
                                //Console.WriteLine("demdinhdoi = " + demdd + " mindeg = " + mindeg + " d = " + d + " ddeg = " + ddeg);
                                //Chọn đỉnh k là đường đi tiếp theo
                                if (d == 1)
                                {
                                    for (int k = 0; k < 4; k++)
                                        if (cmin[k] && ddeg[k] == mindeg)
                                            vt = k;
                                    int u = x + Hx[vt];
                                    int v = y + Hy[vt];
                                    //Console.WriteLine("Chon duoc 1 dinh doi u = " + u + " v = " + v);
                                    DuongDi.Add(new Point(u, v));
                                    Path.Add(new Point(u, v));
                                    NumberPathed++;
                                    TruyVet[u, v] = 0;
                                }
                                else
                                {
                                    //Console.WriteLine("Truoc");
                                    //DisplayArray(M, N, TruyVet);
                                    int[,] tv = new int[M, N];
                                    tv = TruyVet;
                                    int[] tute = new int[5];
                                    for (int k = 0; k < 4; k++)
                                        if (cmin[k] && ddeg[k] == mindeg)
                                        {
                                            int u = x + Hx[k];
                                            int v = y + Hy[k];
                                            tute[k] = RBFS(new Point(u, v), M, N, 3, tv, Deg);
                                        }
                                    //Console.WriteLine("Sau");
                                    //DisplayArray(M, N, TruyVet);
                                    int minR = 10000;
                                    for (int k = 0; k < 4; k++)
                                        if (cmin[k] && ddeg[k] == mindeg && tute[k] < minR)
                                        {
                                            minR = tute[k];
                                            vt = k;
                                        }
                                    int uu = x + Hx[vt];
                                    int vv = y + Hy[vt];

                                    DuongDi.Add(new Point(uu, vv));
                                    Path.Add(new Point(uu, vv));
                                    //Console.WriteLine("Khong co dinh doi " + tute + " minR = " + minR + " u = " + uu + " vv = " + vv);
                                    NumberPathed++;
                                    TruyVet[uu, vv] = 0;
                                }
                            }
                        }
                    }
                    else
                    //Trường hợp đi vào ngõ cụt -> backtracking
                    {
                        if (DuongDi.Count > 1)
                        {
                            DuongDi = DuongDi.GetRange(0, DuongDi.Count - 1);
                            Path.Add(DuongDi[DuongDi.Count - 1]);
                        }
                        else
                            break;
                    }
            }
        }

        private void timerPath_Tick(object sender, EventArgs e)
        {
            ImageCreate image = new ImageCreate();
            if (indexPath < Path.Count - 1)
            {
                int u = Path[indexPath].X;
                int v = Path[indexPath].Y;
                if (indexPath == 0)
                {
                    image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/robot-48.png", graphics);
                }
                else
                {
                    int ind = Huong_Action(Path[indexPath - 1], Path[indexPath], Path[indexPath + 1]);
                    if (ind == 0)
                    {
                        image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/duoi-phai.png", graphics);
                    }
                    else
                        if (ind == 1)
                        {
                            image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/trai-duoi.png", graphics);
                        }
                        else
                            if (ind == 2)
                            {
                                image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/trai-phai.png", graphics);
                            }
                            else
                                if (ind == 3)
                                {
                                    image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/tren-duoi.png", graphics);
                                }
                                else
                                    if (ind == 4)
                                    {
                                        image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/tren-phai.png", graphics);
                                    }
                                    else
                                        if (ind == 5)
                                        {
                                            image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/tren-trai.png", graphics);
                                        }
                                        else
                                        {
                                            image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/f2.png", graphics);
                                        }
                    
                }
                indexPath++;
            }
            else
            if (indexPath == Path.Count - 1)
            {
                int u = Path[indexPath].X;
                int v = Path[indexPath].Y;
                image.Draw_Bitmap_Graphics(5 + v * deltaX + 1, 5 + u * deltaY + 1, "image/1532_Flag_system_yellow.png", graphics);
            }
            else
                timerPath.Stop();
        }

        //duoi-phai = 0
        //trai-duoi = 1
        //trai-phai = 2
        //tren-duoi = 3
        //tren-phai = 4
        //tren-trai = 5
        private int Huong_Action(Point A, Point B, Point C)
        {
            if ((A.X - B.X == 1 && A.Y == B.Y && B.X == C.X && B.Y - C.Y == -1) || (C.X - B.X == 1 && C.Y == B.Y && B.X == A.X && B.Y - A.Y == -1))
            {
                return 0;
            }
            else
                if ((A.X - B.X == 1 && A.Y == B.Y && B.X == C.X && B.Y - C.Y == 1) || (C.X - B.X == 1 && C.Y == B.Y && B.X == A.X && B.Y - A.Y == 1))
                {
                    return 1;
                }
                else
                    if ((A.X == B.X && B.Y - A.Y == 1 && B.X == C.X && C.Y - B.Y == 1) || (A.X == B.X && B.Y - A.Y == -1 && B.X == C.X && C.Y - B.Y == -1))
                    {
                        return 2;
                    }
                    else
                        if ((A.Y == B.Y && B.X - A.X == 1 && B.Y == C.Y && C.X - B.X == 1) || (A.Y == B.Y && B.X - A.X == -1 && B.Y == C.Y && C.X - B.X == -1))
                        {
                            return 3;
                        }
                        else
                            if ((A.X - B.X == -1 && A.Y == B.Y && B.X == C.X && B.Y - C.Y == -1) || (C.X - B.X == -1 && C.Y == B.Y && B.X == A.X && B.Y - A.Y == -1))
                            {
                                return 4;
                            }
                            else
                                if ((A.X - B.X == -1 && A.Y == B.Y && B.X == C.X && B.Y - C.Y == 1) || (C.X - B.X == -1 && C.Y == B.Y && B.X == A.X && B.Y - A.Y == 1))
                                {
                                    return 5;
                                }
            return -1;
        }
    }
}
