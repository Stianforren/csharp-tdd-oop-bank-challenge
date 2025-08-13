using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Persons
{
    public class Manager : Person
    {
        public Manager(Role role = Role.Manager) : base(role)
        {
            
        }
    }
}
