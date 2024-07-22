using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void AnnouncementStatusToFalse(int id)
        {
            Announcement p = new Announcement();
            using var context = new AgricultureContext();
            p = context.Announcements.Find(id);
            p.Status = false;
            context.SaveChanges(); 
        }

        public void AnnouncementStatusToTrue(int id)
        {
            Announcement p = new Announcement();
            using var context = new AgricultureContext();
            p = context.Announcements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
