/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/21/2016
 * Time: 11:18 AM
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
	/// Description of CreateOrGetLicense.
	/// </summary>
	[TestModule("9E3A318C-F413-42D3-8FF9-2BE04B1A5CF0", ModuleType.UserCode, 1)]
	public class CreateOrGetLicense : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public CreateOrGetLicense()
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
			
			//var result = System.IO.File.ReadAllText(string.Format("C:\\Users\\pandey\\Documents\\Ranorex\\RanorexStudio Projects\\testtooltip\\AutomationExample\\SYSTRAN 8 TRANSLATOR Professional en-fr.txt"));
			var repo = testAutomationRepository.Instance;
			Host.Local.RunApplication("C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager\\SYSTRAN-Desktop-Language-Manager.exe", "--force-renderer-accessibility", "C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager", false);
			Delay.Seconds(5);
			Host.Local.OpenBrowser("http://localhost:3500/licenses", "iexplore", "", false, true, false, false, false);
			Delay.Seconds(2);
			/* System.Diagnostics.Debug.WriteLine("Entering into Menu license"+repo.SYSTRANLanguageManager.LicensesInfo.Exists());
        if(repo.SYSTRANLanguageManager.LicensesInfo.Exists())
        {
        var licenses = repo.SYSTRANLanguageManager.Licenses;
        licenses.EnsureVisible();
        licenses.Click();
        Delay.Seconds(2);
        }
        else
        {
        	System.Diagnostics.Debug.WriteLine("Entering into Menu license");
        	var licenses1 = repo.SYSTRANLanguageManager.Licenses1;
        	Delay.Seconds(2);
        	licenses1.EnsureVisible();
        	licenses1.Click();
			
        }*/
			

			System.Diagnostics.Debug.WriteLine("checking the productkey Info" + repo.SYSTRANLanguageManager.ProductKeyInfo.Exists());
			if( repo.SYSTRANLanguageManager.ProductKeyInfo.Exists())
			{
				var productKey = repo.SYSTRANLanguageManager.ProductKey;
				System.Diagnostics.Debug.WriteLine("checking the productkey" + productKey.InnerText);
				if(productKey.InnerText!=null)
				{
					var delete = repo.SYSTRANLanguageManager.Delete;
					delete.EnsureVisible();
					delete.Click();
					Delay.Seconds(2);
					var buttonTagOK = repo.SYSTRANLanguageManager.ButtonTagOK;
					buttonTagOK.EnsureVisible();
					buttonTagOK.Click();
					Delay.Seconds(2);


				}

			}
			
			
			repo.SYSTRANLanguageManager.AddProductKeyButton.EnsureVisible();
			var addProductKeyButton = repo.SYSTRANLanguageManager.AddProductKeyButton;
			addProductKeyButton.PerformClick();
			Delay.Seconds(1);
			var inputProductKey = repo.SYSTRANLanguageManager.InputProductKey;
			inputProductKey.Click();
			//inputProductKey.PressKeys(result);
			Keyboard.Press(System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control, 47, Keyboard.DefaultKeyPressTime, 1, true);
			Delay.Seconds(2);
			var submitAddProductKey = repo.SYSTRANLanguageManager.SubmitAddProductKey;
			submitAddProductKey.Click();
			repo.SYSTRANLanguageManager.OnlineActivation.EnsureVisible();
			var onlineActivation = repo.SYSTRANLanguageManager.OnlineActivation;
			onlineActivation.Click();
			Delay.Seconds(2);
			Host.Local.CloseApplication(repo.SYSTRANLanguageManager.Self, new Duration(0));
			
			
		}
	}
}
