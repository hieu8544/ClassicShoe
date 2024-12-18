﻿// <auto-generated />
using System;
using ClassicShoe.DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassicShoe.DATA.Migrations
{
    [DbContext(typeof(ClassicShoeDbContext))]
    [Migration("20241117005249_hieulan1")]
    partial class hieulan1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassicShoe.DATA.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VaiTroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VaiTroId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("67afd83c-12b9-46c8-8a6a-9a3f06010c00"),
                            MatKhau = "password1",
                            TaiKhoan = "admin1",
                            VaiTroId = new Guid("2f068639-0c48-4288-981a-a592eed31d3e")
                        },
                        new
                        {
                            Id = new Guid("914f9cfb-83ca-4d57-afae-5fb5ce0c8435"),
                            MatKhau = "password2",
                            TaiKhoan = "admin2",
                            VaiTroId = new Guid("2f068639-0c48-4288-981a-a592eed31d3e")
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.DeGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongNghe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeGiays");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf477d28-17a5-4e04-bf08-c6f01bf6b67f"),
                            ChatLieu = "Cao su",
                            CongNghe = "Chống trượt",
                            Mota = "Đế cao su bền chắc, khả năng chống trượt tốt",
                            TenDe = "Đế Cao Su"
                        },
                        new
                        {
                            Id = new Guid("161b4031-9bad-4f4a-9228-20ff403ff8ba"),
                            ChatLieu = "Nhựa",
                            CongNghe = "Chống mài mòn",
                            Mota = "Đế nhựa nhẹ, chịu được mài mòn cao",
                            TenDe = "Đế Nhựa"
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Giay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HangSanXuatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LoaiGiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HangSanXuatId");

                    b.HasIndex("LoaiGiayId");

                    b.ToTable("Giays");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f757d855-4100-4600-b733-cbfd970feb27"),
                            HangSanXuatId = new Guid("802696d1-5c96-40df-88db-08da58ed7c9c"),
                            LoaiGiayId = new Guid("6adaf05f-21a2-40e1-8d6d-40fbb6cb113c"),
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.GiayChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaoHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DeGiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MauSacId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayNhanKho")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ThanGiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeGiayId");

                    b.HasIndex("GiayId");

                    b.HasIndex("MauSacId");

                    b.HasIndex("ThanGiayId");

                    b.ToTable("GiayChiTiets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("620adee2-b0e3-4fbf-922e-ac61a7b25426"),
                            BaoHang = "Bảo hành 1 năm",
                            DeGiayId = new Guid("bf477d28-17a5-4e04-bf08-c6f01bf6b67f"),
                            Gia = 1500000m,
                            GiayId = new Guid("f757d855-4100-4600-b733-cbfd970feb27"),
                            MauSacId = new Guid("4a9e2e3a-0e80-487f-bc3d-7f2caff0f1a5"),
                            NgayNhanKho = new DateTime(2024, 11, 17, 7, 52, 49, 40, DateTimeKind.Local).AddTicks(3129),
                            SoLuong = 10,
                            TenHang = "Nike Air Max",
                            ThanGiayId = new Guid("3bc6a20d-b262-4775-8aa6-79f685341af5"),
                            TrangThai = 1
                        },
                        new
                        {
                            Id = new Guid("c7d580f0-de53-41eb-ae1e-4610c7672f07"),
                            BaoHang = "Bảo hành 6 tháng",
                            DeGiayId = new Guid("161b4031-9bad-4f4a-9228-20ff403ff8ba"),
                            Gia = 1200000m,
                            GiayId = new Guid("f757d855-4100-4600-b733-cbfd970feb27"),
                            MauSacId = new Guid("15b474f4-a960-45f0-83cd-b05adc893418"),
                            NgayNhanKho = new DateTime(2024, 11, 17, 7, 52, 49, 40, DateTimeKind.Local).AddTicks(3215),
                            SoLuong = 15,
                            TenHang = "Nike Revolution",
                            ThanGiayId = new Guid("d798596f-7381-4c7d-a4e4-c8787617dbfe"),
                            TrangThai = 1
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HangSanXuat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DieuKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HangSanXuats");

                    b.HasData(
                        new
                        {
                            Id = new Guid("802696d1-5c96-40df-88db-08da58ed7c9c"),
                            DiaChi = "Beaverton, Oregon, USA",
                            DieuKhoan = "https://example.com/terms-nike.pdf",
                            Email = "support@nike.com",
                            Logo = "https://example.com/logo-nike.png",
                            TenHang = "Nike"
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaGiamGiaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTaoHoaDon")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhuongThucThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("MaGiamGiaId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GiayChiTietId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GiayChiTietId");

                    b.HasIndex("HoaDonId");

                    b.ToTable("HoaDonChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiemTichLuy")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TongChiTieu")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.LoaiGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhongCach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiGiays");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6adaf05f-21a2-40e1-8d6d-40fbb6cb113c"),
                            MoTa = "Giày thể thao, phù hợp với nhiều hoạt động",
                            PhongCach = "Thể thao",
                            TenLoai = "Sneaker"
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.MaGiamGia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GT_HoaDonToiThieu")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GT_ToiDaGiam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhanTramGiam")
                        .HasColumnType("int");

                    b.Property<string>("TenMaGiamGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaGiamGias");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MauSacs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4a9e2e3a-0e80-487f-bc3d-7f2caff0f1a5"),
                            TenMau = "Đỏ"
                        },
                        new
                        {
                            Id = new Guid("15b474f4-a960-45f0-83cd-b05adc893418"),
                            TenMau = "Xanh"
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VaiTroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VaiTroId");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.ThanGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThietKe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThanGiays");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3bc6a20d-b262-4775-8aa6-79f685341af5"),
                            ChatLieu = "Da thật",
                            MoTa = "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao",
                            Ten = "Thân Giày Da",
                            ThietKe = "Thời trang cổ điển"
                        },
                        new
                        {
                            Id = new Guid("d798596f-7381-4c7d-a4e4-c8787617dbfe"),
                            ChatLieu = "Vải canvas",
                            MoTa = "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động",
                            Ten = "Thân Giày Vải",
                            ThietKe = "Phong cách trẻ trung"
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.VaiTro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VaiTros");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f068639-0c48-4288-981a-a592eed31d3e"),
                            MaVaiTro = "ADMIN",
                            TenVaiTro = "Admin"
                        },
                        new
                        {
                            Id = new Guid("7b04e111-3433-424b-a50f-9f8ddc7fdae9"),
                            MaVaiTro = "NV",
                            TenVaiTro = "NhanVien"
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Admin", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.VaiTro", "VaiTro")
                        .WithMany("Admins")
                        .HasForeignKey("VaiTroId");

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Giay", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.HangSanXuat", "HangSanXuat")
                        .WithMany("Giays")
                        .HasForeignKey("HangSanXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.LoaiGiay", "LoaiGiay")
                        .WithMany("Giays")
                        .HasForeignKey("LoaiGiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangSanXuat");

                    b.Navigation("LoaiGiay");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.GiayChiTiet", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.DeGiay", "DeGiay")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("DeGiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.Giay", "Giay")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("GiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.MauSac", "MauSac")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("MauSacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.ThanGiay", "ThanGiay")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("ThanGiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeGiay");

                    b.Navigation("Giay");

                    b.Navigation("MauSac");

                    b.Navigation("ThanGiay");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDon", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.MaGiamGia", "MaGiamGia")
                        .WithMany()
                        .HasForeignKey("MaGiamGiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("MaGiamGia");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.GiayChiTiet", "GiayChiTiet")
                        .WithMany()
                        .HasForeignKey("GiayChiTietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiayChiTiet");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.NhanVien", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.VaiTro", "VaiTro")
                        .WithMany("NhanViens")
                        .HasForeignKey("VaiTroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.DeGiay", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Giay", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HangSanXuat", b =>
                {
                    b.Navigation("Giays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.LoaiGiay", b =>
                {
                    b.Navigation("Giays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.MauSac", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.ThanGiay", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.VaiTro", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
