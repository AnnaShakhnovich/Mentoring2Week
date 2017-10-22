using System;
using System.Collections.Generic;
using System.IO;
using mentoringWeek2.Exceptions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectoryNotFoundException = mentoringWeek2.Exceptions.DirectoryNotFoundException;
using FileNotFoundException = mentoringWeek2.Exceptions.FileNotFoundException;

namespace mentoringWeek2
{
    public interface IFileSystem
    {
        /// <summary>
        /// Gets file by full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <exception cref="FileNotFoundException">Thrown when file doesn't exist</exception>
        /// <returns>FileInfo</returns>
        FileInfo GetFile(string fullName);

        /// <summary>
        /// Gets directory by full name
        /// </summary>
        /// <param name="fullName"></param>
        /// <exception cref="DirectoryNotFoundException">Thrown when file doesn't exist</exception>
        /// <returns>DirectoryInfo</returns>
        DirectoryInfo GetDirectory(string fullName);

        /// <summary>
        /// Deletes file by its full file name
        /// </summary>
        /// <param name="fullName"></param>
        /// <exception cref="FileNotFoundException">Thrown when file doesn't exist</exception>
        /// <exception cref="FileIsReadOnlyException">Thrown when file is read-only</exception>
        void DeleteFile(string fullName);

        /// <summary>
        /// Delets directory by its full name
        /// </summary>
        /// <param name="fullName"></param>
        void DeleteDirectory(string fullName);

        /// <summary>
        /// Opens file for reading by its name
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <exception cref="FileNotFoundException">Thrown when file doesn't eists</exception>
        /// <returns>FileStream</returns>
        FileStream OpenRead(string fileFullName);

        /// <summary>
        /// Opens file for editing by its name 
        /// </summary>
        /// <param name="fileFullName"></param>
        /// <exception cref="FileNotFoundException">Thrown when file doesn't exist</exception>
        /// <exception cref="FileIsReadOnlyException">Thrown when file is read-only</exception>
        /// <returns></returns>
        FileStream OpenWrite(string fileFullName);

        /// <summary>
        /// Checks whether directory exists
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        bool DirectoryExists(string fullName);

        /// <summary>
        /// Checks whether file exists
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns>true</returns>
        bool FileExists(string fullName);

    }
}
