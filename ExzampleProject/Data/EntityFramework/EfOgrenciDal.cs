using Core.Model;
using Data.Abstract;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFramework
{
    public class EfOgrenciDal : GenericRepository<Ogrenci>, IOgrenciDal
    {
    }
}
