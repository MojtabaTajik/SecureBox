using DokanNet;
using System;
using System.IO;

namespace Service.Core
{
    internal class VirtualDriveRequestHandler
    {
        public NtStatus OnRequestFileOpen(string filepath)
        {
            File.AppendAllText("log.txt", filepath + Environment.NewLine);
            return DokanResult.AccessDenied;
        }
    }
}