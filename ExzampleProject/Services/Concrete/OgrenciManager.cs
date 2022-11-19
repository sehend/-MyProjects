using Core.Model;
using Data.Abstract;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class OgrenciManager : IOgrenciService
    {
        IOgrenciDal _ogrenciDal;

        public OgrenciManager(IOgrenciDal aboutDal)
        {
            _ogrenciDal = aboutDal;
        }

        public void TAdd(Ogrenci t)
        {
            _ogrenciDal.Insert(t);
        }

        public void TDelete(Ogrenci t)
        {
            _ogrenciDal.Delete(t);
        }

        public Ogrenci TGetById(int id)
        {
            return _ogrenciDal.GetById(id);


        }

        public List<Ogrenci> TGetList()
        {
            return _ogrenciDal.GetList();
        }

        public void TUpdate(Ogrenci t)
        {
            _ogrenciDal.Update(t);
        }
    }
}
