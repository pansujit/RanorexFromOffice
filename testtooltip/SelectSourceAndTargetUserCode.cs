/*
 * Created by Ranorex
 * User: pandey
 * Date: 6/28/2016
 * Time: 3:26 PM
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

namespace testtooltip
{
    /// <summary>
    /// Description of SelectSourceAndTargetUserCode.
    /// </summary>
    [TestModule("E91BF3F5-E5A9-4EE0-A225-1021B23039D3", ModuleType.UserCode, 1)]
    public class SelectSourceAndTargetUserCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectSourceAndTargetUserCode()
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
            Delay.Seconds(1);
            var repo = testtooltipRepository.Instance;
          var btnArrowBackground1 = repo.SYSTRANInteractiveTranslator1.SomeContainer1.BtnArrowBackground1;
          btnArrowBackground1.Click();
            Delay.Milliseconds(500);
                       
            try{
            	System.Diagnostics.Debug.WriteLine(repo.SYSTRANInteractiveTranslator.EnglishInfo.Exists());
            	if(repo.SYSTRANInteractiveTranslator.EnglishInfo.Exists()){
            		var english = repo.SYSTRANInteractiveTranslator.English;
            		english.Click();
            	}
            	else{
            		var english1 = repo.SYSTRANInteractiveTranslator2.English1;
            		english1.Click();
            	}
            }catch(Exception ex){
            	Console.WriteLine(ex.StackTrace);
            }
            var btnArrowBackground = repo.SYSTRANInteractiveTranslator1.SomeContainer1.BtnArrowBackground;
                btnArrowBackground.Click();
            	Delay.Milliseconds(500);
            	
			  try{
            	System.Diagnostics.Debug.WriteLine(repo.SYSTRANInteractiveTranslator2.FrenchInfo.Exists());
            	if(repo.SYSTRANInteractiveTranslator2.FrenchInfo.Exists()){
            		var french = repo.SYSTRANInteractiveTranslator2.French;
            		french.Click();
            	}
            	else{
            		var french1 = repo.SYSTRANInteractiveTranslator2.French1;
            		french1.Click();
            	}
            }catch(Exception ex){
            	Console.WriteLine(ex.StackTrace);
            }


            
        }
    }
}
