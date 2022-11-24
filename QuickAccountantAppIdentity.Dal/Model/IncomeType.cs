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
    [Table("IncomeType")]
    public class IncomeType // A list of type of income will be included by default and the user can add more
    {
        [Required, Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int DisplayOrder { get; set; }


        public List<IncomeRecordType> IncomeRecordType { get; set; } //Navigation property, isn't a filed in the DB
    }
}
