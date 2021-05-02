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
        public int bookPrice;
        public int bookCount;
        public int x;
    }
    class BorrowDetails
    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        static BorrowDetails borrow = new BorrowDetails();
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
                        Console.Write("Book Price:");
                        book.bookPrice = int.Parse(Console.ReadLine());
                        Console.Write("Number of Books:");
                        book.x = book.bookCount = int.Parse(Console.ReadLine());
                        bookList.Add(book);
                        break;
                    case 2:
                    
                        Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
                        Console.Write("Name :");
                        borrow.userName = Console.ReadLine();
                        Console.Write("Address :");
                        borrow.userAddress = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Enter Student Id ");
                        borrow.userId = int.Parse(Console.ReadLine());
                        Console.Write("Book id :");
                        borrow.borrowBookId = int.Parse(Console.ReadLine());
                        Console.Write("Number of Books : ");
                        borrow.borrowCount = int.Parse(Console.ReadLine());
                        
                        borrow.borrowDate = DateTime.Now;
                        Console.WriteLine("Assigned a book to student Id {0}",borrow.userId);
                        Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

                        if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
                        {
                            foreach (Book searchId in bookList)
                            {
                                if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                                {
                                    if (searchId.bookId == borrow.borrowBookId)
                                    {
                                        searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Only {0} books are found", searchId.bookCount);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
                        }
                        borrowList.Add(borrow);
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
                        Console.WriteLine("the list of books in library:");
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
