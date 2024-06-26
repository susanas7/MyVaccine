﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyVaccine.WebApi.Models;

#nullable disable

namespace MyVaccine.WebApi.Migrations
{
    [DbContext(typeof(MyVaccineAppDbContext))]
    [Migration("20240601033421_InitialMigration.cs")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FamilyGroupUser", b =>
                {
                    b.Property<int>("FamilyGroupsFamilyGroupId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("FamilyGroupsFamilyGroupId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("FamilyGroupUser");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.Allergy", b =>
                {
                    b.Property<int>("AllergyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllergyId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AllergyId");

                    b.HasIndex("UserId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.Dependent", b =>
                {
                    b.Property<int>("DependentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DependentId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DependentId");

                    b.HasIndex("UserId");

                    b.ToTable("Dependents");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.FamilyGroup", b =>
                {
                    b.Property<int>("FamilyGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FamilyGroupId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("FamilyGroupId");

                    b.ToTable("FamilyGroups");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.Vaccine", b =>
                {
                    b.Property<int>("VaccineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccineId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("RequiresBooster")
                        .HasColumnType("bit");

                    b.HasKey("VaccineId");

                    b.ToTable("Vaccines");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.VaccineCategory", b =>
                {
                    b.Property<int>("VaccineCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccineCategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("VaccineCategoryId");

                    b.ToTable("VaccineCategories");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.VaccineRecord", b =>
                {
                    b.Property<int>("VaccineRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VaccineRecordId"));

                    b.Property<string>("AdministeredBy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("AdministeredLocation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateAdministered")
                        .HasColumnType("datetime2");

                    b.Property<int>("DependentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VaccineId")
                        .HasColumnType("int");

                    b.HasKey("VaccineRecordId");

                    b.HasIndex("DependentId");

                    b.HasIndex("UserId");

                    b.HasIndex("VaccineId");

                    b.ToTable("VaccineRecords");
                });

            modelBuilder.Entity("VaccineVaccineCategory", b =>
                {
                    b.Property<int>("CategoriesVaccineCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("VaccinesVaccineId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesVaccineCategoryId", "VaccinesVaccineId");

                    b.HasIndex("VaccinesVaccineId");

                    b.ToTable("VaccineCategoryVaccines", (string)null);
                });

            modelBuilder.Entity("FamilyGroupUser", b =>
                {
                    b.HasOne("MyVaccine.WebApi.Models.FamilyGroup", null)
                        .WithMany()
                        .HasForeignKey("FamilyGroupsFamilyGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyVaccine.WebApi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.Allergy", b =>
                {
                    b.HasOne("MyVaccine.WebApi.Models.User", "User")
                        .WithMany("Allergies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.Dependent", b =>
                {
                    b.HasOne("MyVaccine.WebApi.Models.User", "User")
                        .WithMany("Dependents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.VaccineRecord", b =>
                {
                    b.HasOne("MyVaccine.WebApi.Models.Dependent", "Dependent")
                        .WithMany("VaccineRecords")
                        .HasForeignKey("DependentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyVaccine.WebApi.Models.User", "User")
                        .WithMany("VaccineRecords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MyVaccine.WebApi.Models.Vaccine", "Vaccine")
                        .WithMany()
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dependent");

                    b.Navigation("User");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("VaccineVaccineCategory", b =>
                {
                    b.HasOne("MyVaccine.WebApi.Models.VaccineCategory", null)
                        .WithMany()
                        .HasForeignKey("CategoriesVaccineCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyVaccine.WebApi.Models.Vaccine", null)
                        .WithMany()
                        .HasForeignKey("VaccinesVaccineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.Dependent", b =>
                {
                    b.Navigation("VaccineRecords");
                });

            modelBuilder.Entity("MyVaccine.WebApi.Models.User", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("Dependents");

                    b.Navigation("VaccineRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
