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
    class khoahoc
    {
        [BsonId]
        public ObjectId Id {get; set;}
        [BsonElement("id_Khoa")]
        public String Makhoa { get; set; }
        [BsonElement("Ngonngu")]
        public String NgonNgu { get; set;}
        [BsonElement("Trinhdo")]
        public String TrinhDo { get; set; }
        [BsonElement("TGbatdau")]
        public String Tgianbd { get; set; }
        [BsonElement("Thoiluong")]
        public String Tluong { get; set; }

        public khoahoc( string makhoa, string ngonngu, string trinhdo, string tgianbd, string tluong) {
            Makhoa = makhoa;
            NgonNgu = ngonngu;
            TrinhDo = trinhdo;
            Tgianbd = tgianbd;
            Tluong = tluong;
        } 
    }
}
