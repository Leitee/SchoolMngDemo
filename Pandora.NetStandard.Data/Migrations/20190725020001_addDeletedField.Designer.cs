﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pandora.NetStandard.Data.Dals;

namespace Pandora.NetStandard.Data.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20190725020001_addDeletedField")]
    partial class addDeletedField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims","Auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims","Auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("ProviderKey");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("ProviderKey", "LoginProvider");

                    b.HasAlternateKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins","Auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles","Auth");

                    b.HasData(
                        new
                        {
                            UserId = -1,
                            RoleId = -1
                        },
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 11,
                            RoleId = 3
                        },
                        new
                        {
                            UserId = 101,
                            RoleId = 4
                        },
                        new
                        {
                            UserId = 102,
                            RoleId = 4
                        },
                        new
                        {
                            UserId = 103,
                            RoleId = 4
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens","Auth");
                });

            modelBuilder.Entity("Pandora.NetStandard.Core.Identity.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles","Auth");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            ConcurrencyStamp = "13e17977-1360-4339-aba6-94488ee52935",
                            Description = "Full functionality over app and debugin",
                            Name = "Dev",
                            NormalizedName = "DEV"
                        },
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "ae6b4e4c-50c3-4384-952e-4f66a6aa8379",
                            Description = "Full permissions and features",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "bf206a54-6c36-4b6c-b0b7-095684b5bc49",
                            Description = "Limited functionality just administrative permissions",
                            Name = "Super",
                            NormalizedName = "SUPER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "380f8b16-29f5-4f17-82ae-737083bc6b4f",
                            Description = "Limited functionality just teaching-relative permissions",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "5bfc1652-f452-4881-8e92-a2fcff80cfe8",
                            Description = "Limited functionality just student-relative permissions",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Pandora.NetStandard.Core.Identity.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("JoinDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users","Auth");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6d0fccfd-c3b9-40dd-ae0c-655903116192",
                            Email = "info@pandorasistemas.com",
                            EmailConfirmed = true,
                            FirstName = "Jhon",
                            JoinDate = new DateTime(2019, 7, 25, 2, 0, 1, 231, DateTimeKind.Utc).AddTicks(4975),
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "INFO@PANDORASISTEMAS.COM",
                            NormalizedUserName = "DEVADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOy7klBCy3dhyEPbVFP0Z3N2fhtJmKnAM1tva4w2HhQI8QVN7/Z971D78zgMVg4uYQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "devadmin"
                        },
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ed61cf66-7666-4bc7-92d3-52235ad7b185",
                            Email = "risanchez@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Rick",
                            JoinDate = new DateTime(2019, 7, 25, 2, 0, 1, 245, DateTimeKind.Utc).AddTicks(6018),
                            LastName = "Sanchez",
                            LockoutEnabled = false,
                            NormalizedEmail = "RISANCHEZ@ADMIN.COM",
                            NormalizedUserName = "RISANCHEZ",
                            PasswordHash = "AQAAAAEAACcQAAAAEI4ITpGaJ70iZgCxl260xczLiUhvci23VBsj71CKQ8KAuum9Awc0vZe7TYdn3iGveg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "risanchez"
                        },
                        new
                        {
                            Id = 11,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "17ced13f-6c8c-4662-8fa7-803068fb9e4f",
                            Email = "dabrown@teacher.com",
                            EmailConfirmed = true,
                            FirstName = "Dan",
                            JoinDate = new DateTime(2019, 7, 25, 2, 0, 1, 254, DateTimeKind.Utc).AddTicks(5084),
                            LastName = "Brown",
                            LockoutEnabled = false,
                            NormalizedEmail = "DABROWN@TEACHER.COM",
                            NormalizedUserName = "DABROWN",
                            PasswordHash = "AQAAAAEAACcQAAAAEPTfwLXVud7o6RmXBw0yYyVI3RGZ0dzoxUYOW48SLvTZzV7egIGPx4fx5/eze9hIeQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "dabrown"
                        },
                        new
                        {
                            Id = 101,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ed2d6c5-7cb7-4114-a0a7-5fe3365ae664",
                            Email = "bruce.wayne@student.com",
                            EmailConfirmed = true,
                            FirstName = "Bruce",
                            JoinDate = new DateTime(2019, 7, 25, 2, 0, 1, 262, DateTimeKind.Utc).AddTicks(3922),
                            LastName = "Wayne",
                            LockoutEnabled = false,
                            NormalizedEmail = "BRUCE.WAYNE@STUDENT.COM",
                            NormalizedUserName = "BRWAYNE",
                            PasswordHash = "AQAAAAEAACcQAAAAEIpsMozczm6Jpayp6eBdWo2hhLLqmR+NotrZ7v2PXq9kkaVzaJ+TvLh4CoxXyUQtgg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "brwayne"
                        },
                        new
                        {
                            Id = 102,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "526a48e3-0c12-4db3-a81d-b72d4e049657",
                            Email = "ayn.rand@student.com",
                            EmailConfirmed = true,
                            FirstName = "Ayn",
                            JoinDate = new DateTime(2019, 7, 25, 2, 0, 1, 269, DateTimeKind.Utc).AddTicks(3167),
                            LastName = "Rand",
                            LockoutEnabled = false,
                            NormalizedEmail = "AYN.RAND@STUDENT.COM",
                            NormalizedUserName = "ANRAND",
                            PasswordHash = "AQAAAAEAACcQAAAAELmoDvdJ6ZEuMp5SAf9nKbFpPFWu7Ble4DOkxiUQQkdAwu09hjNz3QyKmksVIueZrg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "anrand"
                        },
                        new
                        {
                            Id = 103,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0a2ed0d2-1471-473b-a9fe-26ee269aeffd",
                            Email = "milton.friedman@student.com",
                            EmailConfirmed = true,
                            FirstName = "Milton",
                            JoinDate = new DateTime(2019, 7, 25, 2, 0, 1, 278, DateTimeKind.Utc).AddTicks(5555),
                            LastName = "Fiedman",
                            LockoutEnabled = false,
                            NormalizedEmail = "MILTON.FRIEDMAN@STUDENT.COM",
                            NormalizedUserName = "MIFRIEDMAN",
                            PasswordHash = "AQAAAAEAACcQAAAAEO8J7oplILHdTzAuBl38oVAWUMQ2ass+me4hUIlGf25V5ggVPU0CnOh3H+drWlvsWA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "mifriedman"
                        });
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Attend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Attendance");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Obs");

                    b.Property<int>("StudentId");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Attends","School");
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Shift");

                    b.HasKey("Id");

                    b.HasIndex("GradeId");

                    b.ToTable("Classes","School");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GradeId = 1,
                            Name = "1ra",
                            Shift = 1
                        },
                        new
                        {
                            Id = 2,
                            GradeId = 1,
                            Name = "2da",
                            Shift = 2
                        },
                        new
                        {
                            Id = 3,
                            GradeId = 2,
                            Name = "1ra",
                            Shift = 1
                        },
                        new
                        {
                            Id = 4,
                            GradeId = 2,
                            Name = "2da",
                            Shift = 3
                        },
                        new
                        {
                            Id = 5,
                            GradeId = 3,
                            Name = "1ra",
                            Shift = 2
                        },
                        new
                        {
                            Id = 6,
                            GradeId = 3,
                            Name = "2da",
                            Shift = 3
                        },
                        new
                        {
                            Id = 7,
                            GradeId = 4,
                            Name = "1ra",
                            Shift = 1
                        },
                        new
                        {
                            Id = 8,
                            GradeId = 5,
                            Name = "1ra",
                            Shift = 1
                        });
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Capacity");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool?>("HasNetworkConexion");

                    b.Property<bool?>("HasScreenProjector");

                    b.HasKey("Id");

                    b.ToTable("ClassRooms","School");
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date");

                    b.Property<int>("ExamType");

                    b.Property<string>("Obs");

                    b.Property<float>("Score");

                    b.Property<int>("StudentId");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exams","School");
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Grade", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Grades","School");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1er"
                        },
                        new
                        {
                            Id = 2,
                            Name = "2do"
                        },
                        new
                        {
                            Id = 3,
                            Name = "3ro"
                        },
                        new
                        {
                            Id = 4,
                            Name = "4to"
                        },
                        new
                        {
                            Id = 5,
                            Name = "5to"
                        });
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Student", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<int>("ApplicationUserId");

                    b.Property<string>("Obs");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Students","School");

                    b.HasData(
                        new
                        {
                            Id = 11111111,
                            ApplicationUserId = 101
                        },
                        new
                        {
                            Id = 22222222,
                            ApplicationUserId = 102
                        },
                        new
                        {
                            Id = 33333333,
                            ApplicationUserId = 103
                        });
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.StudentState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademicState");

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime?>("DateTo");

                    b.Property<string>("Obs");

                    b.Property<int>("StudentId");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentStates","School");
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Subjects","School");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Matemáticas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fisica"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Redes"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Algoritmos"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Programación",
                            SubjectId = 4
                        });
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.SubjectAssingment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId");

                    b.Property<int?>("ClassRoomId");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Deleted");

                    b.Property<int>("SubjectId");

                    b.Property<int?>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SubjectAssingments","School");
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Teacher", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<int>("ApplicationUserId");

                    b.Property<string>("Obs");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Teachers","School");

                    b.HasData(
                        new
                        {
                            Id = 32165498,
                            ApplicationUserId = 11
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Attend", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Student")
                        .WithMany("Attends")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pandora.NetStandard.Model.Entities.Subject")
                        .WithMany("Attends")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Class", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Grade", "Grade")
                        .WithMany("Classes")
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Exam", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pandora.NetStandard.Model.Entities.Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Student", b =>
                {
                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.StudentState", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Student", "Student")
                        .WithMany("StudentStates")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pandora.NetStandard.Model.Entities.Subject", "Subject")
                        .WithMany("StudentStates")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Subject", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Subject", "PreReqSubject")
                        .WithMany()
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.SubjectAssingment", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Class", "Class")
                        .WithMany("SubjectAssingments")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pandora.NetStandard.Model.Entities.ClassRoom", "ClassRoom")
                        .WithMany()
                        .HasForeignKey("ClassRoomId");

                    b.HasOne("Pandora.NetStandard.Model.Entities.Subject", "Subject")
                        .WithMany("SubjectAssingments")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pandora.NetStandard.Model.Entities.Teacher", "Teacher")
                        .WithMany("SubjectAssingments")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Teacher", b =>
                {
                    b.HasOne("Pandora.NetStandard.Core.Identity.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
