using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [StringLength(512)]
        public string Title { get; set; }
    }
}
