﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlacementSystem.Data;

#nullable disable

namespace PlacementSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250521222126_temp10")]
    partial class temp10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlacementSystem.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Specialization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("PlacementSystem.Models.CampusDriveNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AttachmentURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Batch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BondDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("CTC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateAndTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfJoining")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptCoordinatorEmails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeptCoordinatorNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EligibleCourses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsBond")
                        .HasColumnType("bit");

                    b.Property<string>("JobLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationDeadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistrationLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SelectionProcess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Stipend")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TPOCoordinatorEmails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TPOCoordinatorNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraineeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CampusDriveNotification");
                });

            modelBuilder.Entity("PlacementSystem.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyHRContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyHREmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyHRName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyProfile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("PlacementSystem.Models.SelectionProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SelectionProcess");
                });

            modelBuilder.Entity("PlacementSystem.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
