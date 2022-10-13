﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EX_4.Models
{
    public partial class MyDB2Context : DbContext
    {
        public MyDB2Context()
        {
        }

        public MyDB2Context(DbContextOptions<MyDB2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Dictionary> Dictionaries { get; set; } = null!;
        public virtual DbSet<WordType> WordTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =ADMIN\\SQLEXPRESS; database = MyDB2;uid=sa;pwd=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.HasKey(e => e.WordId)
                    .HasName("PK__Dictiona__2C20F046A608C143");

                entity.ToTable("Dictionary");

                entity.Property(e => e.WordId).HasColumnName("WordID");

                entity.Property(e => e.EditDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Word).HasMaxLength(30);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Dictionaries)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Dictionary__ID__267ABA7A");
            });

            modelBuilder.Entity<WordType>(entity =>
            {
                entity.ToTable("WordType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TypeName).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
