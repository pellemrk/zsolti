using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Enco.Core.Models
{
    public class Team : BaseEntity
    {
        [Required]
        public string Name { get;  set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateFounded { get;  set; }
        [Required]
        public int WCCount { get;  set; }
        public bool FeesPaid { get;  set; }
    }
}
