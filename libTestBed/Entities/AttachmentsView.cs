namespace libTestBed.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttachmentsView")]
    public partial class AttachmentsView
    {
        [Key]
        [Column(Order = 0)]
        public Guid stream_id { get; set; }

        public byte[] file_stream { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string name { get; set; }
    }
}
