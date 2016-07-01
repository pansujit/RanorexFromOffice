﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace LanguageManager
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartIEAndSystranLangManager recording.
    /// </summary>
    [TestModule("0f6afdb7-5eff-4213-a1a5-949cd5fb4ac7", ModuleType.Recording, 1)]
    public partial class StartIEAndSystranLangManager : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LanguageManagerRepository repository.
        /// </summary>
        public static LanguageManagerRepository repo = LanguageManagerRepository.Instance;

        static StartIEAndSystranLangManager instance = new StartIEAndSystranLangManager();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartIEAndSystranLangManager()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartIEAndSystranLangManager Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager\\SYSTRAN-Desktop-Language-Manager.exe' with arguments '--force-renderer-accessibility' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager\\SYSTRAN-Desktop-Language-Manager.exe", "--force-renderer-accessibility", "C:\\Program Files (x86)\\SYSTRAN 8 TRANSLATOR\\language-manager", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\Internet Explorer\\iexplore.exe' with arguments '' in normal mode.", new RecordItemIndex(2));
            Host.Local.RunApplication("C:\\Program Files\\Internet Explorer\\iexplore.exe", "", "C:\\Program Files\\Internet Explorer", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(3));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DellOfficialSiteThePowerToDoMor.Edit' at 232;3.", repo.DellOfficialSiteThePowerToDoMor.EditInfo, new RecordItemIndex(4));
            repo.DellOfficialSiteThePowerToDoMor.Edit.Click("232;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'http://localhost:3500/' with focus on 'DellOfficialSiteThePowerToDoMor.Edit'.", repo.DellOfficialSiteThePowerToDoMor.EditInfo, new RecordItemIndex(5));
            repo.DellOfficialSiteThePowerToDoMor.Edit.PressKeys("http://localhost:3500/");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(6));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(7));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
