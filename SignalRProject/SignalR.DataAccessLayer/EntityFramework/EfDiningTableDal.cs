using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfDiningTableDal : GenericRepository<DiningTable>, IDiningTableDal
    {
        public EfDiningTableDal(SignalRContext context) : base(context)
        {
        }

        public void ChangeDiningTableStatusToFalse(int id)
        {
            using var context = new SignalRContext();
            var value = context.DiningTables.Where(x => x.DiningTableID == id).FirstOrDefault();
            value.Status = false;
            context.SaveChanges();
        }

        public void ChangeDiningTableStatusToTrue(int id)
        {
            using var context = new SignalRContext();
            var value = context.DiningTables.Where(x => x.DiningTableID == id).FirstOrDefault();
            value.Status = true;
            context.SaveChanges();
        }

        public int DiningTableCount()
        {
            using var context = new SignalRContext();
            return context.DiningTables.Count();
        }
    }
}
