using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Generic.Core
{
    public abstract class BaseEntity
    {
        public Int64 ID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
