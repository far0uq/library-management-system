using LOAS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LOAS.Models.Book;

namespace LOAS.Controllers
{
    internal class CatalogController
    {
        public static void AddBook(Book book)
        {
            using (var db = new LibraryEntities())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }
        public static void AddAuthor(Author author)
        {
            using (var db = new LibraryEntities())
            {
                db.Authors.Add(author);
                db.SaveChanges();
            }
        }

        public static void UpdateBook(Book book)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(book);

                if (entry.State == EntityState.Detached)
                    db.Books.Attach(book);

                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool CheckISBN(string isbnToCheck)
        {
            var db = new LibraryEntities();
            var books = (from book in db.Books

                        select new
                        {
                            isbn = book.isbn,
                            book_name = book.book_name,
                            book_category = book.book_category
                        }).ToList();
            
            foreach (var bookInBooks in books)
            {
                if (bookInBooks.isbn.ToString() == isbnToCheck)
                    return true;
            }
            return false;
        }
        public static void DeleteBook(Book book)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(book);
                if (entry.State == EntityState.Detached)
                    db.Books.Attach(book);

                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        public static void EraseCompletely(Book book)
        {
            using (var db = new LibraryEntities())
            {
                var copies = (from copy in db.Copies

                             select new
                             {
                                 copy_id = copy.copy_id,
                                 issued_in = copy.issued_in,
                                 book_number = copy.book_number
                             }).ToList();

                var issues = (from issue in db.Issues
                              select new
                              {
                                  issue_number = issue.issue_number
                              }).ToList();
                foreach(var copy in copies)
                {
                    if(copy.book_number == book.isbn)
                    {
                        foreach(var issue in issues)
                        {
                            if (copy.issued_in == issue.issue_number)
                            {

                            }
                        }
                        DeleteCopy(copy);
                    }
                }
                DeleteBook(book);
            }
        }
    }
}
