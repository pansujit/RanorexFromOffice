/*
 * Created by Ranorex
 * User: pandey
 * Date: 6/27/2016
 * Time: 5:38 PM
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
	/// Description of CopyLicense.
	/// </summary>
	[TestModule("D75A25E9-91D4-427C-809F-2CB2D4036D6D", ModuleType.UserCode, 1)]
	public class CopyLicense : ITestModule
	{
		
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CopyLicense()
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
			
			
			var repo = testAutomationRepository.Instance;
			var licenses = repo.TranslationResources.Licenses;
			if (licenses.Visible){
				licenses.Click();
				Delay.Seconds(2);
			}
			else{
				Console.WriteLine("Bye");
			}
			
			var productKeyCopiedToClipboard = repo.Licenses.ProductKeyCopiedToClipboard;
			
			productKeyCopiedToClipboard.Click();
			Delay.Seconds(2);
			
			
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
