using LOAS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOAS.Controllers
{
    internal class CopyController
    {
        public static void AddCopy(Copy copy)
        {
            using (var db = new LibraryEntities())
            {
                db.Copies.Add(copy);
                db.SaveChanges();
            }
        }

        public static void UpdateCopy(Copy copy)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(copy);

                if (entry.State == EntityState.Detached)
                    db.Copies.Attach(copy);

                db.Entry(copy).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void DeleteCopy(Copy copy)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(copy);
                if (entry.State == EntityState.Detached)
                    db.Copies.Attach(copy);

                db.Copies.Remove(copy);
                db.SaveChanges();
            }
        }
    }
}
