using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ExamWeb_BuiDucManh.Models
{
    public class Phim
    {
        public int Id { get; set; }
     //   [StringLenght(250)]
        public string TuaDe { get; set; }
        public string DienVien { get; set; }
        public bool TrongNuoc { get; set; }

        public double GiaVe { get; set; }
        public int ThoiLuong { get; set; }
    }
}
