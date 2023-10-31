
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        int[,] arr1 = { { 53, 5 }, 
                         { 3, 25 } };

        int[,] arr2 = { { 11, 6 }, 
                         { 7, 8 } };

        Matrix matrix1 = new Matrix(arr1);
        Matrix matrix2 = new Matrix(arr2);

        Matrix result_sum = matrix1 + matrix2;
        Matrix result_subtraction = matrix1 - matrix2;
        Matrix result_multiplication = matrix1 * matrix2;

        Console.WriteLine("Matrix1:");
        Console.WriteLine(matrix1);

        Console.WriteLine("Matrix2:");
        Console.WriteLine(matrix2);

        Console.WriteLine("Sum:");
        Console.WriteLine(result_sum);

        Console.WriteLine("Subtraction:");
        Console.WriteLine(result_subtraction);

        Console.WriteLine("Multiplication:");
        Console.WriteLine(result_multiplication);

        
    }

}
class Matrix
{
    private int[,] data;

    public int Rows { 
          
        get { return data.GetLength(0); }
    }
    public int Cols {

        get { return data.GetLength(1); }

    }


    public Matrix(int[,] data)
    {
        this.data = data;
        
    }


    public static Matrix operator + (Matrix matrix1,Matrix matrix2)
    {
        int[,] result = new int[matrix1.Rows, matrix2.Cols];

        for (int i = 0; i < matrix1.Rows; i++)
        {
            
            for (int j = 0; j < matrix1.Cols; j++)
            {
                
                result[i, j] = matrix1.data[i, j] + matrix2.data[i, j];
            }
            
        }
        return new Matrix(result);
    }
    public static Matrix operator - (Matrix matrix1, Matrix matrix2)
    {
        int[,] result = new int[matrix1.Rows, matrix2.Cols];

        for (int i = 0; i < matrix1.Rows; i++)
        {

            for (int j = 0; j < matrix1.Cols; j++)
            {

                result[i, j] = matrix1.data[i, j] - matrix2.data[i, j];
            }

        }
        return new Matrix(result);
    }
    public static Matrix operator *(Matrix matrix1, Matrix matrix2)
    {

        int[,] result = new int[matrix1.Rows, matrix2.Cols];
        
        for (int i = 0; i < matrix1.Rows; i++)
        {

            for (int j = 0; j < matrix2.Cols; j++)
            {
                 //result[i, j] = 0; 
                
                for (int k = 0; k < matrix1.Cols; k++)
                {

                    result[i, j] += matrix1.data[i, k] * matrix2.data[k, j];
                }
                
            }

        }
        return new Matrix(result);


    }




    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < Rows; i++)
        {
            
            for (int j = 0; j < Cols; j++)
            {
                
                result.Append($"{data[i, j]} ");
            }
            result.AppendLine();
        }
        return result.ToString();
    }




}

