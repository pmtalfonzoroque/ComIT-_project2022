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
    [Table("ExpenseType")]
    public class ExpenseType // this is the list that the user will see by default and also the user can add more fields
    {
        [Required,Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int DisplayOrder { get; set; }
               
        
        public List<ExpenseRecordType> ExpenseRecordType { get; set; } // navigation property, it is not in the DB,
                                                                       // it is only in C# to read from other tables


    }
}
