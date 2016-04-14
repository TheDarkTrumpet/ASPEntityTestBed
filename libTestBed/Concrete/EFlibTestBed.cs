using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libTestBed.Entities;

namespace libTestBed.Concrete
{
    public class EFLibTestBed : DbContext
    {
        public EFLibTestBed(string connString) : base(connString)
        {
            
        }

        public EFLibTestBed(DbConnection connection) : base(connection, true)
        {
            
        }

        public EFLibTestBed() : base()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<AttachmentsView> AttachmentView { get; set; }
    }
}
