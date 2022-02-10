using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Credentials.Service.Models
{
    [Table("USERS")]
    public class User
    {
        [Key]
        [Column("userID")]
        public int UserID { get; set; }

        [Column("userName")]
        public int UserName { get; set; }

        [Column("DOB")]
        public DateTime DOB { get; set; }
    }
}
