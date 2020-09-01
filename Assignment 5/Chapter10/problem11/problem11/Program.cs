using System;
using System.Collections.Generic;

namespace problem11
{
    class Program
    {
        static int ROW = 9;
        static int COL = 10;
        public static void Main(String[] args)
        {
            int[,] mat = {{ 1, 0, 1, 1, 1, 1, 0, 1, 1, 1 },
                  { 1, 0, 1, 0, 1, 1, 1, 0, 1, 1 },
                   { 1, 1, 1, 0, 1, 1, 0, 1, 0, 1 },
                  { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                  { 1, 1, 1, 0, 1, 1, 1, 0, 1, 0 },
                  { 1, 0, 1, 1, 1, 1, 0, 1, 0, 0 },
                  { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                  { 1, 0, 1, 1, 1, 1, 0, 1, 1, 1 },
                  { 1, 1, 0, 0, 0, 0, 1, 0, 0, 1 }};
            Point source = new Point(0, 0);
            Point dest = new Point(3, 4);
            int dist = BFS(mat, source, dest);
            if (dist != int.MaxValue)
                Console.WriteLine("Shortest Path is " + dist);
            else
                Console.WriteLine("Shortest Path doesn't exist");
        }
        public class Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        };
        public class QueueNode
        {
            public Point pt;
            public int dist;
            public QueueNode(Point pt, int dist)
            {
                this.pt = pt;
                this.dist = dist;
            }
        }; 
        static bool isValid(int row, int col)
        {
            return (row >= 0) && (row < ROW) &&
                   (col >= 0) && (col < COL);
        } 
        static int[] rowNum = { -1, 0, 0, 1 };
        static int[] colNum = { 0, -1, 1, 0 }; 
        static int BFS(int[,] mat, Point src, Point dest)
        {
            if (mat[src.x, src.y] != 1 ||
                mat[dest.x, dest.y] != 1)
                return -1;
            bool[,] visited = new bool[ROW, COL];
            visited[src.x, src.y] = true;
            Queue<QueueNode> q = new Queue<QueueNode>();
            QueueNode s = new QueueNode(src, 0);
            q.Enqueue(s); 
            while (q.Count != 0)
            {
                QueueNode curr = q.Peek();
                Point pt = curr.pt;
                if (pt.x == dest.x && pt.y == dest.y)
                    return curr.dist; 
                q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int row = pt.x + rowNum[i];
                    int col = pt.y + colNum[i]; 
                    if (isValid(row, col) &&
                            mat[row, col] == 1 &&
                       !visited[row, col])
                    { 
                        visited[row, col] = true;
                        QueueNode Adjcell = new QueueNode(new Point(row, col), curr.dist + 1);
                        q.Enqueue(Adjcell);
                    }
                }
            } 
            return -1;
        } 
    }
}
