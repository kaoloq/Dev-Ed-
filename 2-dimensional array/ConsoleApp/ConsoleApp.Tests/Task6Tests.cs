using NUnit.Framework;

namespace ConsoleApp.Tests
{
    public class Task6Tests
    {
        [TestCase(1)]
        [TestCase(2)]
        public void TransposeTest(int MockNumber)
        {
            int[,] array = DoubleArrayMockTask6.GetMock(MockNumber);
            int[,] expected = DoubleArrayMockTask6.GetExpected(MockNumber);

            int[,] actual = Task6.Transpose(array);

          /*  for (int i = 0; i < expected.GetLength(0); i++)
            {
                for (int j = 0; j < expected.GetLength(1); j++) {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }*/
            Assert.AreEqual(expected, actual);
        }
    }

    /*   public struct arrays
       {
           public int[,] arrayToTranspose;
           public int[,] TransposedArray;

       };

       public static class DoubleArrayMockTask6
       {
           public static arrays GetMock(int number)
           {
               arrays result = new arrays[{ {0 },{ 0} }, { }];
               switch (number)
               {
                   case 1:
                       result.arrayToTranspose = new int[,] { { 0, 2, 4, -3, -5 },
                                                              { 4, 7, -19, 2, 3 },
                                                              { 15, 5, 11, 7, -5 } };
                       result.TransposedArray = new int[,] { {0, 4, 15 },
                                                             { 2, 7, 5},
                                                             {4, -19, 11 },
                                                               { -3, 2, 7},
                                                              {-5, 3, -5 } };
                       break;
                   case 2:
                       result.arrayToTranspose = new int[,] { { 3, 9, 10 },
                                             { 2, 36, 2 } };
                       result.TransposedArray = new int[,] { { 3, 2 }, { 9, 36}, { 10, 2} };
                       break;
                   default:
                       break;

               }

               return result;

           }
       }*/

    public static class DoubleArrayMockTask6
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,] { { 0, 2, 4, -3, -5 },
                                                           { 4, 7, -19, 2, 3 },
                                                           { 15, 5, 11, 7, -5 } };
                    break;
                case 2:
                    result = new int[,] { { 3, 9, 10 },
                                          { 2, 36, 2 } };
                    break;
                default:
                    break;

            }

            return result;
        }

        public static int[,] GetExpected(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result= new int[,] { {0, 4, 15 },
                                                          { 2, 7, 5},
                                                          {4, -19, 11 },
                                                            { -3, 2, 7},
                                                           {-5, 3, -5 } };
                    break;
                case 2:
                    result = new int[,] { { 3, 2 }, { 9, 36 }, { 10, 2 } };
                    break;
                default:
                    break;

            }

            return result;
        }

    }
}