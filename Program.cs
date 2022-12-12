//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*

void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matr[i, j] = rnd.Next(1, 20);
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] Selectionsort(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] < matr[i, k])
                {
                    int temporary = 0;
                    temporary = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temporary;
                }
            }
        }


    }
    return matr;

}
int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
matrix = Selectionsort(matrix);
Console.WriteLine();
PrintMatrix(matrix);
*/ 

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = matr[m, n] = rnd.Next(1, 20);
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write(matr[m, n] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
int min = int.MaxValue;
int index = 0;
for (int m = 0; m < matrix.GetLength(0); m++)
{
    int summ = 0;
    for (int n = 0; n < matrix.GetLength(1); n++)
    {

        summ = summ + matrix[m, n];
    }
    if (summ < min)
    {
        min = summ;
        index++;
    }
}
Console.Write("Наименьшая сумма элементов в строке № ");
Console.WriteLine(index);
*/

//Задача 58:(дополнительно) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int[,] createArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

int[,] fillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    return array;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (var k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

int[,] matrixA = createArray(2, 2);
int[,] matrixB = createArray(2, 2);
matrixA = fillArray(matrixA, 0, 10);
matrixB = fillArray(matrixB, 0, 10);
printArray(matrixA);
Console.WriteLine();
printArray(matrixB);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
printArray(matrixC);
*/ 