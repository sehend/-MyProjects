using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class UserOperationClaim
    {
        [Key]

        public int OperationClaimId { get; set; }

        public int UserId { get; set; }

        public int UserOperationClaims { get; set; }



    }
}
