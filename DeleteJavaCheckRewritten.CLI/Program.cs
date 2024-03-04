/**
 * As of right now, only Windows is supported.
 * Support for custom install locations and other Operating Systems will come soon.
 */

using DeleteJavaCheckRewritten.Core;

namespace DeleteJavaCheckRewritten.CLI
{
    internal class Program: CoreDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DeleteJavaCheck Rewritten Running!");
            Console.WriteLine("https://github.com/GalvinPython/DeleteJavaCheck-Rewritten");
            Console.WriteLine("NOTE: Custom Install Locations are not yet supported\n");
            CoreDetails legacyLauncherDetails = new()
            {
                launcherPath = "C:\\Program Files (x86)\\Minecraft Launcher\\game",
                launcherName = "Minecraft Legacy Launcher"
            };
            CoreDetails newLauncherDetails = new()
            {
                launcherPath = Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%\\Packages\\Microsoft.4297127D64EC6_8wekyb3d8bbwe\\LocalCache\\Local\\game"),
                launcherName = "Minecraft Bedrock Launcher"
            };

            CoreDetails.Test();

            Console.WriteLine("\nINFO: Targeted Launcher Locations");
            Delete deleteLegacy = new(legacyLauncherDetails);
            Delete deleteNew = new(newLauncherDetails);
            deleteLegacy.Test2();
            deleteNew.Test2();

            // Run detections for legacy and new launcher details
            Console.WriteLine("\nTASK: Running Detections!");
            Detect detectLegacy = new Detect(legacyLauncherDetails);
            Detect detectNew = new Detect(newLauncherDetails);

            (bool legacyDirExists, bool legacyFileExists) = detectLegacy.RunDetection();
            (bool newDirExists, bool newFileExists) = detectNew.RunDetection();
        }
    }
}
