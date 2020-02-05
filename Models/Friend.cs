using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlanner.Models
{
    public class Friend
    {
        [Key]
        public int UserFriendId { get; set; }

        public int FriendID { get; set; }

        public int UserID { get; set; }

        public bool Confirmed { get; set; }
    }
}
