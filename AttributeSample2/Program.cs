using System.Reflection;

namespace AttributeSample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int[] b = { 1, 2, 3 };
            var t = a.GetType();
            Console.WriteLine(t);
            var y = b.GetType();
            Console.WriteLine(y);
            // type and use type
            /* int a = 1;
            int[] b = { 1, 2, 3 };
            var t = a.GetType();
            Console.WriteLine(t);
            var y = b.GetType();
            Console.WriteLine(y);

            Console.WriteLine("----------thuoc tinh--------");
            y.GetProperties().ToList().ForEach(
                (PropertyInfo p) =>
                Console.WriteLine(p.Name)
                );

            Console.WriteLine("----------truong du lieu--------");
            y.GetFields().ToList().ForEach(
                (FieldInfo p) => Console.WriteLine(p.Name)
                );

            Console.WriteLine("----------cac phuong thuc--------");
            y.GetMethods().ToList().ForEach(
                (MethodInfo p ) => Console.WriteLine(p.Name)
                
                );

            Console.WriteLine("----------cac Menber ----------");
            y.GetMembers().ToList().ForEach(y => Console.WriteLine(y.Name));
            */


            User user = new User()
            {
                Name = "Nguyen",
                Age = 22,
                Email = "nguyengation@gmail.com",
                PhoneNumber = "51568864"
            };
            var properties = user.GetType().GetProperties().ToList();
            //foreach (PropertyInfo property in properties)
            //{
            //    var name = property.Name;
            //    var value = property.GetValue(user);
            //    Console.WriteLine($"{name} : {value}");
            //}

            foreach (PropertyInfo property in properties)
            {
                foreach (var attr in property.GetCustomAttributes(false))
                {
                    DBMoTaAttribute mota = (DBMoTaAttribute)attr;//attr as DBMoTaAttribute
                    if (mota != null)
                    {
                        var name = property.Name;
                        var value = property.GetValue(user);
                        Console.WriteLine($"{mota.thongTinChiTiet} : {name} : {value} ");
                    }
                }
            }
        }
    }
}
