using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.APP.SERVICES
{
    internal class DiscountManagerSer
    {
       public  AllRepositories<MaGiamGia> rep;
        ClassicShoeDbContext context;
        public MaGiamGia GetMaGiamGiaById(Guid id)
        {
            return rep.GetById(id);
        }

        public List<MaGiamGia> GetAllMaGiamGias()
        {
            return rep.GetAll();
        }
        public bool CreateMaGiamGia(MaGiamGia maGiamGia)
        {
            if (maGiamGia == null)
                throw new ArgumentNullException(nameof(maGiamGia), "Đối tượng mã giảm giá không được để trống.");
            DateTime today = DateTime.Today;
            if (maGiamGia.NgayBatDau < today)
                throw new ArgumentException("Ngày bắt đầu không được nhỏ hơn ngày hiện tại.");
            if (maGiamGia.NgayKetThuc < maGiamGia.NgayBatDau)
                throw new ArgumentException("Ngày kết thúc không được sớm hơn ngày bắt đầu.");
            if (maGiamGia.GT_HoaDonToiThieu <= 0)
                throw new ArgumentException("Giá trị hóa đơn tối thiểu phải lớn hơn 0.");
            if (maGiamGia.GT_ToiDaGiam <= 0)
                throw new ArgumentException("Giá trị giảm tối đa phải lớn hơn 0.");

            return rep.Create(maGiamGia);
        }


        public bool UpdateMaGiamGia(Guid id, MaGiamGia maGiamGia)
        {
            if (maGiamGia == null)
                throw new ArgumentNullException(nameof(maGiamGia), "Đối tượng mã giảm giá không được để trống.");

            var existingMaGiamGia = rep.GetById(id);
            if (existingMaGiamGia == null)
                throw new ArgumentException($"Không tìm thấy mã giảm giá với ID: {id}");
            DateTime today = DateTime.Today;
            if (maGiamGia.NgayBatDau < today)
                throw new ArgumentException("Ngày bắt đầu không được nhỏ hơn ngày hiện tại.");
            if (maGiamGia.NgayKetThuc < maGiamGia.NgayBatDau)
                throw new ArgumentException("Ngày kết thúc không được sớm hơn ngày bắt đầu.");
            if (maGiamGia.GT_HoaDonToiThieu <= 0)
                throw new ArgumentException("Giá trị hóa đơn tối thiểu phải lớn hơn 0.");
            if (maGiamGia.GT_ToiDaGiam <= 0)
                throw new ArgumentException("Giá trị giảm tối đa phải lớn hơn 0.");

            return rep.Update(id, maGiamGia);
        }


        public bool DeleteMaGiamGia(Guid id)
        {
            return rep.Delete(id);
        }



        // Lọc ra các mã giảm giá còn hiệu lực dựa trên ngày hiện tại
        public List<MaGiamGia> GetActiveMaGiamGias(DateTime currentDate)
        {
            var allMaGiamGias = rep.GetAll();
            return allMaGiamGias.Where(mgg => mgg.NgayBatDau <= currentDate && mgg.NgayKetThuc >= currentDate).ToList();
        }
    }
}

