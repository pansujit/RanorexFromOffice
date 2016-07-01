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

namespace QFT
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TranslateAndValidate recording.
    /// </summary>
    [TestModule("7e2ff76d-1d73-402d-8ae9-be4a12bd9162", ModuleType.Recording, 1)]
    public partial class TranslateAndValidate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the QFTRepository repository.
        /// </summary>
        public static QFTRepository repo = QFTRepository.Instance;

        static TranslateAndValidate instance = new TranslateAndValidate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TranslateAndValidate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TranslateAndValidate Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.6")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.6")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANQuickFileTranslator.SearchFiles' at 32;5.", repo.SYSTRANQuickFileTranslator.SearchFilesInfo, new RecordItemIndex(0));
            repo.SYSTRANQuickFileTranslator.SearchFiles.Click("32;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SYSTRANQuickFileTranslator.Root.Translate' at 32;10.", repo.SYSTRANQuickFileTranslator.Root.TranslateInfo, new RecordItemIndex(1));
            repo.SYSTRANQuickFileTranslator.Root.Translate.Click("32;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Duration') on item 'SYSTRANQuickFileTranslator.Root.Duration'.", repo.SYSTRANQuickFileTranslator.Root.DurationInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.SYSTRANQuickFileTranslator.Root.DurationInfo, "Text", "Duration");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Target') on item 'SYSTRANQuickFileTranslator.Root.Target'.", repo.SYSTRANQuickFileTranslator.Root.TargetInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.SYSTRANQuickFileTranslator.Root.TargetInfo, "Text", "Target");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}