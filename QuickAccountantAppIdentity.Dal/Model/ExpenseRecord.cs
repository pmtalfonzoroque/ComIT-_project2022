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
    [Table ("ExpenseRecord")]
    public class ExpenseRecord // this is the one created once the user click the button "Add expense"
    {
        [Required, Key]
        public int Id { get; set; } //user who create the record

        public int? UpdatedBy { get; set; }  //user that update the record, in the case that an Admin correct it

        [Required]
        public DateTime CreatedDate { get; set; } // Expense date

        public DateTime UpdatedDate { get; set; } // in case the record is updated later

        [Required]
        public decimal Total { get; set; }

        public decimal? GST { get; set; } // it might empty, this has to be extracted (somehow) from the total ammount

        public decimal? PST { get; set; } //this is not applied everywhere... maybe I should include a
                                         //check box to specify if this Tax was charged or not

        [MaxLength (50)]
        public string? Place { get; set; } // it might be empty if the user wants

        public string? Comment { get; set; } //it might be empty

        [Required]
        public ExpenseGroup ExpenseGroup { get; set; } // this is a Enum.
                                                       // its selection will be programed in Blazor.razor @ pages as a <div>

        [ForeignKey ("ExpenseType")]
        public int ExpenseTypeID { get; set; } // needed in the create page

        public ExpenseType ExpenseType { get; set; }
        
        public List<ExpenseRecordType> ExpenseRecordType { get; set; } //N:N relation
        

        public PayMethod PayMethod { get; set; } // this is a Enum.

        ////[Required, ForeignKey ("User")]
        //[ ForeignKey("User")]
        //public int? UserId { get; set; } // this information might be important for the Administrator

        //public User User { get; set; }

        
    }
}
