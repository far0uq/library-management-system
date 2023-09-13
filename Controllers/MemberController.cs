using LOAS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOAS.Controllers
{
    internal class MemberController
    {
        public static void AddMember(Member member)
        {
            using (var db = new LibraryEntities())
            {
                db.Members.Add(member);
                db.SaveChanges();
            }
        }

        public static void UpdateMember(Member member)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(member);

                if (entry.State == EntityState.Detached)
                    db.Members.Attach(member);

                db.Entry(member).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static void DeleteMember(Member member)
        {
            using (var db = new LibraryEntities())
            {
                var entry = db.Entry(member);
                if (entry.State == EntityState.Detached)
                    db.Members.Attach(member);

                try { 
                    db.Members.Remove(member);
                    db.SaveChanges();
                    MessageBox.Show("Member Record Successfully Deleted!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("This User has currently issued books. Mark these issues as returned in the issue form before deleting the User.");
                }
            }
        }
    }

}
