using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagement.Settings;

namespace UniversityManagement
{
    public static class ApplicationContext
    {
        public static AppSettings? Settings { get;private  set; }
        public static void Initialize()
        { 
          Settings =  InitializeSettings();


        }
        private static AppSettings InitializeSettings() 
        {
            string settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            settingsPath = Path.Combine(settingsPath,"UniversityManagement");
          AppSettingsHelper helper = new AppSettingsHelper(settingsPath);

          return helper.GetSettings();
        }
    }
}
