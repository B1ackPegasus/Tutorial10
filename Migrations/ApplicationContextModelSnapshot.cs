﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tutorial10.Data;

#nullable disable

namespace Tutorial10.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tutorial10.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "jkowalski@gmail.com",
                            FirstName = "John",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "bond@gmail.com",
                            FirstName = "Johnny",
                            LastName = "Bond"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "mick@gmail.com",
                            FirstName = "Kyle",
                            LastName = "Mickiewicz"
                        });
                });

            modelBuilder.Entity("Tutorial10.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedicament"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament");

                    b.ToTable("medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Good against pain",
                            Name = "Nimesil",
                            Type = "Safe"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Good against sore throat",
                            Name = "Strepsils",
                            Type = "Safe"
                        },
                        new
                        {
                            IdMedicament = 3,
                            Description = "Good",
                            Name = "Vitamin C",
                            Type = "Safe"
                        });
                });

            modelBuilder.Entity("Tutorial10.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatient"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPatient");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateOnly(1987, 10, 12),
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateOnly(1989, 3, 1),
                            FirstName = "Ann",
                            LastName = "Smith"
                        },
                        new
                        {
                            IdPatient = 3,
                            BirthDate = new DateOnly(1990, 11, 3),
                            FirstName = "Jack",
                            LastName = "Taylor"
                        });
                });

            modelBuilder.Entity("Tutorial10.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrescription"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DueDate")
                        .HasColumnType("date");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateOnly(2020, 12, 12),
                            DueDate = new DateOnly(2022, 1, 1),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateOnly(2020, 11, 11),
                            DueDate = new DateOnly(2022, 1, 1),
                            IdDoctor = 3,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPrescription = 3,
                            Date = new DateOnly(2021, 10, 12),
                            DueDate = new DateOnly(2032, 1, 10),
                            IdDoctor = 1,
                            IdPatient = 3
                        });
                });

            modelBuilder.Entity("Tutorial10.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription", "IdMedicament");

                    b.HasIndex("IdMedicament");

                    b.ToTable("prescription_medicament");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            IdMedicament = 3,
                            Details = "once a day",
                            Dose = 1
                        },
                        new
                        {
                            IdPrescription = 1,
                            IdMedicament = 2,
                            Details = "every hour for a week"
                        },
                        new
                        {
                            IdPrescription = 2,
                            IdMedicament = 1,
                            Details = "in case of pain"
                        },
                        new
                        {
                            IdPrescription = 3,
                            IdMedicament = 1,
                            Details = "in case of pain"
                        });
                });

            modelBuilder.Entity("Tutorial10.Models.Prescription", b =>
                {
                    b.HasOne("Tutorial10.Models.Doctor", "Doctor")
                        .WithMany("Prescription")
                        .HasForeignKey("IdDoctor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tutorial10.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Tutorial10.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("Tutorial10.Models.Medicament", "Medicament")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tutorial10.Models.Prescription", "Prescription")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicament");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Tutorial10.Models.Doctor", b =>
                {
                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("Tutorial10.Models.Medicament", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });

            modelBuilder.Entity("Tutorial10.Models.Patient", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Tutorial10.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
