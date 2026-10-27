using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G03_EF01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public String ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public String PublishedYear { get; set; }
        public bool InStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; } = default!;
    }
}
