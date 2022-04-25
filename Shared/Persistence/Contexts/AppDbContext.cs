using AutoMapper;
using EasyJob.API.Announcements.Domain.Models;
using EasyJob.API.Applicants.Domain.Models;
using EasyJob.API.Applicants.Resources;
using EasyJob.API.Postulants.Domain.Models;
//**using EasyJob.API.Projects.Domain.Models;
using EasyJob.API.Interviews.Domain.Models;
using EasyJob.API.Messages.Domain.Models;
using Go2Climb.API.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Go2Climb.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Postulant> Postulants { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        //**  public DbSet<Project> Projects { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Interview> Interviews { get; set; }

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

            builder.Entity<Announcement>().ToTable("Announcements"); builder.Entity<Announcement>().HasKey(p => p.Id);
            builder.Entity<Announcement>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Announcement>().Property(p => p.Tittle).IsRequired().HasMaxLength(25);
            builder.Entity<Announcement>().Property(p => p.Description).IsRequired().HasMaxLength(250);
            builder.Entity<Announcement>().Property(p => p.Salary).IsRequired().HasMaxLength(120);
            builder.Entity<Announcement>().Property(p => p.Date).IsRequired().HasMaxLength(25);
            builder.Entity<Announcement>().Property(p => p.Visible).IsRequired().HasMaxLength(25);
            builder.Entity<Announcement>().Property(p => p.Type_money);
            
          //* builder.Entity<Project>().ToTable("Project");
          //* builder.Entity<Project>().HasKey(p => p.Id);
          //* builder.Entity<Project>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
          //* builder.Entity<Project>().Property(p => p.Tittle).IsRequired().HasMaxLength(25);
          //* builder.Entity<Project>().Property(p => p.Description).IsRequired().HasMaxLength(250);
          //* builder.Entity<Project>().Property(p => p.Url).IsRequired().HasMaxLength(120);
          //* builder.Entity<Project>().Property(p => p.Photo).IsRequired().HasMaxLength(25);
          //* builder.Entity<Project>().Property(p => p.Postulants_id).IsRequired().HasMaxLength(35);
          
            builder.Entity<Message>().ToTable("Messages");
            builder.Entity<Message>().HasKey(p => p.Id);
            builder.Entity<Message>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Message>().Property(p => p.Id).IsRequired().HasMaxLength(25);
            builder.Entity<Message>().Property(p => p.Description).IsRequired().HasMaxLength(50);
            builder.Entity<Message>().Property(p => p.Date).IsRequired().HasMaxLength(120);
       
            
            builder.Entity<Interview>().ToTable("Interviews");
            builder.Entity<Interview>().HasKey(p => p.Id);
            builder.Entity<Interview>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Interview>().Property(p => p.Id).IsRequired().HasMaxLength(25);
            builder.Entity<Interview>().Property(p => p.Date).IsRequired().HasMaxLength(50);
            builder.Entity<Interview>().Property(p => p.Hora).IsRequired().HasMaxLength(120);
            builder.Entity<Interview>().Property(p => p.Link).IsRequired().HasMaxLength(25);
  
           
            
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