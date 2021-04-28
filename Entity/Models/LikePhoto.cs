using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class LikePhoto
    {
        public int Id { get; set; }
        public int PhotoId { get; set; }
        public int UserId { get; set; }
        public bool Сondition { get; set; }

        [ForeignKey("UserId")]
        public virtual User Users { get; set; }

        [ForeignKey("PhotoId")]
        public virtual Photo Photos { get; set; }
    }
}
