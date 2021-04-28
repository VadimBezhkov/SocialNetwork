using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Message
    {
        public Message()
        {
            Avatars = new HashSet<Avatar>();
            Photos = new HashSet<Photo>();
        }
        public int Id { get; set; }
        public int DialogId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Text { get; set; }
        public bool TextChanged { get; set; }
        public virtual Dialog Dialogs { get; set; }
        public virtual ICollection<Avatar> Avatars { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        
    }
}
