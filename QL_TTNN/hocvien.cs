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
    class hocvien
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("id_HV")]
        public String Mahv { get; set; }
        [BsonElement("TenHV")]
        public String Tenhv { get; set; }
        [BsonElement("Ngaysinh")]
        public String Nsinh { get; set; }
        [BsonElement("SDT")]
        public String Sdt { get; set; }
        [BsonElement("Diachi")]
        public String Dchi { get; set; }
        [BsonElement("id_Lop")]
        public String Malop { get; set; }

        public hocvien(string mahv, string tenhv, string nsinh, string sdt, string dchi, string malop) {

            Mahv = mahv;
            Tenhv = tenhv;
            Nsinh = nsinh;
            Sdt = sdt;
            Dchi = dchi;
            Malop = malop;
        }
    }
}
