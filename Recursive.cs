using System;

namespace MatrizRecursive
{
    internal class Recursive
    {
        public Recursive()
        {
        }

        public string printMatrixWithFor(int[,] matrix, string result = "")
        {
            //La primera dimension de la matriz o la dimension 0 son las filas
            //La sengunda dimension de la matriz o la dimension 1 son las columnas
            //result += "Primera dimension de la matriz" +matrix.GetLength(0);
            //result += "Segunda dimension de la matriz" + matrix.GetLength(1);

            for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow++)
            {
                for (int indexCol = 0; indexCol < matrix.GetLength(1); indexCol++)
                {
                    result += matrix[indexRow, indexCol] + " ";
                }

                result += "\n";
            }

            return result;
        }

        internal void multiplicateMatrixRecursivily(int[,] matrix, int number, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    multiplicateMatrixRecursivily(matrix, number, indexRow, indexCol);
                }
                else
                {
                    matrix[indexRow, indexCol] = matrix[indexRow, indexCol] * number;
                    indexCol++;
                    multiplicateMatrixRecursivily(matrix, number, indexRow, indexCol);
                }
            }
        }

        public string printMatrixRecursivily(int[,] matrix, int indexRow = 0, int indexCol = 0, string result = "")
        {
            if (indexRow == matrix.GetLength(0))
            {
                return result;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    result += "\n";
                    return printMatrixRecursivily(matrix, indexRow, indexCol, result);
                }
                else
                {
                    result += " " + matrix[indexRow, indexCol];
                    indexCol++;
                    return printMatrixRecursivily(matrix, indexRow, indexCol, result);
                }
            }
        }

        public int[,] GetTransposeOfMatrix(int[,] matrix)
        {
            // Creamos una nueva matriz con los tamanados de la primera matriz pero invertidos
            int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            // Es
            return GetTransposeOfMatrix(matrix, newMatrix);
        }

        // En este metodo llenamos la matriz que ya tiene asignado su tamano
        private int[,] GetTransposeOfMatrix(int[,] matrix, int[,] newMatrix, int indexRow = 0, int indexCol = 0)
        {
            // Condicion para finalizar el bucle
            if (indexRow == matrix.GetLength(0))
            {
                return newMatrix;
            }

            else
            {
                // Cuando acabamos de movernos por las columnas de una fila
                if (indexCol == matrix.GetLength(1))
                {
                    // Cambiamos de fila y nos vamos ala primera columna
                    indexRow++;
                    indexCol = 0;
                    // Nos llamamos recursivamente para efectuar los cambios
                    return GetTransposeOfMatrix(matrix, newMatrix, indexRow, indexCol);
                }
                // Normalmente los procesos se hace dentro del else
                else
                {
                    // Las filas de la nueva matriz se mueven con las columnas de la otra matriz
                    newMatrix[indexCol, indexRow] = matrix[indexRow, indexCol];
                    indexCol++;
                    // Efectuar los cambios
                    return GetTransposeOfMatrix(matrix, newMatrix, indexRow, indexCol);
                }
            }
        }

        public string CheckSquareMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                return "Es cuadrada";
            }
            else
            {
                return "No es cuadrada";
            }
        }

        public double getMatrixAverage(int[,] matrix, double plus = 0, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                double average = plus / (matrix.GetLength(0) * matrix.GetLength(1));
                return average;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return getMatrixAverage(matrix, plus, indexRow, indexCol);
                }
                else
                {
                    plus += matrix[indexRow, indexCol];
                    indexCol++;
                    return getMatrixAverage(matrix, plus, indexRow, indexCol);
                }
            }
        }

        // metodo para hacer un for vertical
        public string getMatrixColumsAverage(int[,] matrix, double plus = 0, string result = "", int indexRow = 0,
            int indexCol = 0)
        {
            // COndicion final
            if (indexCol == matrix.GetLength(1))
            {
                return result;
            }
            else
            {
                if (indexRow == matrix.GetLength(0))
                {
                    result += "Promedio: " + plus / matrix.GetLength(0);
                    plus = 0;
                    indexCol++;
                    indexRow = 0;
                    return getMatrixColumsAverage(matrix, plus, result, indexRow, indexCol);
                }
                else
                {
                    plus += matrix[indexRow, indexCol];
                    indexRow++;
                    return getMatrixColumsAverage(matrix, plus, result, indexRow, indexCol);
                }
            }
        }

        public string GetMatrixRowsAverage(int[,] matrix, double plus = 0, string result = "", int indexRow = 0,
            int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return result;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    result += "Promedio: " + plus / matrix.GetLength(1);
                    plus = 0;
                    indexRow++;
                    indexCol = 0;

                    return GetMatrixRowsAverage(matrix, plus, result, indexRow, indexCol);
                }
                else
                {
                    plus += matrix[indexRow, indexCol];
                    indexCol++;
                    return GetMatrixRowsAverage(matrix, plus, result, indexRow, indexCol);
                }
            }
        }

        public int[,] GetMatrixSum(int[,] matrix, int[,] matrix2)
        {
            if (matrix.GetLength(0) == matrix2.GetLength(0) && (matrix.GetLength(1) == matrix2.GetLength(1)))
            {
                int[,] newMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
                return GetMatrixSum(matrix, matrix2, newMatrix);
            }

            return null;
        }

        public int[,] GetMatrixSum(int[,] matrix, int[,] matrix2, int[,] newmatrix, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == matrix2.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetMatrixSum(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
                else
                {
                    newmatrix[indexRow, indexCol] = matrix[indexRow, indexCol] + matrix2[indexRow, indexCol];
                    indexCol++;
                    return GetMatrixSum(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
            }
        }

        public int[,] GetSubtractionMatrix(int[,] matrix)
        {
            int[,] newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
            return GetSubtractionMatrix(matrix, newMatrix);
        }

        public int[,] GetSubtractionMatrix(int[,] matrix, int[,] newmatrix, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetSubtractionMatrix(matrix, newmatrix, indexRow, indexCol);
                }
                else
                {
                    newmatrix[indexRow, indexCol] = matrix[indexRow, indexCol] - 3;
                    indexCol++;
                    return GetSubtractionMatrix(matrix, newmatrix, indexRow, indexCol);
                }
            }
        }


        public int GetSumMatrix(int[,] matrix, int indexRow = 0, int indexCol = 0, int plus = 0)
        {
            if (matrix.GetLength(0) == indexRow)
            {
                return plus;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetSumMatrix(matrix, indexRow, indexCol, plus);
                }
                else
                {
                    plus += matrix[indexRow, indexCol];
                    indexCol++;
                    return GetSumMatrix(matrix, indexRow, indexCol, plus);
                }
            }
        }

        public int[,] GetMatrixSubtraction(int[,] matrix, int[,] matrix2)
        {
            if (matrix.GetLength(0) == matrix2.GetLength(0) && (matrix.GetLength(1) == matrix2.GetLength(1)))
            {
                int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
                return GetMatrixSubtraction(matrix, matrix2, newmatrix);
            }
            else
            {
                return null;
            }
        }

        public int[,] GetMatrixSubtraction(int[,] matrix, int[,] matrix2, int[,] newmatrix, int indexRow = 0,
            int indexCol = 0)
        {
            if (matrix.GetLength(0) == indexRow)
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetMatrixSubtraction(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
                else
                {
                    newmatrix[indexRow, indexCol] = matrix[indexRow, indexCol] - matrix2[indexRow, indexCol];
                    indexCol++;
                    return GetMatrixSubtraction(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
            }
        }

        public int[,] GetMatrixWithoutRow(int[,] matrix, int row)
        {
            int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
            return GetMatrixWithoutRow(matrix, newMatrix, row);
        }

        public int[,] GetMatrixWithoutRow(int[,] matrix, int[,] newMatrix, int row, int indexRow1 = 0, int indexRow = 0,
            int indexCol = 0)
        {
            if (newMatrix.GetLength(0) == indexRow)
            {
                return newMatrix;
            }
            else
            {
                if (indexCol == newMatrix.GetLength(1))
                {
                    indexRow++;
                    indexRow1++;
                    if (indexRow1 == row)
                    {
                        indexRow1++;
                    }

                    indexCol = 0;
                    return GetMatrixWithoutRow(matrix, newMatrix, row, indexRow1, indexRow, indexCol);
                }
                else
                {
                    newMatrix[indexRow, indexCol] = matrix[indexRow1, indexCol];
                    indexCol++;
                    return GetMatrixWithoutRow(matrix, newMatrix, row, indexRow1, indexRow, indexCol);
                }
            }
        }

        public int[,] GetMultiplicationMatrix(int[,] matrix, int[,] matrix2)
        {
            if (matrix.GetLength(0) == matrix.GetLength(0) && (matrix.GetLength(1) == matrix.GetLength(1)))
            {
                int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
                return GetMultiplicationMatrix(matrix, matrix2, newmatrix);
            }
            else
            {
                return null;
            }
        }

        public int[,] GetMultiplicationMatrix(int[,] matrix, int[,] matrix2, int[,] newmatrix, int indexRow = 0,
            int indexCol = 0)
        {
            if (matrix.GetLength(0) == indexRow)
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetMultiplicationMatrix(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
                else
                {
                    newmatrix[indexRow, indexCol] = matrix[indexRow, indexCol] * matrix2[indexRow, indexCol];
                    indexCol++;
                    return GetMultiplicationMatrix(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
            }
        }

        public int[,] GetParesMatrix(int number)
        {
            int[,] newmatrix = new int[number, number];
            return GetParesMatrix(number, newmatrix);
        }

        private int[,] GetParesMatrix(int number, int[,] newmatrix, int indexRow = 0, int indexCol = 0, int counter = 1)
        {
            if (newmatrix.GetLength(0) == indexRow)
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == newmatrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetParesMatrix(number, newmatrix, indexRow, indexCol, counter);
                }
                else
                {
                    newmatrix[indexRow, indexCol] = counter * 2;
                    indexCol++;

                    return GetParesMatrix(number, newmatrix, indexRow, indexCol, ++counter);
                }
            }
        }


        public int[] GetDeaconalSecundary(int[,] matrix)
        {
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                int[] array = new int [matrix.GetLength(0)];
                return GetDeaconalSecundary(matrix, array);
            }
            else
            {
                return null;
            }
        }

        private int[] GetDeaconalSecundary(int[,] matrix, int[] array, int indexrow = 0)
        {
            if (matrix.GetLength(0) == indexrow)
            {
                return array;
            }
            else
            {
                array[indexrow] = matrix[indexrow, matrix.GetLength(1) - 1 - indexrow];
                indexrow++;
                return GetDeaconalSecundary(matrix, array, indexrow);
            }
        }

        public string printArrayRecursivity(int[] array, int index = 0, string result = "")
        {
            // Se puede usar array.Length solo cuendo es de una dimension.
            if (array.GetLength(0) == index)
            {
                return result;
            }
            else
            {
                result += array[index] + " ";
                index++;
                return printArrayRecursivity(array, index, result);
            }
        }

        public int[] GetDigitNumber(int number)
        {
            string numbers = number.ToString();
            char[] numberarray = numbers.ToCharArray();
            int[] array = new int[numberarray.Length];
            return GetDigitNumber(numberarray, array);
        }

        private int[] GetDigitNumber(char[] numberarray, int[] array, int index = 0)
        {
            if (index == array.Length)
            {
                return array;
            }
            else
            {
                //Caracter a entero convertido
                array[index] = numberarray[index] - '0';
                index++;
                return GetDigitNumber(numberarray, array, index);
            }
        }

        public int[,] GetMatrixWithZero(int[,] matrix)
        {
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
                FillNewMatrix(matrix, newMatrix);
                FillMainDeaconal(matrix, newMatrix);
                FillSecondaryDeaconal(matrix, newMatrix);
                return newMatrix;
            }
            return null;
        }

        private void FillNewMatrix(int[,] matrix, int[,] newMatrix, int indexRow = 0, int indexCol = 0)
        {
            if (newMatrix.GetLength(0) == indexRow)
            {
                return;
            }
            else
            {
                if (indexCol == newMatrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    FillNewMatrix(matrix, newMatrix, indexRow, indexCol);
                }
                else
                {
                    newMatrix[indexRow, indexCol] = matrix[indexRow, indexCol];
                    indexCol++;
                    FillNewMatrix(matrix, newMatrix, indexRow, indexCol);
                }
            }
        }

        private void FillMainDeaconal(int[,] matrix, int[,] newMatrix, int index = 0)
        {
            if (index == matrix.GetLength(0))
            {
                return;
            }
            else
            {
                newMatrix[index, index] = 0;
                index++;
                FillMainDeaconal(matrix,newMatrix,index);
            }
        }
        private void FillSecondaryDeaconal(int[,] matrix, int[,] newMatrix, int index = 0)
        {
            if (index == matrix.GetLength(0))
            {
                return;
            }
            else
            {
                int indexCol = matrix.GetLength(1) - 1 - index; 
                newMatrix[index,  indexCol] = 0;
                index++;
                FillSecondaryDeaconal(matrix,newMatrix,index);
            }
        }

        public int[,] GetDeleteRowOfMatrix(int[,] matrix,int row)
        {
            int[,] newmatrix=new int[matrix.GetLength(0)-1,matrix.GetLength(1)];
            return GetDeleteRowOfMatrix(matrix, newmatrix, row);
        }

        private int[,] GetDeleteRowOfMatrix(int[,] matrix, int[,] newmatrix, int row, int indexRow = 0,
            int indexCol = 0, int indexRow2 = 0)
        {
            if (newmatrix.GetLength(0) == indexRow)
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    indexRow2++;
                    return GetDeleteRowOfMatrix(matrix, newmatrix, row, indexRow, indexCol, indexRow2);
                }
                else
                {
                    if (indexRow2 == row)
                    {
                        indexRow2++;
                    }
                    newmatrix[indexRow, indexCol] = matrix[indexRow2, indexCol];
                    indexCol++;
                    return GetDeleteRowOfMatrix(matrix, newmatrix, row, indexRow, indexCol, indexRow2);
                    
                }
            }
        }

        public int GetMatrixNumber(int[,] matrix,int indexRow=0,int indexCol=0, string result="")
        {
            if (matrix.GetLength(0) == indexRow)
            {
                //convirtiendo en un entero
                //return Convert.ToInt32(result);
                return Int32.Parse(result);
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetMatrixNumber(matrix, indexRow, indexCol, result);
                }
                result += ""+matrix[indexRow,indexCol];
                indexCol++;
                return GetMatrixNumber(matrix, indexRow, indexCol, result);
            }
        }
    }
}