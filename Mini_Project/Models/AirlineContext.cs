using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AirlineReservationWeb.Models
{
    public partial class AirlineContext : DbContext
    {
        public AirlineContext()
        {
        }

        public AirlineContext(DbContextOptions<AirlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<Regtb> Regtbs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-LPJJ8J9;Database=Airline;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flight");

                entity.Property(e => e.FlightId)
                    .ValueGeneratedNever()
                    .HasColumnName("flight_id");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("airline_name");

                entity.Property(e => e.ArrivalTime)
                    .HasColumnType("datetime")
                    .HasColumnName("arrival_time");

                entity.Property(e => e.DepartureTime)
                    .HasColumnType("datetime")
                    .HasColumnName("departure_time");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.FromLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("from_location");

                entity.Property(e => e.ToLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("to_location");

                entity.Property(e => e.TotalSeats).HasColumnName("total_seats");
            });

            modelBuilder.Entity<Regtb>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__regtb__DD701264D2E735A1");

                entity.ToTable("regtb");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .HasColumnName("email")
                    .IsFixedLength();

                entity.Property(e => e.FirstName)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Login)
                    .HasMaxLength(80)
                    .HasColumnName("login")
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(80)
                    .HasColumnName("password")
                    .IsFixedLength();

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(80)
                    .HasColumnName("phonenumber")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
