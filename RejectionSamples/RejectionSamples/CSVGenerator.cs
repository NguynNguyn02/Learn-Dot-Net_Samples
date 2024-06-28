using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RejectionSamples
{
    internal class CSVGenerator<T>
    {
        private IEnumerable<T> _data;
        private string _fileName;
        private Type _type;
        public CSVGenerator(IEnumerable<T> data, string fileName)
        {
            _data = data;
            _fileName = fileName;
            _type = typeof(T);
        }
        public void Generate()
        {
            var rows = new List<String>();
            rows.Add(CreateHeader());

            foreach (var item in _data)
            {
                rows.Add(CreateRow(item));
            }

            File.WriteAllLines($"{_fileName}.csv", rows, Encoding.UTF8);
        }
        public string CreateRow(T item)
        {
            var bod = new StringBuilder();
            var properties = _type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in properties)
            {
                var value = property.GetValue(item);
                bod.Append(value).Append(",");
            }
            
            return bod.ToString()[..^1];
        }
        public string CreateHeader()
        {
            var properties = _type.GetProperties(BindingFlags.Public|BindingFlags.Instance);
            var bod = new StringBuilder();

            foreach (var property in properties)
            {
                var name = property.Name;
                bod.Append(name).Append(",");
            }
            return bod.ToString()[..^1];
        }
    }
}
