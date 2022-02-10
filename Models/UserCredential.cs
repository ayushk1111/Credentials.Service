using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Credentials.Service.Models
{
    [Table("DETAILS")]
    public class UserCredential
    {
        [Key]
        [Column("detailID")]
        public int DetailID { get; set; }

        [Column("accountID")]
        public int AccountID { get; set; }

        [Column("loginID")]
        public string LoginID { get; set; }

        [Column("userPassword")]
        public string Password { get; set; }

        [Column("userPin")]
        public string Pin { get; set; }
    }
}