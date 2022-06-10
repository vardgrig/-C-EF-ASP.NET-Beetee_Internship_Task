using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using API.Enums;
using Newtonsoft.Json;

namespace API.Entities
{
    
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }   
        public int HrDataID { get; set; }
        [JsonIgnore]
        public virtual HRData HrData { get; set; }
    }
}