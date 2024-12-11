using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class hieulan1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("10c899eb-26ac-42a3-b939-0e878ecd9963"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3b6cc382-a072-4472-b1dd-4af02bb2a52d"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("0b6869f2-68e3-4888-9cb7-c9dcc03f0bc8"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("950c75c9-cd32-4784-9a95-8d5f3d403070"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("687be20a-856e-4b34-a10e-2daf03cfb6f9"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("30b0c30e-2e1c-4e74-abb4-f0a384b10d63"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("4bd1144f-9b26-4edb-b1d4-ab56744dd3d6"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("9ec7286c-1a10-4906-9cf6-98535dac9ef9"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("bc45a606-79d9-492c-81c8-ec80441bb0a0"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("02a3f4c4-ea86-482f-a8f9-0f89fa46b9f4"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("f3c87f77-51b6-4a64-9601-091a90fabb40"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("b419a7ab-2c29-48a6-b9bb-f2a19791bb6d"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("034ab49a-5a30-4c19-bffe-450c994002c0"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("161b4031-9bad-4f4a-9228-20ff403ff8ba"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" },
                    { new Guid("bf477d28-17a5-4e04-bf08-c6f01bf6b67f"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("802696d1-5c96-40df-88db-08da58ed7c9c"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("6adaf05f-21a2-40e1-8d6d-40fbb6cb113c"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("15b474f4-a960-45f0-83cd-b05adc893418"), "Xanh" },
                    { new Guid("4a9e2e3a-0e80-487f-bc3d-7f2caff0f1a5"), "Đỏ" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("3bc6a20d-b262-4775-8aa6-79f685341af5"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("d798596f-7381-4c7d-a4e4-c8787617dbfe"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("2f068639-0c48-4288-981a-a592eed31d3e"), "ADMIN", "Admin" },
                    { new Guid("7b04e111-3433-424b-a50f-9f8ddc7fdae9"), "NV", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("67afd83c-12b9-46c8-8a6a-9a3f06010c00"), "password1", "admin1", new Guid("2f068639-0c48-4288-981a-a592eed31d3e") },
                    { new Guid("914f9cfb-83ca-4d57-afae-5fb5ce0c8435"), "password2", "admin2", new Guid("2f068639-0c48-4288-981a-a592eed31d3e") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("f757d855-4100-4600-b733-cbfd970feb27"), new Guid("802696d1-5c96-40df-88db-08da58ed7c9c"), new Guid("6adaf05f-21a2-40e1-8d6d-40fbb6cb113c"), 1 });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("620adee2-b0e3-4fbf-922e-ac61a7b25426"), "Bảo hành 1 năm", new Guid("bf477d28-17a5-4e04-bf08-c6f01bf6b67f"), 1500000m, new Guid("f757d855-4100-4600-b733-cbfd970feb27"), new Guid("4a9e2e3a-0e80-487f-bc3d-7f2caff0f1a5"), new DateTime(2024, 11, 17, 7, 52, 49, 40, DateTimeKind.Local).AddTicks(3129), 10, "Nike Air Max", new Guid("3bc6a20d-b262-4775-8aa6-79f685341af5"), 1 },
                    { new Guid("c7d580f0-de53-41eb-ae1e-4610c7672f07"), "Bảo hành 6 tháng", new Guid("161b4031-9bad-4f4a-9228-20ff403ff8ba"), 1200000m, new Guid("f757d855-4100-4600-b733-cbfd970feb27"), new Guid("15b474f4-a960-45f0-83cd-b05adc893418"), new DateTime(2024, 11, 17, 7, 52, 49, 40, DateTimeKind.Local).AddTicks(3215), 15, "Nike Revolution", new Guid("d798596f-7381-4c7d-a4e4-c8787617dbfe"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("67afd83c-12b9-46c8-8a6a-9a3f06010c00"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("914f9cfb-83ca-4d57-afae-5fb5ce0c8435"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("620adee2-b0e3-4fbf-922e-ac61a7b25426"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("c7d580f0-de53-41eb-ae1e-4610c7672f07"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("7b04e111-3433-424b-a50f-9f8ddc7fdae9"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("161b4031-9bad-4f4a-9228-20ff403ff8ba"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("bf477d28-17a5-4e04-bf08-c6f01bf6b67f"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("f757d855-4100-4600-b733-cbfd970feb27"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("15b474f4-a960-45f0-83cd-b05adc893418"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("4a9e2e3a-0e80-487f-bc3d-7f2caff0f1a5"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("3bc6a20d-b262-4775-8aa6-79f685341af5"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("d798596f-7381-4c7d-a4e4-c8787617dbfe"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("2f068639-0c48-4288-981a-a592eed31d3e"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("802696d1-5c96-40df-88db-08da58ed7c9c"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("6adaf05f-21a2-40e1-8d6d-40fbb6cb113c"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("30b0c30e-2e1c-4e74-abb4-f0a384b10d63"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("4bd1144f-9b26-4edb-b1d4-ab56744dd3d6"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("b419a7ab-2c29-48a6-b9bb-f2a19791bb6d"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("034ab49a-5a30-4c19-bffe-450c994002c0"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("9ec7286c-1a10-4906-9cf6-98535dac9ef9"), "Đỏ" },
                    { new Guid("bc45a606-79d9-492c-81c8-ec80441bb0a0"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("02a3f4c4-ea86-482f-a8f9-0f89fa46b9f4"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" },
                    { new Guid("f3c87f77-51b6-4a64-9601-091a90fabb40"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("687be20a-856e-4b34-a10e-2daf03cfb6f9"), "NV", "NhanVien" },
                    { new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("10c899eb-26ac-42a3-b939-0e878ecd9963"), "password1", "admin1", new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d") },
                    { new Guid("3b6cc382-a072-4472-b1dd-4af02bb2a52d"), "password2", "admin2", new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"), new Guid("b419a7ab-2c29-48a6-b9bb-f2a19791bb6d"), new Guid("034ab49a-5a30-4c19-bffe-450c994002c0"), 1 });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0b6869f2-68e3-4888-9cb7-c9dcc03f0bc8"), "Bảo hành 1 năm", new Guid("30b0c30e-2e1c-4e74-abb4-f0a384b10d63"), 1500000m, new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"), new Guid("9ec7286c-1a10-4906-9cf6-98535dac9ef9"), new DateTime(2024, 11, 13, 6, 59, 23, 0, DateTimeKind.Local).AddTicks(9204), 10, "Nike Air Max", new Guid("f3c87f77-51b6-4a64-9601-091a90fabb40"), 1 },
                    { new Guid("950c75c9-cd32-4784-9a95-8d5f3d403070"), "Bảo hành 6 tháng", new Guid("4bd1144f-9b26-4edb-b1d4-ab56744dd3d6"), 1200000m, new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"), new Guid("bc45a606-79d9-492c-81c8-ec80441bb0a0"), new DateTime(2024, 11, 13, 6, 59, 23, 0, DateTimeKind.Local).AddTicks(9231), 15, "Nike Revolution", new Guid("02a3f4c4-ea86-482f-a8f9-0f89fa46b9f4"), 1 }
                });
        }
    }
}
