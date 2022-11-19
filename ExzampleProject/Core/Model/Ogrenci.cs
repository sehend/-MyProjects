using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Ogrenci
    {
        public int Id { get; set; }

        public string? AdSoyad { get; set; }

        public int? BolumId { get; set; }

        public string? Bolum { get; set; }

        public string? Hobiler { get; set; }

        public string? SınıfOgretmeni { get; set; }

        public string? RehberOgretmen { get; set; }


    }
}
