using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Book
    {
        public int bookId;
        public string bookName;
        public string bookAuthor;
        public int bookCount;
        public int x;
    }
    class StudentDetails
    {
        public int studentId;
        public string studentName;
        public string studentAddress;
        
    }
    class AssignBook
    {
        public int assignBookId;
        public DateTime assignDate;
        public int assignBookCount;
    }


    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<StudentDetails> studentList = new List<StudentDetails>();
        static List<AssignBook> assignbook = new List<AssignBook>();
        static Book book = new Book();
        static StudentDetails studentdetails = new StudentDetails();
        static AssignBook ab = new AssignBook();
        public static string userChoice;
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Library Management System\n");
            do
            {
                Console.WriteLine("1.Add a book  \n 2. Add Student \n 3. Assign a Book \n 4.Return the Book \n 5. Display Book List \n 6. Display Students List");
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                     
                        Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
                        Console.Write("Book Name:");
                        book.bookName = Console.ReadLine();
                        Console.Write("Book Author:");
                        book.bookAuthor = Console.ReadLine();
                        Console.Write("Number of Books:");
                        book.x = book.bookCount = int.Parse(Console.ReadLine());
                        bookList.Add(book);
                        break;
                    case 2:
                    
                        Console.WriteLine("User id : {0}", (studentdetails.studentId = studentList.Count + 1));
                        Console.Write("Name :");
                        studentdetails.studentName = Console.ReadLine();
                        Console.Write("Address :");
                        studentdetails.studentAddress = Console.ReadLine();
                        studentList.Add(studentdetails);
                        break;

                    case 3:
                        Console.WriteLine("Enter Student Id ");
                        studentdetails.studentId = int.Parse(Console.ReadLine());
                        Console.Write("Book id :");
                        ab.assignBookId = int.Parse(Console.ReadLine());
                        Console.Write("Number of Books : ");
                        ab.assignBookCount = int.Parse(Console.ReadLine());
                        
                        ab.assignDate = DateTime.Now;
                        Console.WriteLine("Assigned a book to student Id {0}", studentdetails.studentId);
                        Console.WriteLine("Date - {0} and Time - {1}", ab.assignDate.ToShortDateString(), ab.assignDate.ToShortTimeString());
                        
                        break;

                    case 4:
                      
                        Console.WriteLine("Enter following details :");

                        Console.Write("Book id : ");
                        int returnId = int.Parse(Console.ReadLine());

                        Console.Write("Number of Books:");
                        int returnCount = int.Parse(Console.ReadLine());

                        if (bookList.Exists(y => y.bookId == returnId))
                        {
                            foreach (Book addReturnBookCount in bookList)
                            {
                                if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                                {
                                    if (addReturnBookCount.bookId == returnId)
                                    {
                                        addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                                        Console.WriteLine("Book is returned");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Book already Returned");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book id {0} not found", returnId);
                        }

                        break;

                    case 5:
                        Console.WriteLine("The list of books in library:");
                        foreach (Book b in bookList )
                        {
                            Console.WriteLine("Book Title: {0}", b.bookName);
                            Console.WriteLine("Book Id: {0}", b.bookId);
                           
                        }
                        break;


                    default:
                        Console.WriteLine("your choice was invaild {0} Enter Valid Operation", userInput);
                        break;

                }
                do
                {
                    Console.WriteLine("Do you want to Continue YES or NO");
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
