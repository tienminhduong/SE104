﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250530053639_DbMigration")]
    partial class DbMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.5");

            modelBuilder.Entity("DTO.BangDiemMon", b =>
                {
                    b.Property<string>("MaHocSinh")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaMH")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaHK")
                        .HasColumnType("TEXT");

                    b.Property<float?>("Diem15P")
                        .HasColumnType("REAL");

                    b.Property<float?>("Diem1T")
                        .HasColumnType("REAL");

                    b.Property<float?>("DiemCuoiKy")
                        .HasColumnType("REAL");

                    b.HasKey("MaHocSinh", "MaMH", "MaHK");

                    b.HasIndex("MaHK");

                    b.HasIndex("MaMH");

                    b.ToTable("BANGDIEMMON");
                });

            modelBuilder.Entity("DTO.HocKy", b =>
                {
                    b.Property<string>("MaHK")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenHK")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaHK");

                    b.ToTable("HOCKY", (string)null);

                    b.HasData(
                        new
                        {
                            MaHK = "HK1",
                            TenHK = "Học kỳ 1"
                        },
                        new
                        {
                            MaHK = "HK2",
                            TenHK = "Học kỳ 2"
                        });
                });

            modelBuilder.Entity("DTO.HocSinh", b =>
                {
                    b.Property<string>("MaHS")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MaLop")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("TEXT");

                    b.HasKey("MaHS");

                    b.HasIndex("MaLop");

                    b.ToTable("HOCSINH");
                });

            modelBuilder.Entity("DTO.Khoi", b =>
                {
                    b.Property<string>("MaKhoi")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("TenKhoi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaKhoi");

                    b.ToTable("KHOI");

                    b.HasData(
                        new
                        {
                            MaKhoi = "K010",
                            TenKhoi = "Khối 10"
                        },
                        new
                        {
                            MaKhoi = "K011",
                            TenKhoi = "Khối 11"
                        },
                        new
                        {
                            MaKhoi = "K012",
                            TenKhoi = "Khối 12"
                        });
                });

            modelBuilder.Entity("DTO.Lop", b =>
                {
                    b.Property<string>("MaLop")
                        .HasMaxLength(4)
                        .HasColumnType("TEXT");

                    b.Property<string>("MaKhoi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaLop");

                    b.HasIndex("MaKhoi");

                    b.ToTable("LOP");

                    b.HasData(
                        new
                        {
                            MaLop = "10A1",
                            MaKhoi = "K010",
                            TenLop = "10A1"
                        },
                        new
                        {
                            MaLop = "10A2",
                            MaKhoi = "K010",
                            TenLop = "10A2"
                        },
                        new
                        {
                            MaLop = "10A3",
                            MaKhoi = "K010",
                            TenLop = "10A3"
                        },
                        new
                        {
                            MaLop = "10A4",
                            MaKhoi = "K010",
                            TenLop = "10A4"
                        },
                        new
                        {
                            MaLop = "11A1",
                            MaKhoi = "K011",
                            TenLop = "11A1"
                        },
                        new
                        {
                            MaLop = "11A2",
                            MaKhoi = "K011",
                            TenLop = "11A2"
                        },
                        new
                        {
                            MaLop = "11A3",
                            MaKhoi = "K011",
                            TenLop = "11A3"
                        },
                        new
                        {
                            MaLop = "12A1",
                            MaKhoi = "K012",
                            TenLop = "12A1"
                        },
                        new
                        {
                            MaLop = "12A2",
                            MaKhoi = "K012",
                            TenLop = "12A2"
                        });
                });

            modelBuilder.Entity("DTO.MonHoc", b =>
                {
                    b.Property<string>("MaMH")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenMH")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaMH");

                    b.ToTable("MONHOC", (string)null);

                    b.HasData(
                        new
                        {
                            MaMH = "TOAN",
                            TenMH = "Toán học"
                        },
                        new
                        {
                            MaMH = "VAN",
                            TenMH = "Ngữ văn"
                        },
                        new
                        {
                            MaMH = "LY",
                            TenMH = "Vật lý"
                        },
                        new
                        {
                            MaMH = "HOA",
                            TenMH = "Hóa học"
                        },
                        new
                        {
                            MaMH = "ANH",
                            TenMH = "Tiếng Anh"
                        });
                });

            modelBuilder.Entity("DTO.ThamSo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MocDiemDat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SiSoToiDa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TuoiToiDa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TuoiToiThieu")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("THAMSO");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MocDiemDat = 0,
                            SiSoToiDa = 40,
                            TuoiToiDa = 20,
                            TuoiToiThieu = 15
                        });
                });

            modelBuilder.Entity("DTO.BangDiemMon", b =>
                {
                    b.HasOne("DTO.HocKy", "HocKy")
                        .WithMany("BangDiemMons")
                        .HasForeignKey("MaHK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.HocSinh", "HocSinh")
                        .WithMany()
                        .HasForeignKey("MaHocSinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DTO.MonHoc", "MonHoc")
                        .WithMany("BangDiemMons")
                        .HasForeignKey("MaMH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocKy");

                    b.Navigation("HocSinh");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("DTO.HocSinh", b =>
                {
                    b.HasOne("DTO.Lop", "Lop")
                        .WithMany("HocSinhs")
                        .HasForeignKey("MaLop");

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("DTO.Lop", b =>
                {
                    b.HasOne("DTO.Khoi", "Khoi")
                        .WithMany("Lops")
                        .HasForeignKey("MaKhoi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoi");
                });

            modelBuilder.Entity("DTO.HocKy", b =>
                {
                    b.Navigation("BangDiemMons");
                });

            modelBuilder.Entity("DTO.Khoi", b =>
                {
                    b.Navigation("Lops");
                });

            modelBuilder.Entity("DTO.Lop", b =>
                {
                    b.Navigation("HocSinhs");
                });

            modelBuilder.Entity("DTO.MonHoc", b =>
                {
                    b.Navigation("BangDiemMons");
                });
#pragma warning restore 612, 618
        }
    }
}
