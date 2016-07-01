/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/14/2016
 * Time: 3:14 PM
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
    /// Description of StopFirefox.
    /// </summary>
    [TestModule("0B27BB73-D878-4D7C-85A0-20191B52183E", ModuleType.UserCode, 1)]
    public class StopFirefox : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StopFirefox()
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
						    foreach (System.Diagnostics.Process exe in System.Diagnostics.Process.GetProcesses())   
						    {   
						        if (exe.ProcessName.StartsWith("SYSTRAN"))   
						            exe.Kill(); 
						        if (exe.ProcessName.StartsWith("EXCEL"))   
						            exe.Kill();
						        if (exe.ProcessName.StartsWith("WINWORD"))   
						            exe.Kill();
						        if (exe.ProcessName.StartsWith("OUTLOOK"))   
						            exe.Kill();
						        if (exe.ProcessName.StartsWith("chrome"))   
						            exe.Kill();
						        if (exe.ProcessName.StartsWith("firefox"))   
						            exe.Kill();
						        if (exe.ProcessName.StartsWith("Systran"))   
						            exe.Kill();
						        if (exe.ProcessName.StartsWith("explorer"))   
						            exe.Kill();
						  		if (exe.ProcessName.StartsWith("iexplore"))   
						            exe.Kill();
						        
						        
						    } 
						   
						
						            	         		
          
            	}catch(Exception ex){
              		Console.WriteLine(ex.StackTrace);
            	
            }
        }
    }
}
