﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
