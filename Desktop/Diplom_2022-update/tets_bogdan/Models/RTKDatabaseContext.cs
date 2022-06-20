using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace tets_bogdan.Models
{
    public partial class RTKDatabaseContext : DbContext
    {
        public RTKDatabaseContext()
        {
        }

        public RTKDatabaseContext(DbContextOptions<RTKDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Block> Blocks { get; set; } = null!;
        public virtual DbSet<Competition> Competitions { get; set; } = null!;
        public virtual DbSet<CompetitionCategoryId> CompetitionCategoryIds { get; set; } = null!;
        public virtual DbSet<CompetitionStageId> CompetitionStageIds { get; set; } = null!;
        public virtual DbSet<CompetitionType> CompetitionTypes { get; set; } = null!;
        public virtual DbSet<Participant> Participants { get; set; } = null!;
        public virtual DbSet<Robot> Robots { get; set; } = null!;
        public virtual DbSet<ScoreTable> ScoreTables { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<TypesId> TypesIds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-ITVEB8Q\\SQLEXPRESS;Trusted_connection=Yes;DataBase=RTKDatabase;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Block>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(50)
                    .HasColumnName("photo");

                entity.Property(e => e.TypeBlock).HasMaxLength(50);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Blocks)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Blocks_TypesId");
            });

            modelBuilder.Entity<Competition>(entity =>
            {
                entity.ToTable("Competition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompetitionTypeId).HasColumnName("competitionTypeId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .HasColumnName("place");

                entity.Property(e => e.SelectCategoryId).HasColumnName("selectCategoryId");

                entity.Property(e => e.StageTypeId).HasColumnName("stageTypeId");

                entity.HasOne(d => d.CompetitionType)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.CompetitionTypeId)
                    .HasConstraintName("FK_Competition_CompetitionType");

                entity.HasOne(d => d.SelectCategory)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.SelectCategoryId)
                    .HasConstraintName("FK_Competition_CompetitionCategoryId");

                entity.HasOne(d => d.StageType)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.StageTypeId)
                    .HasConstraintName("FK_Competition_CompetitionStageId");
            });

            modelBuilder.Entity<CompetitionCategoryId>(entity =>
            {
                entity.ToTable("CompetitionCategoryId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CompetitionStageId>(entity =>
            {
                entity.ToTable("CompetitionStageId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CompetitionType>(entity =>
            {
                entity.ToTable("CompetitionType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.ToTable("Participant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Documents)
                    .HasMaxLength(100)
                    .HasColumnName("documents");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .HasColumnName("login");

                entity.Property(e => e.Mesto)
                    .HasMaxLength(100)
                    .HasColumnName("mesto");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<Robot>(entity =>
            {
                entity.ToTable("Robot");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .HasColumnName("photo");

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(100)
                    .HasColumnName("videoLink");
            });

            modelBuilder.Entity<ScoreTable>(entity =>
            {
                entity.ToTable("ScoreTable");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChalangesScore).HasColumnName("chalangesScore");

                entity.Property(e => e.LaddersScore).HasColumnName("laddersScore");

                entity.Property(e => e.PenaltyScore).HasColumnName("penaltyScore");

                entity.Property(e => e.QuestionsScore).HasColumnName("questionsScore");

                entity.Property(e => e.TowerScore).HasColumnName("towerScore");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.ScoreTables)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_ScoreTable_Team");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Team");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BlocksScoreId).HasColumnName("blocksScoreId");

                entity.Property(e => e.FirstParticipantId).HasColumnName("firstParticipantId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.SecondParticipantId).HasColumnName("secondParticipantId");

                entity.Property(e => e.SelectedStageId).HasColumnName("selectedStageId");

                entity.Property(e => e.TrainerId).HasColumnName("trainerId");

                entity.HasOne(d => d.BlocksScore)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.BlocksScoreId)
                    .HasConstraintName("FK_Team_ScoreTable");

                entity.HasOne(d => d.FirstParticipant)
                    .WithMany(p => p.TeamFirstParticipants)
                    .HasForeignKey(d => d.FirstParticipantId)
                    .HasConstraintName("FK_Team_Participant");

                entity.HasOne(d => d.Robot)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.RobotId)
                    .HasConstraintName("FK_Team_Robot");

                entity.HasOne(d => d.SecondParticipant)
                    .WithMany(p => p.TeamSecondParticipants)
                    .HasForeignKey(d => d.SecondParticipantId)
                    .HasConstraintName("FK_Team_Participant1");

                entity.HasOne(d => d.SelectedStage)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.SelectedStageId)
                    .HasConstraintName("FK_Team_Competition");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.TrainerId)
                    .HasConstraintName("FK_Team_Trainer");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("Trainer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Documents)
                    .HasMaxLength(100)
                    .HasColumnName("documents");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Mesto)
                    .HasMaxLength(100)
                    .HasColumnName("mesto");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phoneNumber");
            });

            modelBuilder.Entity<TypesId>(entity =>
            {
                entity.ToTable("TypesId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameType).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
