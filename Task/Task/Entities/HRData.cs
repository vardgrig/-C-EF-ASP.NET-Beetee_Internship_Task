using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace API.Entities
{
    public class HRData
    {
        [Key]
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int SSM { get; set; }
        public int Salary { get; set; }
        [JsonIgnore]
        public virtual Employee Employee { get; set; }
    }
}