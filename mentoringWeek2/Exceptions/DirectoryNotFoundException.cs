using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoringWeek2.Exceptions
{
    public sealed class DirectoryNotFoundException : Exception
    {
        private readonly string _fullName;

        public DirectoryNotFoundException(string fullName)
        {
            _fullName = fullName;
        }

        public override string Message => $"DIrectory {_fullName} not found";
    }
}
