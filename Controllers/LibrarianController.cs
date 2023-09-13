using LOAS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOAS.Controller
{
    internal class LibrarianController
    {
        public static void AddLibrarian(Librarian librarian)
        {
            using (var db = new LibraryEntities())
            {
                db.Librarians.Add(librarian);
                db.SaveChanges();
            }
        }

        public static void UpdateLibrarian(Librarian librarian)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(librarian);

                if (entry.State == EntityState.Detached)
                    db.Librarians.Attach(librarian);

                db.Entry(librarian).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void DeleteLibrarian(Librarian librarian)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(librarian);
                if (entry.State == EntityState.Detached)
                    db.Librarians.Attach(librarian);

                db.Librarians.Remove(librarian);
                db.SaveChanges();
            }
        }

    }
}
