using System.Diagnostics;
using System.Linq;
namespace Framework
{
    public static class ProcessTracker
    {
        public static void KillProcesses(string processName)
        {
            var processes = Process.GetProcessesByName(processName).ToList();
            processes.ForEach(process => process.Kill());
        }
    }
}
