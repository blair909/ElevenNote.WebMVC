using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Category Content")]
        public string CategoryContent { get; set; }
    }
}
