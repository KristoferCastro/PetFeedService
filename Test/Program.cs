using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using System.Configuration;
using System.Web.Configuration;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration webConfig = WebConfigurationManager.OpenMachineConfiguration(null);
            KeyValueConfigurationElement setting = webConfig.AppSettings.Settings["KierServerConnectionString"];
            Console.WriteLine(setting.Value);
        }
    }
}
