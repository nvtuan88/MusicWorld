using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class News
    {
        public int NewId { get; set; }
        public string ImageNew { get; set; }

        [Required, StringLength(10000), Display(Name = "Singer Description"), DataType(DataType.MultilineText)]
        public string DescriptionNew { get; set; }

    }
}
