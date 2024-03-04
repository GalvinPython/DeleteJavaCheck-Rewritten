using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteJavaCheckRewritten.Core
{
    public class Detect(CoreDetails coreDetails) : CoreDetails
    {
        private readonly CoreDetails coreDetails = coreDetails;
        public (bool directoryExists, bool fileExists) RunDetection()
        {
            string launcherName = coreDetails.launcherName;
            string launcherPath = coreDetails.launcherPath;

            bool directoryExists = Directory.Exists(launcherPath);
            bool fileExists = File.Exists(Path.Combine(launcherPath, "javacheck.jar"));

            Console.Write($"{launcherName}: ");
            if (!directoryExists)
            {
                Console.Write("Targeted Launcher doesn't exist or couldn't be detected. Skipping.");
                return (false, false);
            }

            Console.Write("Launcher exists ");

            if (!fileExists)
            {
                Console.Write("but javacheck.jar doesn't exist.\n");
                return (true, false);
            }

            Console.Write("and javacheck.jar exists.\n");
            return (true, true);
        }
    }
}
