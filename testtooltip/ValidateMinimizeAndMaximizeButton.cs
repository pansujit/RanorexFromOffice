/*
 * Created by Ranorex
 * User: pandey
 * Date: 6/29/2016
 * Time: 9:32 AM
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
using System.Xml;
namespace testtooltip
{
    /// <summary>
    /// Description of ValidateMinimizeAndMaximizeButton.
    /// </summary>
    [TestModule("535B4727-1992-4DD9-8C73-C54654B44C57", ModuleType.UserCode, 1)]
    public class ValidateMinimizeAndMaximizeButton : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateMinimizeAndMaximizeButton()
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
            var repo = testtooltipRepository.Instance;
           var someElement1 = repo.SYSTRANInteractiveTranslator1.SomeContainer3.SomeElement1;
           someElement1.MoveTo();
           Delay.Seconds(1);
           Validate.Attribute(repo.Minimize.SelfInfo,"text","Minimize");
           try{
           	 if(repo.SYSTRANInteractiveTranslator1.SomeContainer3.PARTMaxPathInfo.Exists()){
           	var maximize = repo.SYSTRANInteractiveTranslator1.SomeContainer3.PARTMaxPath;
            maximize.MoveTo();
            Validate.Attribute(repo.Maximize.SelfInfo,"text","Maximize");
                     
           	}
           	
           }catch(Exception ex){
           	Console.WriteLine(ex.StackTrace);
           }
           
     
	        

            
        }
    }
}
