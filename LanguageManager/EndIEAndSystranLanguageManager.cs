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
    ///The EndIEAndSystranLanguageManager recording.
    /// </summary>
    [TestModule("6f9db614-ebc6-447e-a7fb-847f056689b2", ModuleType.Recording, 1)]
    public partial class EndIEAndSystranLanguageManager : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LanguageManagerRepository repository.
        /// </summary>
        public static LanguageManagerRepository repo = LanguageManagerRepository.Instance;

        static EndIEAndSystranLanguageManager instance = new EndIEAndSystranLanguageManager();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EndIEAndSystranLanguageManager()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EndIEAndSystranLanguageManager Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.5")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'SYSTRANLanguageManager'.", repo.SYSTRANLanguageManager.SelfInfo, new RecordItemIndex(0));
            Host.Local.CloseApplication(repo.SYSTRANLanguageManager.Self, new Duration(0));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'DellOfficialSiteThePowerToDoMor'.", repo.DellOfficialSiteThePowerToDoMor.SelfInfo, new RecordItemIndex(1));
            Host.Local.CloseApplication(repo.DellOfficialSiteThePowerToDoMor.Self, new Duration(0));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}