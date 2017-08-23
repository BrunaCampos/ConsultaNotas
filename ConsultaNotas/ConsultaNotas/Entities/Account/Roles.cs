using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaNotas.Entities.Account
{
    public class Roles: IdentityRole<long>
    {
        public Roles() : base()
        {

        }

        public Roles(string roleName)
        {
            Name = roleName;
        }
    }
}
