using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IDiningTableService:IGenericService<DiningTable>
    {
        public int TDiningTableCount();
        void TChangeDiningTableStatusToTrue(int id);
        void TChangeDiningTableStatusToFalse(int id);
    }
}
