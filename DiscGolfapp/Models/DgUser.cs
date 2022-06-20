using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiscGolfapp.Models
{
    public class DgUser
    {
        
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }
        public int Rating { get; set; }
    }
}
