using DataAccess.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfImageFileDal : GenericRepository<ImageFile>, IImageFileDal
    {
    }
}
