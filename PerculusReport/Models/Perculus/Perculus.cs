using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PerculusReport.Models.Perculus
{
    public partial class PerculusDb : DbContext
    {
        public PerculusDb()
            : base("name=PerculusDb")
        {
        }

        public virtual DbSet<ActiveSession> ActiveSessions { get; set; }
        public virtual DbSet<LoginLog> LoginLogs { get; set; }
        public virtual DbSet<RoomUser> RoomUsers { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<PUser> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<ActiveSession>()
                .Property(e => e.USERIP)
                .IsUnicode(false);

            modelBuilder.Entity<ActiveSession>()
                .Property(e => e.SERVERIP)
                .IsUnicode(false);


            modelBuilder.Entity<LoginLog>()
                .Property(e => e.IPADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.USERRIGHTSCHEMA)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.PERMITTEDSYSTEMLAYOUTS)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.PERCULUSSA_ST_ROOMS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Logs)
                .WithOptional(e => e.PERCULUSSA_ST_ROOMS)
                .WillCascadeOnDelete();


            modelBuilder.Entity<PUser>()
                .Property(e => e.CULTURE)
                .IsUnicode(false);

            modelBuilder.Entity<PUser>()
                .HasMany(e => e.PERCULUSSA_MT_ROOMUSERS)
                .WithOptional(e => e.PERCULUSSA_ST_USERS)
                .WillCascadeOnDelete();


        }
    }
}