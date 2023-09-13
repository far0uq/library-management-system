using LOAS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOAS.Controllers
{
    internal class FineController
    {
        public static void DeleteFine(Fine fine)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(fine);
                if (entry.State == EntityState.Detached)
                    db.Fines.Attach(fine);

                db.Fines.Remove(fine);
                db.SaveChanges();
            }
        }
    }
}
