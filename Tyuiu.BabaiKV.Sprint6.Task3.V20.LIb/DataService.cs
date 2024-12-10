using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BabaiKV.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int r = matrix.GetUpperBound(0)+1;
            int c = matrix.Length / r;
            
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (i==4 && matrix[i,j] %2==0)
                    {
                        matrix[i,j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
