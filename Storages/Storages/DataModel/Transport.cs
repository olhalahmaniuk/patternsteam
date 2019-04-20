using Storages.Patterns.Abstract_factory;

namespace Storages.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transport")]
    public partial class Transport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int ProductTypeId { get; set; }

        public int GarageId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Freespace { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public bool Available { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedAt { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedAt { get; set; }

        public bool Enabled { get; set; }
    }
}
