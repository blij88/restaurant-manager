using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantManager.web.Data
{
    public class EmployeeData : IdentityUser
    {

        public enum Functions { Bartender, Chef, Waiter, Admin }
        public Functions Function { get; set; }
    }
}
