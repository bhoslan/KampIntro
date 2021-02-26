using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        //property-özellik
        //sonu manager, dataAccess vs ile bitiyorsa operasyon tutulur
        public int Id { get; set; }
        public String Adi { get; set; }
        public int Fiyati { get; set; }
        public String Aciklama { get; set; }
        public int stokAdedi { get; set; }
    }
}
