using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteJavaCheckRewritten.Core
{
    public class Delete(CoreDetails coreDetails) : CoreDetails
    {
        private readonly CoreDetails coreDetails = coreDetails;

        public void PrintDetails()
        {
            Console.WriteLine(coreDetails.launcherName);
            Console.WriteLine(coreDetails.launcherPath);
        }

        // TODO: Link DeleteFiles() to Program.cs
        public void DeleteFiles()
        {
            Console.WriteLine($"Deleting {coreDetails.launcherName}");
            try
            {
                File.Delete(coreDetails.launcherPath + "\\javacheck.jar");
            } catch (Exception e) {
                Console.WriteLine($"Error: {e}");
                throw;
            }
            Console.WriteLine("File deleted!");
        }
    }
}
