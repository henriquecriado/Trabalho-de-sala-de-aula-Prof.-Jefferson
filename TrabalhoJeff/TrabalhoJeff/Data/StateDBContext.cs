using Microsoft.EntityFrameworkCore;
using TrabalhoJeff.Model;

namespace TrabalhoJeff.Data
{
    public class StateDBContext : DbContext
    {
        public StateDBContext(DbContextOptions<StateDBContext> options) : base(options) { }
        public DbSet<TaskModel> TasksModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>().Property(t => t.State);

            base.OnModelCreating(modelBuilder);

        }

    }

}
