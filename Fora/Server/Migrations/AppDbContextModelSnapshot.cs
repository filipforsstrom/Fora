﻿// <auto-generated />
using System;
using Fora.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fora.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fora.Shared.InterestModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3132),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Games",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3163),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Books",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3165),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Music",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3166),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Hiking",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Fora.Shared.MessageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ThreadId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ThreadId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3207),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "I love the new elden ring game",
                            ThreadId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3210),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "I think it's the worst in the series",
                            ThreadId = 1,
                            UserId = 4
                        },
                        new
                        {
                            Id = 3,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3212),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "It's not a part of any series",
                            ThreadId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3214),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "Yes it is",
                            ThreadId = 1,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3216),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "I've heard they are releasing another book in the twilight franschise",
                            ThreadId = 4,
                            UserId = 4
                        },
                        new
                        {
                            Id = 6,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3217),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "NOBODY CARES",
                            ThreadId = 4,
                            UserId = 1
                        },
                        new
                        {
                            Id = 7,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3219),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "I care",
                            ThreadId = 4,
                            UserId = 4
                        },
                        new
                        {
                            Id = 8,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3251),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "Keep a civil tone in here please and only post regarding the topic.",
                            ThreadId = 4,
                            UserId = 2
                        },
                        new
                        {
                            Id = 9,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3254),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "I'm sorry. I'm actually prtty excited 4 the new release",
                            ThreadId = 4,
                            UserId = 1
                        },
                        new
                        {
                            Id = 10,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3255),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deleted = false,
                            Message = "Has anybody tried hiking in dr martens?? And if so, do you have any recommendations for me? I'm going up to Sälen next week and would like a pair of martens, but I've heard they're not that good for hiking in..",
                            ThreadId = 3,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Fora.Shared.ThreadModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InterestId");

                    b.HasIndex("UserId");

                    b.ToTable("Threads");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3191),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterestId = 2,
                            Name = "Blazors guide to the universe",
                            UserId = 2
                        },
                        new
                        {
                            Id = 1,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3194),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterestId = 1,
                            Name = "Elden Ring",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3195),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterestId = 4,
                            Name = "Hiking in dr martens??",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            DateTimeCreated = new DateTime(2022, 4, 12, 10, 34, 0, 783, DateTimeKind.Local).AddTicks(3197),
                            DateTimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InterestId = 2,
                            Name = "About twilight...",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("Fora.Shared.UserInterestModel", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "InterestId");

                    b.HasIndex("InterestId");

                    b.ToTable("UserInterests");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            InterestId = 1
                        },
                        new
                        {
                            UserId = 2,
                            InterestId = 2
                        },
                        new
                        {
                            UserId = 2,
                            InterestId = 3
                        },
                        new
                        {
                            UserId = 1,
                            InterestId = 2
                        },
                        new
                        {
                            UserId = 3,
                            InterestId = 4
                        },
                        new
                        {
                            UserId = 4,
                            InterestId = 2
                        },
                        new
                        {
                            UserId = 4,
                            InterestId = 1
                        });
                });

            modelBuilder.Entity("Fora.Shared.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Banned")
                        .HasColumnType("bit");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Banned = false,
                            Deleted = false,
                            Username = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Banned = false,
                            Deleted = false,
                            Username = "Jesper"
                        },
                        new
                        {
                            Id = 3,
                            Banned = true,
                            Deleted = false,
                            Username = "Filip"
                        },
                        new
                        {
                            Id = 4,
                            Banned = false,
                            Deleted = true,
                            Username = "Mårten"
                        },
                        new
                        {
                            Id = 5,
                            Banned = false,
                            Deleted = false,
                            Username = "Dragan"
                        });
                });

            modelBuilder.Entity("Fora.Shared.InterestModel", b =>
                {
                    b.HasOne("Fora.Shared.UserModel", "User")
                        .WithMany("Interests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fora.Shared.MessageModel", b =>
                {
                    b.HasOne("Fora.Shared.ThreadModel", "Thread")
                        .WithMany("Messages")
                        .HasForeignKey("ThreadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fora.Shared.UserModel", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Thread");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fora.Shared.ThreadModel", b =>
                {
                    b.HasOne("Fora.Shared.InterestModel", "Interest")
                        .WithMany("Threads")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fora.Shared.UserModel", "User")
                        .WithMany("Threads")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Interest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fora.Shared.UserInterestModel", b =>
                {
                    b.HasOne("Fora.Shared.InterestModel", "Interest")
                        .WithMany("UserInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fora.Shared.UserModel", "User")
                        .WithMany("UserInterests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Fora.Shared.InterestModel", b =>
                {
                    b.Navigation("Threads");

                    b.Navigation("UserInterests");
                });

            modelBuilder.Entity("Fora.Shared.ThreadModel", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Fora.Shared.UserModel", b =>
                {
                    b.Navigation("Interests");

                    b.Navigation("Messages");

                    b.Navigation("Threads");

                    b.Navigation("UserInterests");
                });
#pragma warning restore 612, 618
        }
    }
}
