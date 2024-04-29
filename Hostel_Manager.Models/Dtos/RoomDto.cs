using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager.Models.Dtos
{
    public class RoomDto
    {
        public int Id { get; set; }
        public int Hostel { get; set; }
        public string Room_description { get; set; }
        public int Number { get; set; }
        public float Electric { get; set; }
        public float Water { get; set; }
        public float Price { get; set; }
        public string Note { get; set; }
    }
}
