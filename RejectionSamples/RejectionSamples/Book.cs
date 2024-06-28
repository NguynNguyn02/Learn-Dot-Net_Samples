using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RejectionSamples
{
    public enum Rating { Rubbish, Poor, Average, Good, Excellent };
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime DateOfPublication { get; set; }
        public Rating Rating { get; set; }
    }
    public static class Bookdata
    {
        public static IEnumerable<Book> Books = new List<Book>
        {
            new Book {
                Author="Aa",
                Title = "Aa1",
                DateOfPublication=new DateTime(2998, 11, 11),
                Rating=Rating.Excellent
            },
            new Book {
                Author="Ab",
                Title = "Ab1",
                DateOfPublication=new DateTime(3998, 11, 12),
                Rating=Rating.Poor
            },
            new Book {
                Author="Ac",
                Title = "Ac1",
                DateOfPublication=new DateTime(4998, 11, 13),
                Rating=Rating.Good
            },
            new Book {
                Author="Ad",
                Title = "Ad1",
                DateOfPublication=new DateTime(5998, 11, 14),
                Rating=Rating.Average
            }
        };
    }
}
