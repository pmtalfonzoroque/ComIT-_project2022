using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickAccountantAppIdentity.Dal.Model;
using QuickAccountantAppIdentity.Dal.Model.Indentity;
using System.Data;

namespace QuickAccountantAppIdentity.Dal.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole <int>, int> // structure called generic,
                                                                                                     // allow the cl;ass to be customized 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet <Order> Orders { get; set; }
        // for eacth table inside our DbContext Classe have to add the following: (name of the talbe in plural

        public virtual DbSet<ExpenseRecord> ExpenseRecords { get; set; } //we use in <> the class in the model, and inside the
                                                                         //application, the plural form is the object we are going
                                                                         //to use if we want to manipulate the <class>

        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; } // ExpenseTypes is a property that we will manipulate
        public virtual DbSet<ExpenseRecordType> ExpenseRecordTypes { get; set; }
        public virtual DbSet<IncomeRecord> IncomeRecords { get; set; }
        public virtual DbSet<IncomeType> IncomeTypes { get; set; }
        public virtual DbSet<IncomeRecordType> IncomeRecordTypes { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder) //important in case we have element that need to be modified here
        {
            modelBuilder.Entity<ExpenseRecordType>()
                .HasKey(ERT => new { ERT.ExpenseRecordId, ERT.ExpenseTypeId }); ;

            modelBuilder.Entity<IncomeRecordType>()
                .HasKey(IRT => new { IRT.IncomeRecordId, IRT.IncomeTypeId }); // to create a compose primary key, to panipulate N:N 
            
            base.OnModelCreating(modelBuilder); // this is need it to continue creating the rest  of the other tables that are not here
        }
    }
}