/*
 * Created by Ranorex
 * User: pandey
 * Date: 4/15/2016
 * Time: 3:04 PM
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
    /// Description of SelectFolderForInstallation.
    /// </summary>
    [TestModule("17BF0119-2D26-4D48-B285-149460B6A213", ModuleType.UserCode, 1)]
    public class SelectFolderForInstallation : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectFolderForInstallation()
        {
            // Do not delete - a parameterless constructor is required!
            SearchName = "none";
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        string _SearchName;
     
       [TestVariable("3274c05f-8756-4eed-a3d3-871387615427")]
       public string SearchName
        {
            get { return _SearchName; }
            set { _SearchName = value; }
        }
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
            
            if (testAutomation.ClickOnPackage.flag){
            	System.Environment.Exit(1);
            }
            
            //Choose Folder to install
          //if(!ClickOnPackage.flag)
          // {
            	System.Diagnostics.Process.Start("explorer.exe",string.Format("C:\\Users\\pandey\\Documents\\{0}",SearchName));
            	var repo = testAutomationRepository.Instance;
            	var systemItemNameDisplay = repo.SYSTRAN8TRANSLATORUninstall.SystemItemNameDisplay;
            	//systemItemNameDisplay.Click();
            	systemItemNameDisplay.DoubleClick();
            	var next = repo.WizardForm.Next;
            	next.Click();
            	var iAcceptTheAgreement = repo.WizardForm.IAcceptTheAgreement;
            	iAcceptTheAgreement.Click();
            	next.Click();
            	next.Click();
            	next.Click();
            	var createADesktopIcon = repo.WizardForm.CreateADesktopIcon;
            	next.Click();
				var install = repo.WizardForm.Install;
				install.Click();
            	repo.WizardForm.FinishInfo.WaitForExists(300000);
            	var finish = repo.WizardForm.Finish;
            	finish.Click();
            	CloseFolder.test();
            	Delay.Seconds(2);
            	//System.Diagnostics.Process.Start("explorer.exe",string.Format("C:\\Users\\pandey\\Documents\\{0}",SearchName));
            	/*systemItemNameDisplay.Click();
            	var listItem0 = repo.SYSTRAN8TRANSLATORUninstall.ListItem0;
            	Keyboard.Press(System.Windows.Forms.Keys.Delete | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            	Delay.Seconds(2);
            	var buttonYes = repo.DeleteFile.ButtonYes;
            	buttonYes.Click();
            	Delay.Seconds(2);
                CloseFolder.test();	*/
            	 try{
            		string[] filePaths = System.IO.Directory.GetFiles(@"C:\Users\pandey\Documents\SYSTRAN 8 TRANSLATOR Professional en-fr\");
						foreach (string filePath in filePaths)
							
  						System.IO.File.Delete(filePath);
            	}catch(Exception e)
            	{
            		 	System.Diagnostics.Debug.WriteLine(string.Format("The error is {0}",e.Message));
            	}
            	
            	
          //}
           //else{
          	//CloseFolder.test();
           	
          // }
            
        }
    }
}
