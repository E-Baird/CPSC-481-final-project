using System;
using System.ComponentModel.DataAnnotations;

namespace MkrsUnion.Components
{
    public class FullServeModel
    {
        [Required]
        [Range(0, 200)]
        public int DimensionX { get; set; }

        [Required]
        [Range(0, 200)]
        public int DimensionY { get; set; }

        [Required]
        [Range(0, 180)]
        public int DimensionZ { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Email { get; set; } = "";

        [Required]
        [StringLength(8)]
        public string UCID { get; set; } = "";

    }
}

