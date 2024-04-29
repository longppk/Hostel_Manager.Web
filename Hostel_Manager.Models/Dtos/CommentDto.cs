using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Manager.Models.Dtos
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Comment_Image { get; set; }
        public int Comment_Poster { get; set; }
        public DateTime Comment_Created { get; set; }
    }
}
