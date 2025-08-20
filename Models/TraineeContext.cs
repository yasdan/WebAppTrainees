using Microsoft.EntityFrameworkCore; // needed for DbContext and DbSet
namespace WebAppTrainees.Models
{
    public class TraineeContext : DbContext
    {
        public TraineeContext()
        {
        }
        public TraineeContext(DbContextOptions<TraineeContext> options) : base(options)
        {
        }

       //static string connectionstring = @"Data Source=DESKTOP-ABDUL\SQLEXPRESS;Initial Catalog=TraineeDB;TrustServerCertificate= True; Integrated Security=True;";

        public DbSet<Trainee> Trainees { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Check if the optionsBuilder is already configured

            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
            
               // optionsBuilder.UseSqlServer(connectionstring);
                
            }
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trainee>().ToTable("Trainees");
            base.OnModelCreating(modelBuilder);
        }*/
    }
    }
