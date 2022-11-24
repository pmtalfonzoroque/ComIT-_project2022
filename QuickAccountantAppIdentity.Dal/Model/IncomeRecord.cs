using QuickAccountantAppIdentity.Dal.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickAccountantAppIdentity.Dal.Model
{
    [Table("IncomeRecord")]
    public class IncomeRecord
    {
        [Required, Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public decimal Total { get; set; }

        public decimal? GST { get; set; } // it can be empty in some cases

        public decimal? PST { get; set; }

        public string? Place { get; set; } // the user can leave the field with not information

        public string? Comment { get; set; }

        [Required]
        public IncomeGroup IncomeGroup { get; set; } // Enum

        [ForeignKey("ExpenseType")]
        public int IncomeTypeID { get; set; } // needed in the create page

        public IncomeType IncomeType { get; set; }


        [Required]
        public PayMethod PayMethod { get; set; } //from the enum - it is a fix entry

        //[Required, ForeignKey("User")]
        //public int UserId { get; set; }

        //public User User { get; set; } // won't be in the database, isn't a field in the database,
        //                               // it's a navigation property to conect to parts

        public List<IncomeRecordType> IncomeRecordType { get; set; } // Navigation property as well (no in the DB),
                                                                     // it is inside C# to read things from other table

    }
}
