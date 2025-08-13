using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public abstract class _accountBaseDto
    {
        public DateTime DateCreated { get; set; }
        public string? AccountType { get; set; }
    }
}
