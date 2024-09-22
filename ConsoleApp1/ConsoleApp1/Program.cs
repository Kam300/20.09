using System;

public class TwoDimensionalArray
{
    private double[,] array;
    private int rows;
    private int cols;

    public TwoDimensionalArray(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        array = new double[rows, cols];
    }

    public void FillArray()
    {
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                array[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    public void PrintArray()
    {
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public TwoDimensionalArray Add(TwoDimensionalArray other)
    {
        TwoDimensionalArray result = new TwoDimensionalArray(rows, cols);
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                result.array[i, j] = this.array[i, j] + other.array[i, j];
            }
        }
        return result;
    }

    public TwoDimensionalArray MultiplyByScalar(double scalar)
    {
        TwoDimensionalArray result = new TwoDimensionalArray(rows, cols);
        for (int i = 0; i < rows; ++i)
        {
            for (int j = 0; j < cols; ++j)
            {
                result.array[i, j] = this.array[i, j] * scalar;
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int n = Convert.ToInt32(Console.ReadLine());

        TwoDimensionalArray matrix1 = new TwoDimensionalArray(m, n);
        matrix1.FillArray();
        matrix1.PrintArray();

        TwoDimensionalArray matrix2 = new TwoDimensionalArray(m, n);
        matrix2.FillArray();
        matrix2.PrintArray();

        TwoDimensionalArray sumMatrix = matrix1.Add(matrix2);
        Console.WriteLine("Результат сложения:");
        sumMatrix.PrintArray();

        Console.Write("Введите коэффициент для умножения: ");
        double scalar = Convert.ToDouble(Console.ReadLine());
        TwoDimensionalArray scaledMatrix = matrix1.MultiplyByScalar(scalar);
        Console.WriteLine($"Результат умножения матрицы на {scalar}:");
        scaledMatrix.PrintArray();

        Console.ReadKey();
    }
}
