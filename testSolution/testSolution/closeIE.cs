/*
 * Created by Ranorex
 * User: pandey
 * Date: 6/27/2016
 * Time: 5:30 PM
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

namespace testSolution
{
	/// <summary>
	/// Description of CloseIE.
	/// </summary>
	[TestModule("AB847CF6-09B7-4745-81D0-2CE778E199D7", ModuleType.UserCode, 1)]
	public class CloseIE : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CloseIE()
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
			
	
			
			try
			{
				foreach (System.Diagnostics.Process exe in System.Diagnostics.Process.GetProcesses())
				{
					if (exe.ProcessName.StartsWith("iexplore"))
						exe.Kill();
					
					
					
				}
				
				
				
				
			}catch(Exception ex){
				Console.WriteLine(ex.StackTrace);
				
			}
		}
	}
}
