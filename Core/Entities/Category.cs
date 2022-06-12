using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    internal class Category
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [Display(Name ="Category")]
        public string Name { get; set; }
        [Required]
        public string Decription { get; set; }
        public DateTime OperationDate { get; set; } = DateTime.Now;
    }
}
