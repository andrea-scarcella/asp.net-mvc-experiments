using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Byob.Web.Models
{
    public class PostVM
    {
        //[Required(ErrorMessage = "Required")]
        [Required]
        public string title { get; set; }

        [Required]
        public string body { get; set; }

        public IEnumerable<string> tags { get; set; }
    }
}
