using System;

class MatrixUI
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 1;
        matrix1[0, 1] = 3;
        matrix1[1, 1] = -12;

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 1] = 2;
        matrix2[1, 0] = -5;
        matrix2[1, 1] = 24;

        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("Sum");
        Console.Write(sum.ToString());

        Matrix subtraction = matrix1 - matrix2;
        Console.WriteLine("Subtraction");
        Console.Write(subtraction.ToString());

        Matrix multiplication = matrix1 * matrix2;
        Console.WriteLine("Multiplication");
        Console.Write(multiplication.ToString());
    }
}
