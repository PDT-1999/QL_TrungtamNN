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
    class lop
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("id_Lop")]
        public String Malop { get; set; }
        [BsonElement("Tenlp")]
        public String Tenlop { get; set; }
        [BsonElement("id_Khoa")]
        public String Khoa { get; set; }
        [BsonElement("id_GV")]
        public String Magv { get; set; }

        public lop(string malop, string tenlop, string khoa, string magv) {
            Malop = malop;
            Tenlop = tenlop;
            Khoa = khoa;
            Magv = magv;
        }

    }
}
