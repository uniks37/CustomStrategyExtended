﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Gamer> Gamers { get; set; }
        public virtual DbSet<GameSession> GamerSessions { get; set; }
        public virtual DbSet<LoginSession> LoginSessions { get; set; }
        public virtual DbSet<SessionGamer> SessionGamers { get; set; }
        public virtual DbSet<TempGameSession> TempGameSessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {//Relationship with respect to Session gamer
            modelBuilder.Entity<SessionGamer>()
                .HasRequired<Gamer>(sg => sg.Gamer)
                .WithMany(g => g.SessionGamers)
                .HasForeignKey<long>(sg => sg.Gamer_Id);
            modelBuilder.Entity<SessionGamer>()
                .HasRequired<GameSession>(sg => sg.GameSession)
                .WithMany(g => g.SessionGamers)
                .HasForeignKey<long>(gs => gs.Gamer_Id);

            //Relationship with respect to Login session
            modelBuilder.Entity<LoginSession>()
                .HasRequired<Gamer>(ls => ls.Gamer)
                .WithMany(g => g.LoginSessions)
                .HasForeignKey<long>(ls => ls.Gamer_Id);

            //Properties
            modelBuilder.Entity<LoginSession>()
                .Property(ls => ls.Timestamp).IsConcurrencyToken();
            modelBuilder.Entity<GameSession>()
                .Property(gs => gs.Timestamp).IsConcurrencyToken();
        }
    }
}
