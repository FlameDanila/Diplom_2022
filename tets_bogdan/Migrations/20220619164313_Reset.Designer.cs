﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tets_bogdan.Models;

#nullable disable

namespace tets_bogdan.Migrations
{
    [DbContext(typeof(RTKDatabaseContext))]
    [Migration("20220619164313_Reset")]
    partial class Reset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("tets_bogdan.Models.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CompetitionTypeId")
                        .HasColumnType("int")
                        .HasColumnName("competitionTypeId");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("Place")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("place");

                    b.Property<string>("SelectCategoryId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("selectCategoryId")
                        .IsFixedLength();

                    b.Property<int?>("StageTypeId")
                        .HasColumnType("int")
                        .HasColumnName("stageTypeId");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionTypeId");

                    b.ToTable("Competition", (string)null);
                });

            modelBuilder.Entity("tets_bogdan.Models.CompetitionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("CompetitionType", (string)null);
                });

            modelBuilder.Entity("tets_bogdan.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<string>("Documents")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("documents");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Mesto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("mesto");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("login")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("login");

                    b.Property<string>("name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("Participant", (string)null);
                });

            modelBuilder.Entity("tets_bogdan.Models.Robot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("description");

                    b.Property<string>("Photo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("photo");

                    b.Property<string>("VideoLink")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("videoLink");

                    b.HasKey("Id");

                    b.ToTable("Robot", (string)null);
                });

            modelBuilder.Entity("tets_bogdan.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateTest")
                        .HasColumnType("date")
                        .HasColumnName("dateTest");

                    b.Property<int?>("FirstParticipantId")
                        .HasColumnType("int")
                        .HasColumnName("firstParticipantId");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int?>("RobotId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondParticipantId")
                        .HasColumnType("int")
                        .HasColumnName("secondParticipantId");

                    b.Property<int?>("SelectedStageId")
                        .HasColumnType("int")
                        .HasColumnName("selectedStageId");

                    b.Property<int?>("TrainerId")
                        .HasColumnType("int")
                        .HasColumnName("trainerId");

                    b.HasKey("Id");

                    b.HasIndex("FirstParticipantId");

                    b.HasIndex("RobotId");

                    b.HasIndex("SecondParticipantId");

                    b.HasIndex("SelectedStageId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Team", (string)null);
                });

            modelBuilder.Entity("tets_bogdan.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date")
                        .HasColumnName("birthday");

                    b.Property<string>("Documents")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("documents");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Mesto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("mesto");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Trainer", (string)null);
                });

            modelBuilder.Entity("tets_bogdan.Models.Competition", b =>
                {
                    b.HasOne("tets_bogdan.Models.CompetitionType", "CompetitionType")
                        .WithMany("Competitions")
                        .HasForeignKey("CompetitionTypeId")
                        .HasConstraintName("FK_Competition_CompetitionType");

                    b.Navigation("CompetitionType");
                });

            modelBuilder.Entity("tets_bogdan.Models.Team", b =>
                {
                    b.HasOne("tets_bogdan.Models.Participant", "FirstParticipant")
                        .WithMany("TeamFirstParticipants")
                        .HasForeignKey("FirstParticipantId")
                        .HasConstraintName("FK_Team_Participant");

                    b.HasOne("tets_bogdan.Models.Robot", "Robot")
                        .WithMany("Teams")
                        .HasForeignKey("RobotId")
                        .HasConstraintName("FK_Team_Robot");

                    b.HasOne("tets_bogdan.Models.Participant", "SecondParticipant")
                        .WithMany("TeamSecondParticipants")
                        .HasForeignKey("SecondParticipantId")
                        .HasConstraintName("FK_Team_Participant1");

                    b.HasOne("tets_bogdan.Models.Competition", "SelectedStage")
                        .WithMany("Teams")
                        .HasForeignKey("SelectedStageId")
                        .HasConstraintName("FK_Team_Competition");

                    b.HasOne("tets_bogdan.Models.Trainer", "Trainer")
                        .WithMany("Teams")
                        .HasForeignKey("TrainerId")
                        .HasConstraintName("FK_Team_Trainer");

                    b.Navigation("FirstParticipant");

                    b.Navigation("Robot");

                    b.Navigation("SecondParticipant");

                    b.Navigation("SelectedStage");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("tets_bogdan.Models.Competition", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("tets_bogdan.Models.CompetitionType", b =>
                {
                    b.Navigation("Competitions");
                });

            modelBuilder.Entity("tets_bogdan.Models.Participant", b =>
                {
                    b.Navigation("TeamFirstParticipants");

                    b.Navigation("TeamSecondParticipants");
                });

            modelBuilder.Entity("tets_bogdan.Models.Robot", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("tets_bogdan.Models.Trainer", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
