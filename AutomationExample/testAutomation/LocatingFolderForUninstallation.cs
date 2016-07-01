/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/15/2016
 * Time: 10:12 AM
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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace testAutomation
{
	
    /// <summary>
    /// Description of LocatingFolder.
    /// </summary>
    [TestModule("B4EF6E13-52E8-4A18-800C-667FEF2E408F", ModuleType.UserCode, 1)]
    public class LocatingFolderForUninstallation : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LocatingFolderForUninstallation()
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
            
            
                  if (testAutomation.ClickOnPackage.flag){
            	System.Environment.Exit(1);
            }
            
            //open the folder
            System.Diagnostics.Process.Start("explorer.exe","C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR");
      


        }
    }
}
