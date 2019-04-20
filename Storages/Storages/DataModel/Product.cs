namespace Storages.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Size { get; set; }

        public int Quantity { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateFrom { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DateTo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedAt { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedAt { get; set; }

        public bool Enabled { get; set; }
    }
}
