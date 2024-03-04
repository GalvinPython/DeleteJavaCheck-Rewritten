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

        public void Test2()
        {
            Console.WriteLine(coreDetails.launcherName);
            Console.WriteLine(coreDetails.launcherPath);
        }
    }
}
