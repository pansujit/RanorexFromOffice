/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/18/2016
 * Time: 10:31 AM
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
    /// Description of CloseFolder.
    /// </summary>
    [TestModule("221F8929-9E4F-46EE-9AE0-2C2CD92A28DD", ModuleType.UserCode, 1)]
    public class CloseFolder :ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseFolder()
        {
            // Do not delete - a parameterless constructor is required!
           //var SearchName="none";
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
            
       // System.Diagnostics.Process.Start("explorer.exe",string.Format("C:\\Users\\pandey\\Documents\\{0}",SearchName)); 
       //   System.Diagnostics.Debug.WriteLine(SearchName+ "bye");  
       
       System.Diagnostics.Debug.WriteLine("I am closing");
            	try{
            		
            		 foreach (System.Diagnostics.Process exe in System.Diagnostics.Process.GetProcesses())   
						    {   
						        if (exe.ProcessName.StartsWith("explorer"))   
						            exe.Kill(); 
						      
						        
						    } 
            		
            	}catch(Exception ex)
            	{
            		Console.WriteLine( "\nMessage ---\n{0}", ex.Message );
            	}
       
       
      	 Delay.Seconds(2);
          
            
        }
        public static void test(){
            	System.Diagnostics.Debug.WriteLine("I am closing");
            	try{
            		
            		 foreach (System.Diagnostics.Process exe in System.Diagnostics.Process.GetProcesses())   
						    {   
						        if (exe.ProcessName.StartsWith("explorer"))   
						            exe.Kill(); 
						      
						        
						    } 
            		
            	}catch(Exception ex)
            	{
            		Console.WriteLine( "\nMessage ---\n{0}", ex.Message );
            	}
            	
            }
    }
}
