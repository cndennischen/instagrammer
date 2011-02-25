﻿using System.Runtime.Serialization;

namespace Instagram.Wrapper.Models {

    [DataContract]
    public partial class Location {
        public string id { get; set; }
        [DataMember]
        public string latitude { get; set; }
        [DataMember]
        public string longitude { get; set; }
        [DataMember]
        public string name { get; set; }
    }
}
