using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    class DTO_Hang
    {
        private string tenhang;
        private int soluong;
        private float dongianhap;
        private float dongiaban;
        private string hinhanh;
        private string ghichu;
        private string manv;
        public bool a()
        {
            return true;
        }
        public string Tenhang
        {
            get
            {
                return tenhang;
            }
            set
            {
                tenhang = value;
            }
        }
        public int Soluong
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
        public float Dongianhap
        {
            get
            {
                return dongianhap;
            }
            set
            {
                dongianhap = value;
            }
        }
        public float Dongiaban
        {
            get
            {
                return dongiaban;
            }
            set
            {
                dongiaban= value;
            }
        }
        public string Hinhanh
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
            }
        }
        public string Ghichu
        {
            get
            {
                return ghichu;
            }
            set
            {
                ghichu = value;
            }
        }
        public string Manv
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
            }
        }
        public DTO_Hang(string tenhang, int soluong,float dongianhap, float dongiaban, string hinhanh, string ghichu,string manv)
        {
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.dongianhap = dongianhap;
            this.dongiaban = dongiaban;
            this.hinhanh = hinhanh;
            this.ghichu = ghichu;
            this.manv = manv;

        }
    }
}
