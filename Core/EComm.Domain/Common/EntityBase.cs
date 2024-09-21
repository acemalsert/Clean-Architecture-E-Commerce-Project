using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm.Domain.Common
{
    public abstract class EntityBase : IEntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        //public virtual DateTime? UpdatedDate { get; set; }
        //public virtual DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
