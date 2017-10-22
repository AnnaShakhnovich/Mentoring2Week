using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mentoringWeek2.Exceptions;
using DirectoryNotFoundException = mentoringWeek2.Exceptions.DirectoryNotFoundException;
using FileNotFoundException = mentoringWeek2.Exceptions.FileNotFoundException;

namespace mentoringWeek2
{
    public class FileSystem : IFileSystem
    {
        public FileInfo GetFile(string fullName)
        {
            if (FileExists(fullName))
            {
                return new FileInfo(fullName);
            }
            throw new FileNotFoundException(fullName);
        }

        public DirectoryInfo GetDirectory(string fullName)
        {
            if (DirectoryExists(fullName))
            {
                return new DirectoryInfo(fullName);
            }
            throw new DirectoryNotFoundException(fullName);
        }

        public void DeleteFile(string fullName)
        {
            if (FileExists(fullName))
            {
                File.Delete(fullName);
                return;
            }
            throw new FileNotFoundException(fullName);
        }

        public void DeleteDirectory(string fullName)
        {
            if (DirectoryExists(fullName))
            {
                Directory.Delete(fullName, true);
                return;
            }
            throw new DirectoryNotFoundException(fullName);
        }

        public FileStream OpenRead(string fileFullName)
        {
            if (FileExists(fileFullName))
                return File.OpenRead(fileFullName);
            throw new FileNotFoundException(fileFullName);
        }


        public FileStream OpenWrite(string fileFullName)
        {
            if (FileExists(fileFullName))
            {
                var fileinfo = new FileInfo(fileFullName);
                if (fileinfo.IsReadOnly)
                {
                    throw new FileIsReadOnlyException(fileFullName);
                }
                return File.OpenWrite(fileFullName);
            }
            throw new FileNotFoundException(fileFullName);
        }

        public bool DirectoryExists(string fullName)
        {
            return Directory.Exists(fullName);
        }

        public bool FileExists(string fullName)
        {
            return File.Exists(fullName);
        }
    }
}
