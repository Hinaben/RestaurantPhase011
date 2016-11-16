namespace RestaurantPhase011.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restaurant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RestaurantId { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int CategoryId { get; set; }

        [StringLength(50)]
        public string RestaurntImage { get; set; }

        [Required]
        [StringLength(50)]
        public string Region { get; set; }

        public virtual R_Category R_Category { get; set; }
    }
}
