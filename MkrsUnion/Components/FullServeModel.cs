using System;
using System.ComponentModel.DataAnnotations;

namespace MkrsUnion.Components
{
    public class FullServeModel
    {
        public ColourCategory Colour { get; set; }

        public int Copies { get; set; }

        public int DimensionX { get; set; }

        public int DimensionY { get; set; }

        public int DimensionZ { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(8)]
        public string UCID { get; set; }

        [Required]
        [StringLength(50)]
        public string Comments { get; set; }
    }
}

