using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.Entities
{
    [Table("User")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }

        [Column("emailaddress")]
        public string EmailAddress { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("phonenumber")]
        public string PhoneNumber { get; set; }

        [Column("usertype")]
        public string UserType { get; set; }

        [Column("userimage")]
        public string UserImage { get; set; } = "";

        [Column("createddate")]
        public DateTime CreatedDate { get; set; }

        [Column("modifieddate")]
        public DateTime ModifiedDate { get; set; }

        [Column("isdeleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
