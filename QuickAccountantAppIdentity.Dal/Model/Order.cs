using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickAccountantAppIdentity.Dal.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreateDate  { get; set; }

        public decimal Total { get; set; }

        [Required, ForeignKey ("IdentityUser")]
        public int UserId { get; set; }

        public IdentityUser <int> User { get; set; }
    }
}
