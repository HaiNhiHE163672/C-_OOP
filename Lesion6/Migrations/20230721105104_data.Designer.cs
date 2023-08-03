﻿// <auto-generated />
using System;
using Lesion6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lesion6.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230721105104_data")]
    partial class data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lesion6.Models.HocSinh", b =>
                {
                    b.Property<int>("HocSinhId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HocSinhId"));

                    b.Property<string>("Hoten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LopId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("Quequan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HocSinhId");

                    b.HasIndex("LopId");

                    b.ToTable("HocSinhs");
                });

            modelBuilder.Entity("Lesion6.Models.Lop", b =>
                {
                    b.Property<int>("LopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LopId"));

                    b.Property<int>("Siso")
                        .HasColumnType("int");

                    b.Property<string>("Tenlop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LopId");

                    b.ToTable("Lops");
                });

            modelBuilder.Entity("Lesion6.Models.HocSinh", b =>
                {
                    b.HasOne("Lesion6.Models.Lop", "Lop")
                        .WithMany("HocSinhs")
                        .HasForeignKey("LopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("Lesion6.Models.Lop", b =>
                {
                    b.Navigation("HocSinhs");
                });
#pragma warning restore 612, 618
        }
    }
}
