using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using EntityLayer.Concrete;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public List<Admin> GetAll()
        {
            return _adminDal.List();
        }

        public Admin GetById(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public void Add(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void Update(Admin admin)
        {
            _adminDal.Update(admin);
        }

        public void Delete(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }

}

