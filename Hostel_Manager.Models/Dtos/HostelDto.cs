using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager.Models.Dtos
{
    public class HostelDto
    {
        public int Id { get; set; }
        public string Hostel_name { get; set; }
        public string Hostel_discription { get; set; }
        public string Parking { get; set; }
        public int Available { get; set; }
        public string Image_Hostel { get; set; }
        public DateTime Create { get; set; }
        public string Hostel_phone { get; set; }
        public string OwnerHostel { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Detail { get; set; }

        public int Owner { get; set; }
        public int Hostel_address { get; set; }
    }
}
