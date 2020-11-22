using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gunluk1._0WF.Model
{
    public class Notlar
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        public override string ToString()
        {
            return Baslik;
        }
    }
}
