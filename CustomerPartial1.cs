using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_Class
{    //partial cklass part_1
    public partial class CustomerPartial
    {
        private string? _firstName;
        private string? _lastName;

        public string? FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string? LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        // One part of the class contains the signature of the method.
        public partial string GetFullName();

    }
}