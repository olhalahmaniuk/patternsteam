namespace Storages.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

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

        public virtual Client Client { get; set; }
    }
}
