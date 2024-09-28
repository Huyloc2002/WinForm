using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Sanbong
    {
        public int id { get; set; }
        public string tensan { get; set; }
        public string diachi { get; set; }
        public decimal giathue { get; set; }
        public enum trangthai
        {
            cosan,
            thue,
            dangbaotri
        }

        public Sanbong()
        {
                
        }

        public Sanbong(int id, string tensan, string diachi, decimal giathue)
        {
            this.id = id;
            this.tensan = tensan;
            this.diachi = diachi;
            this.giathue = giathue;
        }
    }
}
