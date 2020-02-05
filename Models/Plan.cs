using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlanner.Models
{
    public class Plan
    {
        public int PlanId { get; set; }

        public int SharedPlanId { get; set; }

        public int FloorId { get; set; }
        
        public int SharedFloorId { get; set; }
        
        public int OwnerId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
