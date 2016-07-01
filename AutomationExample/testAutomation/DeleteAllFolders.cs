/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/22/2016
 * Time: 11:03 AM
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
    /// Description of DeleteAllFolders.
    /// </summary>
    [TestModule("0D10B971-4B5D-4786-80F8-83DE294A3F77", ModuleType.UserCode, 1)]
    public class DeleteAllFolders : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteAllFolders()
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
           
           try
           {
           System.IO.Directory.Delete(@"C:\Users\pandey\AppData\Local\SYSTRAN 8 Translator",true);
           Delay.Seconds(3);
           System.IO.Directory.Delete(@"C:\Users\pandey\AppData\Local\SYSTRAN_S.A",true);
            Delay.Seconds(3);
           System.IO.Directory.Delete(@"C:\Program Files (x86)\SYSTRAN 8 TRANSLATOR",true);
            Delay.Seconds(3);
           
           System.IO.Directory.Delete(@"C:\Users\pandey\AppData\Local\SYSTRAN",true); 
            Delay.Seconds(3);
           }
           catch(Exception e){
           	System.Diagnostics.Debug.WriteLine(string.Format("The error is {0}",e.Message));
           }
                             
            Delay.Seconds(2);
           
        }
    }
}
