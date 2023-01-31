using System.Collections.Generic;



namespace try.Data
{
   public class DataContext : DbContext
    { 
    public DataContext(DbContextOptions<DataContext> options)
    : base(options) { }


    public DbSet<Employees> Employees { get; set; }
    
    }
}
