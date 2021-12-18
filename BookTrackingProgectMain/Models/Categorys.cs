using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingProgectMain.Models
{
    public class Categorys
    {
        [Key]
        public string NameToken { get; set; }

       // [ForeignKey("CategoryType")]
        public int Type { get; set; }

        public string BookDescription { get; set; }

     //   public virtual CategorysType CategoryType { get; set; }
    }
}
