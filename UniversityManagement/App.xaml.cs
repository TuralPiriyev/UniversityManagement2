using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UniversityManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ApplicationContext.Initialize();
        }
    }

    /*
     * Faculty       Profession       Korpus
     *   id              id             id
     *                                
     *  Name            Name           Name
     *                                  
     *                Facultyid       Facultyid
     *                                  
     *                                Professionid
     * 
     * 
     * 
     * 
     */
}
