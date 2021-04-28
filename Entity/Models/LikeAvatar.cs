using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("LikeAvatar")]
    public class LikeAvatar
    {
        public int Id { get; set; }

      
        public int AvatarId { get; set; }

      
        public int UserId { get; set; }
        public bool Сondition { get; set; }

        [ForeignKey("AvatarId")]
        public virtual Avatar  Avatars { get; set; }
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
    }
}
