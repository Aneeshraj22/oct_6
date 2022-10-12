using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace October_6.Models
{
    public class Productmodel
    {
        [Required()]
        public int Proid { get; set; }

        [MaxLength(20, ErrorMessage = "Name cannot be greater than 20 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 character")]
        public string Proname { get; set; }

        public int Qty { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Mfgdate
        {
            get;
            set;
        }

    }
}
