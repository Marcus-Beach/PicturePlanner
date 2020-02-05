using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PicturePlanner.Models
{
    public class Thing
    {
        [Key]
        public int ThingId { get; set; }

        public int SharedThingId { get; set; }

        public int PublicThingId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string LocalImagePath { get; set; }
        [MaxLength(255)]
        public string SharedImagePath { get; set; }
        [MaxLength(255)]
        public string PublicImagePath { get; set; }

        public int UnitOfMeasure { get; set; }

        public double Length { get; set; }

        public double Width { get; set; }

        public double XPosition { get; set; }

        public double YPosition { get; set; }

        public double Orientation { get; set; }
    }
}
