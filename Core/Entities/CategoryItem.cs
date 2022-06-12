using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    internal class CategoryItem
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
