// Coded by GhostHacker - Telegram | https://t.me/GhostHackersNetwork
using Stub.Modules.InternalFuncs;
using Stub.Modules.Protects;

namespace Stub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllChecker.Protect();
            InternalMain.Execute();
        }
    }
}
