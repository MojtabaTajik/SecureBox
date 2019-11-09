using DokanNet;
using Model.Entities;
using System;
using System.IO;

namespace Service.Core
{
    internal class VirtualDriveRequestHandler
    {
        private readonly ConfigEntity _config;

        public VirtualDriveRequestHandler(ConfigEntity config)
        {
            _config = config;
        }

        public NtStatus OnRequestFileOpen(string filepath)
        {
            File.AppendAllText("log.txt", filepath + Environment.NewLine);
            return DokanResult.AccessDenied;
        }
    }
}