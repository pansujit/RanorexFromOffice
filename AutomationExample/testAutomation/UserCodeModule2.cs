/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/18/2016
 * Time: 6:14 PM
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
    /// Description of UserCodeModule2.
    /// </summary>
    [TestModule("13939D5A-C006-428E-83BF-BF3AC1AF1CEB", ModuleType.UserCode, 1)]
    public class UserCodeModule2 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule2()
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
            
               if (true){
            	 System.Diagnostics.Debug.WriteLine("Hello world2");
            	System.Environment.Exit(1);
            }
            System.Diagnostics.Debug.WriteLine("Hello world");
        }
    }
}
