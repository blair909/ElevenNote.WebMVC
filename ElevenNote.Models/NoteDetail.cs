using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteDetail
    {
        [Display(Name = "Note Id")]
        public int NoteId { get; set; }
        [Display(Name = "Note Title")]
        public string Title { get; set; }
        [Display(Name = "Note Content")]
        public string Content { get; set; }
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
    }
}
