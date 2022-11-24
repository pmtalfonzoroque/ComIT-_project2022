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
    [Table("ExpenseRecordType")]
    public class ExpenseRecordType
    {
        [ ForeignKey("ExpenseRecord")]
        public int ExpenseRecordId { get; set; }

        public ExpenseRecord? ExpenseRecord { get; set; }


        [ForeignKey("ExpenseType")]
        public int ExpenseTypeId { get; set; }
        public ExpenseType? ExpenseType { get; set; }

        

        
    }
}
