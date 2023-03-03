using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_cam4del.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required(ErrorMessage ="Please enter a movie title")]
        public string title { get; set; }
        [Required(ErrorMessage = "Please enter a valid year")]
        public int year { get; set; }
        [Required(ErrorMessage = "Please enter a director name")]
        public string director { get; set; }
        [Required(ErrorMessage = "Please enter a movie rating")]
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lent_to { get; set; }
        [MaxLength(25)]
        public string notes { get; set; }

        //Build foreign key relationship
        [Required(ErrorMessage = "Please enter a movie category")]
        public int CategoryID { get; set; }
        [Required]
        public Category CategoryName { get; set; }
    }
}
