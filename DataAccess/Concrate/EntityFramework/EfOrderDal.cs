using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {
    }
}
