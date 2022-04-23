using AutoMapper;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
using EasyJob.API.Postulants.Domain.Models;
using Go2Climb.API.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Go2Climb.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Postulant> Postulants { get; set; }

        protected readonly IConfiguration _configuration;

        public AppDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //SQL configure
            //builder.UseMySQL(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Applicant>().ToTable("Applicants");
            builder.Entity<Applicant>().HasKey(p => p.Id);
            builder.Entity<Applicant>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Applicant>().Property(p => p.Name).IsRequired().HasMaxLength(25);
            builder.Entity<Applicant>().Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Entity<Applicant>().Property(p => p.Email).IsRequired().HasMaxLength(120);
            builder.Entity<Applicant>().Property(p => p.Password).IsRequired().HasMaxLength(25);
            builder.Entity<Applicant>().Property(p => p.Photo);
            
            builder.Entity<Postulant>().ToTable("Postulants");
            builder.Entity<Postulant>().HasKey(p => p.Id);
            builder.Entity<Postulant>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Postulant>().Property(p => p.Name).IsRequired().HasMaxLength(25);
            builder.Entity<Postulant>().Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Entity<Postulant>().Property(p => p.Email).IsRequired().HasMaxLength(120);
            builder.Entity<Postulant>().Property(p => p.Password).IsRequired().HasMaxLength(25);
            builder.Entity<Postulant>().Property(p => p.Description).HasMaxLength(120);
            builder.Entity<Postulant>().Property(p => p.GithubUser).HasMaxLength(50);
            
            /*
            Example
            //Constrains
            builder.Entity<Destination>().ToTable("Destinations");
            builder.Entity<Destination>().HasKey(p => p.Id);
            builder.Entity<Destination>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Destination>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Entity<Destination>().Property(p => p.Description).HasMaxLength(250);
            
            //Relationship
            builder.Entity<Destination>()
                .HasMany(p => p.Hotels)
                .WithOne(p => p.Destination)
                .HasForeignKey(p => p.DestinationId);*/
            
            builder.UseSnakeCaseNamingConventions();
        }
        
    }
}