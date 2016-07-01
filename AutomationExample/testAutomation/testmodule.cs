/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/18/2016
 * Time: 2:43 PM
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
    /// Description of Testmodule.
    /// </summary>
    [TestModule("A55D1797-109D-45DC-8A85-69C672988D4D", ModuleType.UserCode, 1)]
    public class Testmodule : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Testmodule()
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
            
            System.Diagnostics.Process.Start("explorer.exe","C:\\Users\\pandey\\Documents\\SYSTRAN 8 TRANSLATOR Professional en-fr");
            var repo = testAutomationRepository.Instance;
            	var systemItemNameDisplay = repo.SYSTRAN8TRANSLATORUninstall.SystemItemNameDisplay;
            	systemItemNameDisplay.Click();
            	var listItem0 = repo.SYSTRAN8TRANSLATORUninstall.ListItem0;
            	Keyboard.Press(System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Thread.Sleep(1000);
            	var buttonYes = repo.DeleteFile.ButtonYes;
            	buttonYes.Click();
            	Thread.Sleep(1000);
        }
    }
}
