using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace LilaWay
{
    [FirestoreData]
     public class register
    {

        [FirestoreProperty]
        public string userName { get; set; }
        [FirestoreProperty]
        public string password { get; set; }
        [FirestoreProperty]
        public string userType { get; set; }
        [FirestoreProperty]
        public string carModel { get; set; }
        [FirestoreProperty]
        public string curp { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty ]
        public string id { get; set; }
        [FirestoreProperty]
        public string lastName { get; set; }
        [FirestoreProperty]
        public string name { get; set; }
        [FirestoreProperty]
        public string phone { get; set; }
        [FirestoreProperty]
        public string places { get; set; }
    }
}
