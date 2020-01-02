using System;

namespace MatrizRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursive r = new Recursive();
            //Declarando matriz
            int[,] matrix = new int[3,3] {
                {3,2,3} ,
                {3,2,3}, 
                {3,2,3}
            };
            int[,] matrix2 = new int[3,2] {
                {3,3},
                {1,1}, 
                {1,1}
            };
            int k = 5;

            int[,] transposeMatrix = r.GetTransposeOfMatrix(matrix2);
            
            int[,] matrix3 = new int[4,4] {
                {3,2,3,5} ,
                {3,2,3,5}, 
                {3,2,3,5},
                {3,2,3,5}
            };
            
            //System.Console.WriteLine(r.printMatrixWithFor(matrix));
            //System.Console.WriteLine(r.printMatrixRecursivily(matrix));
            // r.multiplicateMatrixRecursivily(matrix,k);
            //System.Console.WriteLine(r.printMatrixRecursivily(matrix));
            // System.Console.WriteLine(r.printMatrixRecursivily(transposeMatrix));
            // Console.WriteLine(r.CheckSquareMatrix(matrix));
            // Console.WriteLine(r.getMatrixAverage(matrix));
            //Console.WriteLine(r.getMatrixColumsAverage(matrix));
            //Console.WriteLine(r.GetMatrixRowsAverage(matrix));
            // int[,] newmatrix = r.GetMatrixSum(matrix,matrix3);
            // Console.WriteLine(r.printMatrixRecursivily(newmatrix));
            //
            // int[,] newmatrix = r.GetSubtractionMatrix(matrix);
            // Console.WriteLine(r.printMatrixRecursivily(newmatrix));
            //
            // int [,] newmatrix2 = r.GetMatrixSubtraction(matrix,newmatrix);
            // Console.WriteLine(r.printMatrixRecursivily(newmatrix2));
            //
            //int [,] newmatrix3 = r.GetMatrixWithoutRow(matrix,0);
            //Console.WriteLine(r.printMatrixRecursivily(newmatrix3));
            //
            //int [,] newmatrix4 = r.GetMultiplicationMatrix(matrix,matrix);
            //Console.WriteLine(r.printMatrixRecursivily(newmatrix4));
            //

            // Console.WriteLine(r.printMatrixRecursivily(newmatrix5));

            // int[] newmatrix6 = r.GetDeaconalSecundary(matrix);
            // Console.WriteLine(r.printArrayRecursivity(newmatrix6));
            
            //Examen De Recursividad nivel 3
            // int[] array7 = r.GetDigitNumber(231);
            // Console.WriteLine(r.printArrayRecursivity(array7));

            //int[,] matrix9 = r.GetMatrixWithZero(matrix3);
            //Console.WriteLine(r.printMatrixRecursivily(matrix9));

            // int[,] matrix10 = r.GetDeleteRowOfMatrix(matrix,1);
            // Console.WriteLine(r.printMatrixRecursivily(matrix10));

             int numbers = r.GetMatrixNumber(matrix);
             Console.WriteLine(numbers);


        }
    }
}
