using Microsoft.EntityFrameworkCore;
using Secheli_Stefania_Lab5.Models;
namespace Secheli_Stefania_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
        : base(options)
        {
        }
        public DbSet<Expenses> Expense { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
        public DbSet<Budget> Budget { get; set; }

    }
}