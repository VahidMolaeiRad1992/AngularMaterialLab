﻿// <auto-generated />
using System;
using ASPNETCore2JwtAuthentication.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MaterialAspNetCoreBackend.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MaterialAspNetCoreBackend.DomainClasses.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar");

                    b.Property<string>("Bio");

                    b.Property<DateTimeOffset>("BirthDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Avatar = "user1", Bio = "This is my biography ....", BirthDate = new DateTimeOffset(new DateTime(1993, 7, 10, 10, 15, 23, 275, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Name = "User 1" },
                        new { Id = 2, Avatar = "user2", Bio = "This is my biography ....", BirthDate = new DateTimeOffset(new DateTime(1983, 7, 10, 10, 15, 23, 276, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Name = "User 2" },
                        new { Id = 3, Avatar = "user3", Bio = "This is my biography ....", BirthDate = new DateTimeOffset(new DateTime(1973, 7, 10, 10, 15, 23, 276, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Name = "User 3" }
                    );
                });

            modelBuilder.Entity("MaterialAspNetCoreBackend.DomainClasses.UserNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Date");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserNotes");

                    b.HasData(
                        new { Id = 1, Date = new DateTimeOffset(new DateTime(2018, 7, 11, 10, 15, 23, 282, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Do something ...", UserId = 1 },
                        new { Id = 2, Date = new DateTimeOffset(new DateTime(2018, 7, 20, 10, 15, 23, 282, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Make something ...", UserId = 1 },
                        new { Id = 3, Date = new DateTimeOffset(new DateTime(2018, 7, 13, 10, 15, 23, 282, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Do something ...", UserId = 1 },
                        new { Id = 4, Date = new DateTimeOffset(new DateTime(2018, 7, 25, 10, 15, 23, 282, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Make something ...", UserId = 1 },
                        new { Id = 5, Date = new DateTimeOffset(new DateTime(2018, 7, 12, 10, 15, 23, 282, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Make something ...", UserId = 2 },
                        new { Id = 6, Date = new DateTimeOffset(new DateTime(2018, 7, 13, 10, 15, 23, 282, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), Title = "Do something ...", UserId = 3 }
                    );
                });

            modelBuilder.Entity("MaterialAspNetCoreBackend.DomainClasses.UserNote", b =>
                {
                    b.HasOne("MaterialAspNetCoreBackend.DomainClasses.User", "User")
                        .WithMany("UserNotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
