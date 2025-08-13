using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class AccountCreationDto : _accountBaseDto
    {
        [Required(ErrorMessage ="Äccount must belong to an Existing User")]
        public Guid OwnerId { get; set; }
    }
}
