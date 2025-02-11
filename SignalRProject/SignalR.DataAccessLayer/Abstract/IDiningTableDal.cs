using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IDiningTableDal:IGenericDal<DiningTable>
    {
        public int DiningTableCount();
        void ChangeDiningTableStatusToTrue(int id);
        void ChangeDiningTableStatusToFalse(int id);
    }
}
