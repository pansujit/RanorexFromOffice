/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/15/2016
 * Time: 1:17 PM
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
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("B1E09BF0-3C5B-4547-8688-8D6679F47E9F", ModuleType.UserCode, 1)]
    public class DeleteLicenseKeyIfExist : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteLicenseKeyIfExist()
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
            
            var repo = testAutomationRepository.Instance;
            if( repo.SYSTRANLanguageManager.ProductKeyInfo.Exists())
            {
            var productKey = repo.SYSTRANLanguageManager.ProductKey;
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
			
        }
    }
}
