using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_Class
{   //partial class part 2
    public partial class CustomerPartial
    {
        // An implementation can be defined in the same part or another part
        public partial string GetFullName()
        {
            string fullName = _firstName + " " + _lastName;
            return fullName;
        }
    }
}
