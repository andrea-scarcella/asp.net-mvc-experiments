using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Byob.Web.Models
{
    public class PostPreviewVM
    {

        public IEnumerable<string> tags { get; set; }

        public string permalink { get; set; }

        public int commentCount { get; set; }

        public object preview { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime date { get; set; }
    }
}