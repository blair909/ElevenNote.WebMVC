using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteEdit
    {
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Note Title")]
        public string Title { get; set; }
        [MaxLength(8000, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Note Content")]
        public string Content { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset ModifiedUtc {get;set;}
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
    }
}
