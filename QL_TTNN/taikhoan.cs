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
    class taikhoan
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("User")]
        public String Tk { get; set; }
        [BsonElement("Password")]
        public String Mk { get; set; }
        
        public taikhoan (string tk, string mk){
            Tk = tk;
            Mk = mk;
        }
    }
}
