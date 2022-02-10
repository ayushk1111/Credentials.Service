using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Credentials.Service.Models
{
    [Table("ACCOUNTS")]
    public class UserAccount
    {
        [Key]
        [Column("accountID")]
        public int AccountID { get; set; }

        [Column("userID")]
        public int UserID { get; set; }

        [Column("accountName")]
        public string AccountName { get; set; }
    }
}
