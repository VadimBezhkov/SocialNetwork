using Entity.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Database
{
    public class LikeAvatar:Like
    {
        public Avatar Avatars { get; set; }
    }
}
