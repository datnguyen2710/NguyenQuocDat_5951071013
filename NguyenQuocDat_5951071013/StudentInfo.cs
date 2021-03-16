using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;

namespace NguyenQuocDat_5951071013
{

    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }
        [DataMember(Name = "STT")]
        public float STT { get; set; }
        [DataMember(Name = "DateTime")]
        public DateTime DateTime { get; set; }
    }
}