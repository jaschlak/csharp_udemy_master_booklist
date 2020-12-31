using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace booklist.Model
{

    // Creating the book model
    public class Book
    {
        // automatically add Id as an identity column
        [Key]        public int Id { get; set; }

        // required, name cannot be null
        [Required]
        public string Name { get; set; }

        public string Author { get; set; }
    }

}