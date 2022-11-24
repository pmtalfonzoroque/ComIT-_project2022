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
    [Table("IncomeRecordType")]
    public class IncomeRecordType
    {
        
        public IncomeRecord IncomeRecord { get; set; }

        [Required, ForeignKey("IncomeRecord")]
        public int IncomeRecordId { get; set; }

        public IncomeType IncomeType { get; set; }


        [Required, ForeignKey("IncomeType")]
        public int IncomeTypeId { get; set; }

    }
}
