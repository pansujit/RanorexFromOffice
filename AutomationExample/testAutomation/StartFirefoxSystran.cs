/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/14/2016
 * Time: 3:06 PM
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
	/// Description of StartFirefoxSystran.
	/// </summary>
	[TestModule("B4F38F05-A866-4060-BFBB-DA9FA566FE60", ModuleType.UserCode, 1)]
	public class StartFirefoxSystran : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public StartFirefoxSystran()
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
			Host.Local.OpenBrowser("https://trs.systran.net", "iexplore", "", false, true, false, false, false);
			Delay.Milliseconds(200);
			var repo = testAutomationRepository.Instance;
			var continueWith = repo.SignIn.ContinueWith;
			continueWith.Click();
			var usrnm = repo.SYSTRANAccountsSignIn.Usrnm;
			var psswd = repo.SYSTRANAccountsSignIn.Psswd;
			var submitLogin = repo.SYSTRANAccountsSignIn.SubmitLogin;
			usrnm.Click();
			//usrnm.Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control);
			Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
			Keyboard.Press("{DELETE}");
			usrnm.PressKeys("sujit.pandey@systrangroup.com");
			Keyboard.Press("{TAB}");
			psswd.Click();
			Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 16, Keyboard.DefaultKeyPressTime, 1, true);
			Keyboard.Press("{DELETE}");
			psswd.PressKeys("SESpassword");
			submitLogin.Click();
			Delay.Seconds(2);
		}
	}
}
