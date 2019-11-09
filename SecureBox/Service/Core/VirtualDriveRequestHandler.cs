using DokanNet;
using Model.Entities;
using System;
using System.IO;
using Service.Utils;
using Shared.Types;

namespace Service.Core
{
    public class VirtualDriveRequestHandler
    {
        private readonly ConfigEntity _config;
        private readonly SandboxieUtils _sandboxie = new SandboxieUtils();

        public VirtualDriveRequestHandler(ConfigEntity config)
        {
            _config = config;
        }

        public NtStatus OnRequestFileOpen(string filepath)
        {
            switch (_config.ProtectMode)
            {
                case ProtectMode.None:
                    return DokanResult.AccessDenied;

                case ProtectMode.SandboxAll:
                {
                    _sandboxie.StartSandboxed(filepath);
                    return DokanResult.Unsuccessful;
                }

                case ProtectMode.ScanAll:
                {
                    return DokanResult.AccessDenied;
                }

                case ProtectMode.ScanThenSandbox:
                {
                    return DokanResult.AccessDenied;
                }

                default:
                    return DokanResult.AccessDenied;
            }
        }
    }
}