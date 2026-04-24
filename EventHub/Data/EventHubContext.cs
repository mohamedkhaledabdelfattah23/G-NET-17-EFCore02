using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Data
{
    public class EventHubContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> Profiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Registration> Registrations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=.;DataBase=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>()
                .HasKey(r => new { r.AttendeeId, r.EventId });


            modelBuilder.Entity<Event>()
                .HasOne(e => e.ParentEvent)
                .WithMany(e => e.Sessions)
                .HasForeignKey(e => e.ParentEventId)
                .OnDelete(DeleteBehavior.Restrict);




            modelBuilder.Entity<Attendee>()
                .HasOne(a => a.Badge)
                .WithOne(b => b.Attendee)
                .HasForeignKey<Badge>(b => b.AttendeeId);










        }




    }


}
