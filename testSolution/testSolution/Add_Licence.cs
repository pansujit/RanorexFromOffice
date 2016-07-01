/*
 * Created by Ranorex
 * User: pandey
 * Date: 6/27/2016
 * Time: 4:29 PM
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
    /// Description of Add_Licence.
    /// </summary>
    [TestModule("671A784A-DAC8-47F0-992C-71E532FC5AD7", ModuleType.UserCode, 1)]
    public class Add_Licence : ITestModule
    {
    	// Repository object to access UI elements  
 		testSolutionRepository repo = testSolutionRepository.Instance;  
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_Licence()
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
 		/*	Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager\\" +
                       "SYSTRAN-Desktop-Language-Manager.exe' " +
                       "with arguments '--force-renderer-accessibility' in normal mode.");
            Host.Local.RunApplication("C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager\\SYSTRAN-Desktop-Language-Manager.exe", 
                                      "--force-renderer-accessibility", "C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager", false);
            Delay.Seconds(3);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\Internet Explorer\\iexplore.exe' with arguments '' in normal mode.", new RecordItemIndex(2));
            Host.Local.RunApplication("C:\\Program Files\\Internet Explorer\\iexplore.exe", "", "C:\\Program Files\\Internet Explorer", false);
            Delay.Milliseconds(1000);
       	    var webAddressField = repo.InternetExplorer.WebAddressField;
       	    webAddressField.Click();
       	     Keyboard.Press("http://localhost:3500");
       	    // Keyboard.Press("{ENTER}");
       	    // Delay.Seconds(5);
       	    //var internetExplorer = repo.InternetExplorer;
       	    webAddressField.PressKeys("{Return}");*/
       	    var licenses = repo.SYSTRANLanguageManager.Licenses;
       	    Delay.Seconds(2);
       	    licenses.Click();
       	    Delay.Seconds(2);
       	    
       	    var addProductKeyButton = repo.SYSTRANLanguageManager.AddProductKeyButton;
       	    addProductKeyButton.Click();
       	    var inputProductKey = repo.SYSTRANLanguageManager.InputProductKey;
      
       	    inputProductKey.Click();
       	    inputProductKey.Focus();
       	    Keyboard.Press(System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control, 47, Keyboard.DefaultKeyPressTime, 1, true);
       	    var submitAddProductKey = repo.SYSTRANLanguageManager.SubmitAddProductKey;
       	    submitAddProductKey.Click();
       	    Delay.Seconds(5);
       	    var onlineActivation = repo.SYSTRANLanguageManager.LicenseListContent.OnlineActivation;
       	    onlineActivation.Click();
       	    Delay.Seconds(2);
       	    
       	    Host.Local.CloseApplication(repo.SYSTRANLanguageManager.Self, new Duration(0));
       	    
       	    

            

        }
    }
}
