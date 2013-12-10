using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Configuration;

namespace PetFeed.Models
{
    public class Database
    {
        public static void main(String[] args)
        {
            Configuration webConfig = WebConfigurationManager.OpenMachineConfiguration(null);
            KeyValueConfigurationElement setting = webConfig.AppSettings.Settings["KierServerConnectionString"];
            Console.WriteLine(setting.Value);
        }

        public static void executeSQL(String query)
        {
            Configuration webConfig = WebConfigurationManager.OpenMachineConfiguration(null);
            KeyValueConfigurationElement setting = webConfig.AppSettings.Settings["KierServerConnectionString"];
            Console.WriteLine(setting.Value);
        }
    }
}