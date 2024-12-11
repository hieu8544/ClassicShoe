﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class ClassicShoeDbContext : DbContext
    {
        public ClassicShoeDbContext()
        {
        }
        public ClassicShoeDbContext(DbContextOptions options) : base(options)
        {
        }



        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MYPC\\HIEUPQPH;Initial Catalog=ClassicShoe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            var adminRoleId = Guid.NewGuid();
            var loaiGiayId = Guid.NewGuid();
            var hangSanXuatId = Guid.NewGuid();
            var giayId = Guid.NewGuid();
            var deGiay1Id = Guid.NewGuid(); // Replace with the actual ID of DeGiay entry if already seeded
            var deGiay2Id = Guid.NewGuid(); // Replace with the actual ID of DeGiay entry if already seeded
            var thanGiay1Id = Guid.NewGuid(); // Replace with the actual ID of ThanGiay entry if already seeded
            var thanGiay2Id = Guid.NewGuid(); // Replace with the actual ID of ThanGiay entry if already seeded
            var mauSac1Id = Guid.NewGuid(); // Replace with the actual ID of MauSac entry if already seeded
            var mauSac2Id = Guid.NewGuid(); // Replace with the actual ID of MauSac entry if already seeded

            modelBuilder.Entity<VaiTro>().HasData(
                            new VaiTro
                            {
                                Id = adminRoleId,          // Unique identifier for Admin role
                                TenVaiTro = "Admin",          // Role name
                                MaVaiTro = "ADMIN"            // Role code
                            },
                            new VaiTro
                            {
                                Id = Guid.NewGuid(),          // Unique identifier for NhanVien role
                                TenVaiTro = "NhanVien",       // Role name
                                MaVaiTro = "NV"               // Role code
                            });
            modelBuilder.Entity<Admin>().HasData(
                            new Admin
                            {
                                Id = Guid.NewGuid(),            // Unique identifier for the first Admin
                                VaiTroId = adminRoleId,         // Linking to the Admin VaiTro
                                TaiKhoan = "admin1",
                                MatKhau = "password1"           // Replace with secure hash in production
                            },
                            new Admin
                            {
                                Id = Guid.NewGuid(),            // Unique identifier for the second Admin
                                VaiTroId = adminRoleId,         // Linking to the Admin VaiTro
                                TaiKhoan = "admin2",
                                MatKhau = "password2"           // Replace with secure hash in production
                            });
            modelBuilder.Entity<MauSac>().HasData(
                            new MauSac
                            {
                                Id = mauSac1Id,
                                TenMau = "Đỏ"   // Example color name
                            },
                            new MauSac
                            {
                                Id = mauSac2Id,
                                TenMau = "Xanh" // Example color name
                            });

            modelBuilder.Entity<DeGiay>().HasData(
                            new DeGiay
                            {
                                Id = deGiay1Id,
                                TenDe = "Đế Cao Su",
                                ChatLieu = "Cao su",
                                CongNghe = "Chống trượt",
                                Mota = "Đế cao su bền chắc, khả năng chống trượt tốt"
                            },
                            new DeGiay
                            {
                                Id = deGiay2Id,
                                TenDe = "Đế Nhựa",
                                ChatLieu = "Nhựa",
                                CongNghe = "Chống mài mòn",
                                Mota = "Đế nhựa nhẹ, chịu được mài mòn cao"
                            });
            modelBuilder.Entity<ThanGiay>().HasData(
                            new ThanGiay
                            {
                                Id = thanGiay1Id,
                                Ten = "Thân Giày Da",
                                ChatLieu = "Da thật",
                                ThietKe = "Thời trang cổ điển",
                                MoTa = "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao"
                            },
                            new ThanGiay
                            {
                                Id = thanGiay2Id,
                                Ten = "Thân Giày Vải",
                                ChatLieu = "Vải canvas",
                                ThietKe = "Phong cách trẻ trung",
                                MoTa = "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động"
                            });
            modelBuilder.Entity<LoaiGiay>().HasData(
                            new LoaiGiay
                            {
                                Id = loaiGiayId,
                                TenLoai = "Sneaker",
                                PhongCach = "Thể thao",
                                MoTa = "Giày thể thao, phù hợp với nhiều hoạt động"
                            });
            modelBuilder.Entity<HangSanXuat>().HasData(
                            new HangSanXuat
                            {
                                Id = hangSanXuatId,
                                TenHang = "Nike",
                                Logo = "https://example.com/logo-nike.png",
                                Email = "support@nike.com",
                                DiaChi = "Beaverton, Oregon, USA",
                                DieuKhoan = "https://example.com/terms-nike.pdf"
                            });
            modelBuilder.Entity<Giay>().HasData(
                           new Giay
                           {
                               Id = giayId,
                               LoaiGiayId = loaiGiayId,
                               HangSanXuatId = hangSanXuatId,
                               TrangThai = 1 // 1: còn bán
                           });

            modelBuilder.Entity<GiayChiTiet>().HasData(
                           new GiayChiTiet
                           {
                               Id = Guid.NewGuid(),
                               GiayId = giayId,
                               DeGiayId = deGiay1Id,
                               ThanGiayId = thanGiay1Id,
                               MauSacId = mauSac1Id,
                               TenHang = "Nike Air Max",
                               BaoHang = "Bảo hành 1 năm",
                               NgayNhanKho = DateTime.Now,
                               Gia = 1500000, // Example price
                               SoLuong = 10,
                               TrangThai = 1 // 1: còn bán
                           },
                           new GiayChiTiet
                           {
                               Id = Guid.NewGuid(),
                               GiayId = giayId,
                               DeGiayId = deGiay2Id,
                               ThanGiayId = thanGiay2Id,
                               MauSacId = mauSac2Id,
                               TenHang = "Nike Revolution",
                               BaoHang = "Bảo hành 6 tháng",
                               NgayNhanKho = DateTime.Now,
                               Gia = 1200000, // Example price
                               SoLuong = 15,
                               TrangThai = 1 // 1: còn bán
                           });

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<DeGiay> DeGiays { get; set; }
        public DbSet<Giay> Giays { get; set; }
        public DbSet<GiayChiTiet> GiayChiTiets { get; set; }
        public DbSet<HangSanXuat> HangSanXuats { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiGiay> LoaiGiays { get; set; }
        public DbSet<MaGiamGia> MaGiamGias { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThanGiay> ThanGiays { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
    }
}
