using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Bson;

namespace QL_TTNN
{
    class giangvien
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("id_GV")]
        public String MaGV { get; set; }
        [BsonElement("TenGV")]
        public String Tengv { get; set; }
        [BsonElement("Ngaysinh")]
        public String Nsinh { get; set; }
        [BsonElement("Diachi")]
        public String Diachi { get; set; }
        [BsonElement("SDT")]
        public string SDT { get; set; }
        [BsonElement("Luongcb")]
        public Double Luong { get; set; }

        public giangvien(string maGV, string tenGV, string nsinh, string diachi, string sdt, double luong)
        {
            MaGV = maGV;
            Tengv = tenGV;
            Nsinh = nsinh;
            Diachi = diachi;
            SDT = sdt;
            Luong = luong;
        }

    }
}
