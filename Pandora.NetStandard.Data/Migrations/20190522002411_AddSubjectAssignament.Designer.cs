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
    [Migration("20190522002411_AddSubjectAssignament")]
    partial class AddSubjectAssignament
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
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

            modelBuilder.Entity("Pandora.NetStdLibrary.Base.Identity.ApplicationRole", b =>
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
                            ConcurrencyStamp = "f8fd2a09-5bd5-46ce-b844-2ed9eea88ba6",
                            Description = "Full functionality over app and debugin",
                            Name = "Dev",
                            NormalizedName = "DEV"
                        },
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "ba3490e2-1e93-49bf-9133-b131c38ed090",
                            Description = "Full permissions and features",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "2a30e87f-f325-4df6-a950-055658ccf18c",
                            Description = "Limited functionality just administrative permissions",
                            Name = "Super",
                            NormalizedName = "SUPER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "104ad33a-f0ec-4da8-b00a-db2f741a5f8c",
                            Description = "Limited functionality just teaching-relative permissions",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "92d8afeb-0199-4d38-a2a4-05ff190849f8",
                            Description = "Limited functionality just student-relative permissions",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Pandora.NetStdLibrary.Base.Identity.ApplicationUser", b =>
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
                            ConcurrencyStamp = "636dea41-3f2a-4b67-ada3-7aed3006c09d",
                            Email = "info@pandorasistemas.com",
                            EmailConfirmed = true,
                            FirstName = "Jhon",
                            JoinDate = new DateTime(2019, 5, 22, 0, 24, 10, 546, DateTimeKind.Utc).AddTicks(442),
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "INFO@PANDORASISTEMAS.COM",
                            NormalizedUserName = "DEVADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEG2RoREOCUjz2cWpJrmNpYYUOwCBmvfGIOOtChYuxGl/b5CWruAFdcvty3bYTqg8Kw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "devadmin"
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
                            GradeId = 1,
                            Name = "3ra",
                            Shift = 3
                        },
                        new
                        {
                            Id = 4,
                            GradeId = 2,
                            Name = "1ra",
                            Shift = 1
                        },
                        new
                        {
                            Id = 5,
                            GradeId = 2,
                            Name = "2da",
                            Shift = 2
                        },
                        new
                        {
                            Id = 6,
                            GradeId = 3,
                            Name = "1ra",
                            Shift = 3
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

                    b.Property<bool?>("HasNetworkConexioin");

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
                        });
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Student", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Students","School");
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
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.SubjectAssingment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId");

                    b.Property<int?>("ClassRoomId");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Disable");

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

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Teachers","School");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Pandora.NetStdLibrary.Base.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Pandora.NetStdLibrary.Base.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Pandora.NetStdLibrary.Base.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Pandora.NetStdLibrary.Base.Identity.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Pandora.NetStdLibrary.Base.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Pandora.NetStdLibrary.Base.Identity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Attend", b =>
                {
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
                    b.HasOne("Pandora.NetStandard.Model.Entities.Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.StudentState", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Student")
                        .WithMany("SubjectStates")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Pandora.NetStandard.Model.Entities.Subject", b =>
                {
                    b.HasOne("Pandora.NetStandard.Model.Entities.Subject")
                        .WithMany("PreReqSubjects")
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
#pragma warning restore 612, 618
        }
    }
}
