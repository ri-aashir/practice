using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class AccountDto : _accountBaseDto
    {
        public Guid Id { get; set; } 
    }
}
