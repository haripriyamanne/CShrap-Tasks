using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        public static void Main()
        {
            int row1, column1, row2, column2, i, j, k, sum = 0;
            string userChoice;

            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] c = new int[10, 10];

            Console.WriteLine("Enter the Size Rows and Columns of 1st Matrix:");
            Console.WriteLine("Enter the Row Size: ");
            row1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Column Size: ");
            column1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Size of Rows and Columns of 2nd Matrix:");
            Console.WriteLine("Enter the Row Size: ");
            row2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Column Size: ");
            column2 = int.Parse(Console.ReadLine());


            Console.Write("Enter the Elements of 1st matrix :\n");
            for (i = 0; i < row1; i++)
            {
                for (j = 0; j < column1; j++)
                {
                    Console.Write("Number - [{0}],[{1}] : ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("Enter the Elements of 2nd matrix :\n");
            for (i = 0; i < row2; i++)
            {
                for (j = 0; j < column2; j++)
                {
                    Console.Write("Numbert - [{0}],[{1}] : ", i, j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\nThe 1st matrix Elements are :\n");
            for (i = 0; i < row1; i++)
            {
                Console.Write("\n");
                for (j = 0; j < column1; j++)
                    Console.Write("{0}\t", a[i, j]);
            }

            Console.Write("\nThe 2nd matrix Elements are :\n");
            for (i = 0; i < row2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < column2; j++)
                    Console.Write("{0}\t", b[i, j]);
            }

            do
            {
                Console.WriteLine("\nselect Which Operation to Perform 1-Addition 2-Multiplication 3-Subtraction");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        if (row1 != column1 && row2 != column2)
                        {
                            Console.WriteLine("Addition of Matrix is not possible.");
                            Console.WriteLine("Size of Rows and columns must be same.");
                        }
                        else
                        {
                            /* sum of the Matrix */
                            for (i = 0; i < row1; i++)
                                for (j = 0; j < column1; j++)
                                    c[i, j] = a[i, j] + b[i, j];
                            Console.WriteLine("The Addition of two matrix is : ");
                            for (i = 0; i < row2; i++)
                            {
                                Console.Write("\n");
                                for (j = 0; j < column2; j++)
                                    Console.Write("{0}\t", c[i, j]);
                            }
                  
                        }
                        break;

                    case 2:

                        if (column1 != row2)
                        {
                            Console.WriteLine("Mutiplication of Matrix is not possible.");
                            Console.WriteLine("Column of first matrix and row of second matrix must be same.");
                        }
                        else
                        {
                            // Multiplication of Matix
                            for (i = 0; i < row1; i++)
                                for (j = 0; j < column2; j++)
                                    c[i, j] = 0;
                            for (i = 0; i < row1; i++)    //row of first matrix
                            {
                                for (j = 0; j < column2; j++)    //column of second matrix
                                {
                                    sum = 0;
                                    for (k = 0; k < column1; k++)
                                        sum = sum + a[i, k] * b[k, j];
                                    c[i, j] = sum;
                                }
                            }
                            Console.WriteLine("The multiplication of two matrix is : ");
                            for (i = 0; i < row1; i++)
                            {
                                Console.Write("\n");
                                for (j = 0; j < column2; j++)
                                {
                                    Console.Write("{0}\t", c[i, j]);
                                }
                            }
                          
                        }
                        break;


                    case 3:
                        if (row1 != column1 && row2 != column2)
                        {
                            Console.WriteLine("Subtraction of Matrix is not possible.");
                            Console.WriteLine("Size of Rows and columns must be same.");
                        }
                        else
                        {
                            /* Subtraction of the Matrix */
                            for (i = 0; i < column1; i++)
                                for (j = 0; j < row1; j++)
                                    c[i, j] = a[i, j] - b[i, j];
                            Console.WriteLine("The Subtraction of two matrix is : ");
                            for (i = 0; i < column2; i++)
                            {
                                Console.Write("\n");
                                for (j = 0; j < row2; j++)
                                    Console.Write("{0}\t", c[i, j]);
                            }
                           
                        }
                        break;
                    default:
                        Console.WriteLine("your choice was invaild {0} Enter Valid Operation", userInput);
                        break;
                }
                do
                {
                    Console.WriteLine("Do you want to Perform another Operation YES or NO");
                    userChoice = Console.ReadLine().ToLower();
                    if (userChoice != "yes" && userChoice != "no")
                    {
                        Console.WriteLine("Please enter vaild choice");
                    }
                } while (userChoice != "yes" && userChoice != "no");
            } while (userChoice == "yes");
        }
    }
}

