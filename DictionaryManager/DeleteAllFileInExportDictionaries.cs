/*
 * Created by Ranorex
 * User: pandey
 * Date: 6/30/2016
 * Time: 5:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using System.IO;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace DictionaryManager
{
    /// <summary>
    /// Description of DeleteAllFileInExportDictionaries.
    /// </summary>
    [TestModule("DB591D5E-5802-428A-9B72-6330455FC879", ModuleType.UserCode, 1)]
    public class DeleteAllFileInExportDictionaries : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteAllFileInExportDictionaries()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
           
            DirectoryInfo exportDictFolder= new DirectoryInfo(@"C:\\Users\\pandey\\Documents\\Ranorex\\RanorexStudio Projects\\testtooltip\\DictionaryManager\\ExportDictionaries");
            foreach (FileInfo file in exportDictFolder.GetFiles()){
            	file.Delete();
            }
        }
    }
}
