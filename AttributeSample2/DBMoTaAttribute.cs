using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample2
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method|AttributeTargets.Property)]
    public class DBMoTaAttribute:Attribute
    {
        public string thongTinChiTiet {  get; set; }
        public DBMoTaAttribute(string _thongTinChiTiet)
        {
            thongTinChiTiet = _thongTinChiTiet;
        }

    }
}
