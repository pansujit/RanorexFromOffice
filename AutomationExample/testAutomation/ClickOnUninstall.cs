/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/15/2016
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
using System.Diagnostics;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace testAutomation
{
    /// <summary>
    /// Description of ClickOnUninstall.
    /// </summary>
    [TestModule("BEFBD714-B159-456D-AFEB-2EF6857441C7", ModuleType.UserCode, 1)]
    public class ClickOnUninstall : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClickOnUninstall()
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
       
             //Click on the uninstall process
            var repo = testAutomationRepository.Instance;
            var sYSTRAN8TRANSLATOR = repo.SYSTRAN8TRANSLATOR;
                     
           // itemsView.Click();
           if(repo.SYSTRAN8TRANSLATOR.SystemItemNameDisplayInfo.Exists(3000) )
           {
           	var systemItemNameDisplay = repo.SYSTRAN8TRANSLATOR.SystemItemNameDisplay;
            //systemItemNameDisplay.Click();
            systemItemNameDisplay.DoubleClick();
            Delay.Seconds(1);
            var buttonYes = repo.SYSTRAN8TRANSLATORUninstall.ButtonYes;
            buttonYes.Click();
           repo.SYSTRAN8TRANSLATORUninstall.ButtonOKInfo.WaitForExists(300000);
           var text65535 = repo.SYSTRAN8TRANSLATORUninstall.Text65535;
           var buttonOK = repo.SYSTRAN8TRANSLATORUninstall.ButtonOK;
           buttonOK.Click();
           Delay.Seconds(2);
           }
             


        }
    }
}
