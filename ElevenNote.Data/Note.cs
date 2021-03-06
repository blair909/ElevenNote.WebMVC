﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [Required]
        public Guid NoteOwnerId { get; set; }
        [Required]
        [Display(Name = "Note Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Note Content")]
        public string Content { get; set; }
        [Required]
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
