﻿// <auto-generated />
using System;
using CompetitionEventApi.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompetitionEventApi.Services.Migrations
{
    [DbContext(typeof(CompetitionApiDbContext))]
    partial class CompetitionApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<decimal>("MaxScore");

                    b.Property<int>("NumberOfRounds");

                    b.Property<int>("RelatedCompetitionId");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.CompetitionApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetitionId");

                    b.Property<int?>("ContestantId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionId");

                    b.HasIndex("ContestantId");

                    b.ToTable("CompetitionApplication");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.CompetitionEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("CompetitionEvents");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.CompetitionScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetitionApplicationId");

                    b.Property<int?>("CompetitionId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<decimal>("FinalScore");

                    b.Property<decimal>("Round1");

                    b.Property<decimal>("Round2");

                    b.Property<decimal>("Round3");

                    b.Property<decimal>("Round4");

                    b.Property<decimal>("Round5");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionApplicationId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("CompetitionScore");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.Contestant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClubName");

                    b.Property<string>("Country");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mob");

                    b.Property<string>("PostalCode");

                    b.Property<int>("Status");

                    b.Property<string>("Street");

                    b.Property<string>("StreetNumber");

                    b.Property<string>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Contestants");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("Status");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.RelatedEventCompetition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompetitionEventId");

                    b.Property<int?>("CompetitionId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CompetitionEventId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("RelatedEventCompetition");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.CompetitionApplication", b =>
                {
                    b.HasOne("CompetitionEventApi.Services.DataObjects.Competition", "Competition")
                        .WithMany("CompetitionApplications")
                        .HasForeignKey("CompetitionId");

                    b.HasOne("CompetitionEventApi.Services.DataObjects.Contestant", "Contestant")
                        .WithMany("CompetitionApplications")
                        .HasForeignKey("ContestantId");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.CompetitionScore", b =>
                {
                    b.HasOne("CompetitionEventApi.Services.DataObjects.CompetitionApplication", "CompetitionApplication")
                        .WithMany("CompetitionScores")
                        .HasForeignKey("CompetitionApplicationId");

                    b.HasOne("CompetitionEventApi.Services.DataObjects.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("CompetitionId");
                });

            modelBuilder.Entity("CompetitionEventApi.Services.DataObjects.RelatedEventCompetition", b =>
                {
                    b.HasOne("CompetitionEventApi.Services.DataObjects.CompetitionEvent", "CompetitionEvent")
                        .WithMany("RelatedEventCompetitions")
                        .HasForeignKey("CompetitionEventId");

                    b.HasOne("CompetitionEventApi.Services.DataObjects.Competition", "Competition")
                        .WithMany("RelatedEventCompetitions")
                        .HasForeignKey("CompetitionId");
                });
#pragma warning restore 612, 618
        }
    }
}
