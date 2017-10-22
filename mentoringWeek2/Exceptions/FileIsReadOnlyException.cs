using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoringWeek2.Exceptions
{
    public sealed class FileIsReadOnlyException : Exception
    {
        private readonly string _fullName;

        public FileIsReadOnlyException(string fullName)
        {
            _fullName = fullName;
        }

        public override string Message => $"File {_fullName} is read only";
    }
}
