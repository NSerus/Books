using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
