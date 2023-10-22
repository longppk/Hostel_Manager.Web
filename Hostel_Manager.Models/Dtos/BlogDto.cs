using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager.Models.Dtos
{
    public class BlogDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Blog_Description { get; set; }
        public int Blog_Image { get; set; }
        public DateTime Blog_Created { get; set; }
        public int Blog_Poster { get; set; }
    }
}
