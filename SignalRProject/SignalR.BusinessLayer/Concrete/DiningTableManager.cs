using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class DiningTableManager : IDiningTableService
    {
        private readonly IDiningTableDal _diningTableDal;

        public DiningTableManager(IDiningTableDal diningTableDal)
        {
            _diningTableDal = diningTableDal;
        }

        public void TAdd(DiningTable entity)
        {
            _diningTableDal.Add(entity);
        }

        public void TChangeDiningTableStatusToFalse(int id)
        {
            _diningTableDal.ChangeDiningTableStatusToFalse(id);
        }

        public void TChangeDiningTableStatusToTrue(int id)
        {
            _diningTableDal.ChangeDiningTableStatusToTrue(id);
        }

        public void TDelete(DiningTable entity)
        {
           _diningTableDal.Delete(entity);
        }

        public int TDiningTableCount()
        {
            return _diningTableDal.DiningTableCount();
        }

        public DiningTable TGetByID(int id)
        {
            return _diningTableDal.GetByID(id);
        }

        public List<DiningTable> TGetListAll()
        {
           return _diningTableDal.GetListAll();
        }

        public void TUpdate(DiningTable entity)
        {
          _diningTableDal.Update(entity);   
        }
    }
}
