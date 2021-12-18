using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookTrackingProgectMain.Models
{
    public class Books
    {
        [Key]
        public string ISBM { get; set; }

        public string BookTitle { get; set; }
       
        public int Category { get; set; }

        public string BookAuther { get; set; }

     //   public virtual Categorys Categories { get; set; }
    }
}
