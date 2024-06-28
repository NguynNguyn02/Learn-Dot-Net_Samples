using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample2
{
    [DBMoTa("Lop chua thong tin ve user tren he thong")]
    public class User
    {
        [DBMoTa("Ten nguoi dung")]
        public string Name { get; set; }
        [DBMoTa("Du lieu tuoi")]

        public int Age { get; set; }
        [DBMoTa("Du lieu so dien thoai")]
        public string PhoneNumber { get; set; }
        [DBMoTa("Du lieu email")]
        public string Email { get; set; }
    }
}
