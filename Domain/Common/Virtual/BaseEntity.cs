using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Virtual
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public DateTime? UpdatedTime { get; set; } = DateTime.Now;

        public string? UpdatedBy { get; set; }
    }
}
