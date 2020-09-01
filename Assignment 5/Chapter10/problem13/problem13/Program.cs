using System;

namespace problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 0, 3, 0, 1 }, { 3, 0, 3, 3 }, { 2, 3, 3, 3 }, { 0, 3, 3, 3 } };
            IsPath(matrix, 4);
        }
        public static void IsPath( int[,] matrix, int n)
        {
            bool[,] visited = new bool[n, n];
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (
                        matrix[i,j] == 1 && !visited[i, j]) 
                        if (IsPath(
                                matrix, i, j, visited))
                        {
                            flag = true;
                            break;
                        }
                }
            }
            if (flag)
                Console.WriteLine("YES");
        else
                Console.WriteLine("NO");
        }
        public static bool IsSafe( int i, int j, int[,] matrix)
        {
            if (
                i >= 0 && i < matrix.Length && j >= 0 && j < matrix.Length)
                return true;
            return false;
        } 
        public static bool IsPath(int[,] matrix, int i, int j, bool[,] visited)
        { 
            if (
                IsSafe(i, j, matrix)
                && matrix[i,j] != 0
                && !visited[i,j])
            { 
                visited[i,j] = true; 
                if (matrix[i,j] == 2)
                    return true;
                bool up = IsPath(matrix, i - 1, j, visited);
                if (up)
                    return true; 
                bool left = IsPath(matrix, i, j - 1, visited); 
                if (left)
                    return true;
                bool down = IsPath(matrix, i + 1, j, visited);
                if (down)
                    return true; 
                bool right = IsPath(matrix, i, j + 1, visited);
                if (right)
                    return true;
            }
            return false;
        }
    }
}
